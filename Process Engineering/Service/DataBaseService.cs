using Process_Engineering.DTO;
using Process_Engineering.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process_Engineering.Service
{
    internal class DataBaseService
    {
        #region База

        public static User user;
        public static bool isDataBaseConnected;
        public enum RequestType
        {
            GET,
            POST,
            PUT,
            DELETE
        }

        private static HttpClient http = new HttpClient();

        static DataBaseService()
        {
            http.BaseAddress = new Uri("http://10.182.134.219:8090"); // http://localhost:8090 http://10.182.134.219:8090
        }

        private static async Task<HttpResponseMessage> sendRequest(RequestType requestType, string uri, HttpContent content = null)
        {
            try
            {
                isDataBaseConnected = true;
                switch (requestType)
                {
                    case RequestType.GET:
                        return await http.GetAsync(uri);
                    case RequestType.POST:
                        return await http.PostAsync(uri, content);
                    case RequestType.PUT:
                        return await http.PutAsync(uri, content);
                    case RequestType.DELETE:
                        return await http.DeleteAsync(uri);
                }
                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
            }
            catch (HttpRequestException e)
            {
                isDataBaseConnected = false;
                MessageBox.Show(e.Message, "Ошибка сети", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                //Logger.logError($"Ошибка доступа в базу данных {requestType} {uri} {content} {e.Message}");
                HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.Conflict);
                response.Content = new StringContent(JsonSerializer.Serialize(
                    new GeneralResponse<object>(false, e.Message)), Encoding.UTF8, "application/json");
                return response;
            }
        }

        internal static async Task<GeneralResponse<T>> create<T>(string uri, object value)
        {
            try
            {
                HttpResponseMessage response = await sendRequest(RequestType.POST, uri,
                    new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json"));
                return JsonSerializer.Deserialize<GeneralResponse<T>>(response.Content.ReadAsStringAsync().Result);
            }
            catch (Exception ex) when (ex is HttpRequestException || ex is JsonException)
            {
                return new GeneralResponse<T>(false, ConstStorage.UNKNOWN_ERROR);
            }
        }

        internal static async Task<T> get<T>(string uri)
        {
            try
            {
                HttpResponseMessage response = await sendRequest(RequestType.GET, uri);
                return JsonSerializer.Deserialize<T>(response.Content.ReadAsStringAsync().Result);
            }
            catch (Exception ex) when (ex is HttpRequestException || ex is JsonException)
            {
                return (T)Activator.CreateInstance(typeof(T));
            }
        }

        private static async Task<GeneralResponse<T>> update<T>(string uri, object value = null)
        {
            try
            {
                HttpResponseMessage response = await sendRequest(RequestType.PUT, uri,
                    new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json"));
                return JsonSerializer.Deserialize<GeneralResponse<T>>(response.Content.ReadAsStringAsync().Result);
            }
            catch (Exception ex) when (ex is HttpRequestException || ex is JsonException)
            {
                return new GeneralResponse<T>(false, ConstStorage.UNKNOWN_ERROR);
            }
        }

        private static async Task<GeneralResponse<T>> delete<T>(string uri)
        {
            try
            {
                HttpResponseMessage response = await sendRequest(RequestType.DELETE, uri);
                return JsonSerializer.Deserialize<GeneralResponse<T>>(response.Content.ReadAsStringAsync().Result);
            }
            catch (Exception ex) when (ex is HttpRequestException || ex is JsonException)
            {
                return new GeneralResponse<T>(false, ConstStorage.UNKNOWN_ERROR);
            }
        }

        #endregion

        #region Пользователи и авторизация

        public static void addAuthorization(string username, string password)
        {
            string basicAuthenticationValue = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
            http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", basicAuthenticationValue);
        }

        public static void updateAuthorization()
        {
            addAuthorization(user.idIntern, user.password);
        }

        public static void clearUser()
        {
            user = null;
            http.DefaultRequestHeaders.Authorization = null;
        }

        public static async Task<GeneralResponse<User>> createUser(User user)
        {
            return await create<User>($"api/user", user);
        }

        public static async Task<List<User>> getUserList()
        {
            return await get<List<User>>($"api/user");
        }

        public static async Task<List<User>> getCardCreatorList()
        {
            return await get<List<User>>($"api/card/creator");
        }

        public static async Task<GeneralResponse<object>> updateUser(User user)
        {
            return await update<object>($"api/user/{user.id}", user);
        }

        public static async Task<GeneralResponse<object>> logIn(string username, string password)
        {
            GeneralResponse<object> generalResponse = new GeneralResponse<object>();
            try
            {
                addAuthorization(username, password);
                HttpResponseMessage response = await sendRequest(RequestType.GET, $"api/user/auth");
                if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    generalResponse.message = ConstStorage.WRONG_USER_PASSWORD;
                }
                response.EnsureSuccessStatusCode();
                user = JsonSerializer.Deserialize<User>(response.Content.ReadAsStringAsync().Result);
                user.password = password;
                generalResponse.isResultOK = true;
            }
            catch (HttpRequestException)
            {
                clearUser();
            }
            return generalResponse;
        }

        public static async Task<GeneralResponse<object>> changePassword(string newPassword)
        {
            return await update<object>($"api/user/pass?value={newPassword}");
        }

        #endregion

        #region Гаммы

        public static GeneralResponse<Card> createProcessCard(Card card)
        {
            MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
            foreach (Card.Page page in card.pages)
            {
                if (page.picture == null)
                {
                    continue;
                }
                Stream stream = new MemoryStream();
                page.picture.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                stream.Position = 0;
                multipartFormDataContent.Add(new StreamContent(stream),
                    "pictures", $"page{card.pages.IndexOf(page) + 1}.jpg");
            }
            if (multipartFormDataContent.Count() == 0)
            {
                multipartFormDataContent.Add(new StreamContent(Stream.Null), "pictures", "noPicture.jpg");
            }
            multipartFormDataContent.Add(new StringContent(JsonSerializer.Serialize(CardRequest.fromCard(card)),
                Encoding.UTF8, "application/json"), "cardRequest");

            try
            {
                HttpResponseMessage response = card.id == null
                ? http.PostAsync("api/card", multipartFormDataContent).Result
                : card.version != 0 ? http.PutAsync($"api/card/{card.id}", multipartFormDataContent).Result
                                    : http.PostAsync($"api/card/{card.number}/version", multipartFormDataContent).Result;

                return JsonSerializer.Deserialize<GeneralResponse<Card>>(response.Content.ReadAsStringAsync().Result);
            }
            catch (Exception ex) //when (ex is HttpRequestException || ex is JsonException)
            {
                return new GeneralResponse<Card>(false, ex.Message);
            }
        }

        public static async Task<Card> getCard(long? id)
        {
            Card card = await get<Card>($"api/card/{id}");
            foreach (Card.Page page in card.pages)
            {
                page.picture = await getPicture(page.id);
            }
            if (card.description == "Корректировка иллюстрации процесса, формулировок фаз, списков используемых деталей и инструментов.")
            {
                card.description = string.Empty;
            }
            return card;
        }

        public static async Task<CardMainInfo> getCard(int number, int version)
        {
            return await get<CardMainInfo>($"api/card/by?number={number}&version={version}");
        }

        public static async Task<List<Card>> getAllCards()
        {
            return await get<List<Card>>($"api/card");
        }

        public static async Task<CardList> getAllCards(CardFilter filter, int page, int size)
        {
            return await get<CardList>($"api/card/filter?{filter.getQuery()}&page={page}&size={size}");
        }

        public static async Task<List<CardWithScrewing>> getAllCardsByPart(long? partId)
        {
            return await get<List<CardWithScrewing>>($"api/card/by_part?id={partId}");
        }

        internal static async Task<List<CardMovement>> getAllCardMovements(CardMainInfo card)
        {
            return await get<List<CardMovement>>($"api/card/{card.number}/movement");
        }

        internal static async Task<List<CardDescription>> getCardDescription(CardMainInfo card)
        {
            return await get<List<CardDescription>>($"api/card/{card.number}/description");
        }

        internal static async Task<List<CardWithScrewing>> getCardsWithScrewing()
        {
            return await get<List<CardWithScrewing>>($"api/card/screwing");
        }

        public static async Task<Image> getPicture(long id)
        {
            try
            {
                HttpResponseMessage response = await sendRequest(RequestType.GET, $"api/page/picture/{id}");
                response.EnsureSuccessStatusCode();
                Stream stream = await response.Content.ReadAsStreamAsync();
                return Image.FromStream(stream);
            }
            catch (Exception ex) when (ex is HttpRequestException || ex is ArgumentException)
            {
                return null;
            }
        }

        internal static async Task<GeneralResponse<List<Card>>> putPitch(long cardId, long? pitchId)
        {
            return await update<List<Card>>($"api/card/{cardId}/pitch?value={pitchId}", null);
        }

        internal static async Task<GeneralResponse<List<Card>>> setPosition(long cardId, decimal position)
        {
            return await update<List<Card>>($"api/card/{cardId}/position?value={position}", null);
        }

        internal static async Task<GeneralResponse<object>> putInArchive(CardMainInfo card)
        {
            return await update<object>($"api/card/{card.number}/archive", null);
        }

        internal static async Task<GeneralResponse<object>> deleteCard(CardMainInfo card)
        {
            return await delete<object>($"api/card/{card.id}");            
        }        

        #endregion

        #region Инструменты

        public static async Task<List<Tool>> getToolList()
        {
            return await get<List<Tool>>($"api/tool");
        }

        public static async Task<GeneralResponse<Tool>> createTool(Tool tool)
        {
            return await create<Tool>($"api/tool", tool);
        }

        public static async Task<GeneralResponse<object>> updateTool(Tool tool)
        {
            return await update<object>($"api/tool/{tool.id}", tool);
        }

        #endregion

        #region Детали

        public static async Task<List<Part>> getPartList()
        {
            return await get<List<Part>>($"api/part");
        }

        public static async Task<List<Part>> getPartsFromCards()
        {
            return await get<List<Part>>($"api/card/part");
        }

        public static async Task<GeneralResponse<Part>> createPart(Part part)
        {
            return await create<Part>($"api/part", part);
        }

        public static async Task<GeneralResponse<object>> updatePart(Part part)
        {
            return await update<object>($"api/part/{part.id}", part);
        }

        public static async Task<List<Card.Consumption>> getConsumptionList()
        {
            return await get<List<Card.Consumption>>($"api/card/consumption");
        }

        public static async Task<List<ConsumptionResponse>> getDetailedConsumptionList()
        {
            return await get<List<ConsumptionResponse>>($"api/part/consumption");
        }

        #endregion

        #region Посты

        public static async Task<List<Pitch>> getPitchList()
        {
            return await get<List<Pitch>>($"api/pitch");
        }

        public static async Task<GeneralResponse<Pitch>> createPitch(Pitch pitch)
        {
            return await create<Pitch>($"api/pitch", pitch);
        }

        public static async Task<GeneralResponse<Pitch>> updatePitch(Pitch pitch)
        {
            return await update<Pitch>($"api/pitch/{pitch.id}", pitch);
        }

        #endregion

        #region Завинчивание

        public static async Task<List<ScrewingToolType>> getScrewingToolTypeList()
        {
            return await get<List<ScrewingToolType>>($"api/screwing/tool/type");
        }

        public static async Task<List<ScrewingTool>> getScrewingToolList()
        {
            return await get<List<ScrewingTool>>($"api/screwing/tool");
        }

        internal static async Task<GeneralResponse<ScrewingToolType>> createScrewingToolType(ScrewingToolType newToolType)
        {
            return await create<ScrewingToolType>($"api/screwing/tool/type", newToolType);
        }

        internal static async Task<GeneralResponse<ScrewingTool>> createScrewingTool(ScrewingTool newTool)
        {
            return await create<ScrewingTool>($"api/screwing/tool", newTool);
        }

        public static async Task<GeneralResponse<ScrewingToolType>> updateScrewingToolType(ScrewingToolType toolType)
        {
            return await update<ScrewingToolType>($"api/screwing/tool/type/{toolType.id}", toolType);
        }

        public static async Task<GeneralResponse<ScrewingTool>> updateScrewingTool(ScrewingTool tool)
        {
            return await update<ScrewingTool>($"api/screwing/tool/{tool.id}", tool);
        }

        internal static async Task<GeneralResponse<Campaign>> createCampaign(Campaign campaign)
        {
            return await create<Campaign>($"api/screwing/campaign", campaign);
        }

        public static async Task<List<Campaign>> getCampaignList()
        {
            return await get<List<Campaign>>($"api/screwing/campaign");
        }

        public static async Task<Campaign> getCampaign(long id)
        {
            return await get<Campaign>($"api/screwing/campaign/{id}");
        }

        public static async Task<GeneralResponse<Campaign>> setToolCheckResults(Campaign campaign, List<ToolCheck> toolChecks)
        {
            return await update<Campaign>($"api/screwing/campaign/{campaign.id}/toolCheck", toolChecks);
        }

        public static async Task<List<ToolCheck>> getToolCheckResults(ScrewingTool tool)
        {
            return await get<List<ToolCheck>>($"api/screwing/tool/{tool.id}/check");
        }

        public static async Task<List<ToolCheck>> getToolCheckResults(Campaign campaign)
        {
            return await get<List<ToolCheck>>($"api/screwing/campaign/{campaign.id}/check");
        }

        public static async Task<GeneralResponse<Campaign>> getOpenCampaign(int blm)
        {
            return await get<GeneralResponse<Campaign>>($"api/screwing/campaign/started/{blm}");
        }

        public static async Task<List<ScrewingToolMovement>> getToolMovements(ScrewingTool tool)
        {
            return await get<List<ScrewingToolMovement>>($"api/screwing/tool/{tool.id}/movement");
        }

        public static async Task<GeneralResponse<object>> deleteCampaign(Campaign campaign)
        {
            return await delete<object>($"api/screwing/campaign/{campaign.id}");
        }

        #endregion

        #region Датчики BLM

        public static async Task<List<Sensor>> getSensorList()
        {
            return await get<List<Sensor>>($"api/sensor");
        }

        public static async Task<GeneralResponse<Sensor>> createSensor(Sensor sensor)
        {
            return await create<Sensor>($"api/sensor", sensor);
        }

        public static async Task<GeneralResponse<object>> updateSensor(Sensor sensor)
        {
            return await update<object>($"api/sensor", sensor);
        }

        public static async Task<GeneralResponse<object>> deleteSensor(Sensor sensor)
        {
            return await delete<object>($"api/sensor/{sensor.blm}_{sensor.number}");
        }

        #endregion

        #region Общие        

        public static async Task<List<StringConst>> getStringConstList(string name)
        {
            return await get<List<StringConst>>($"api/string-const/object?name={name}");
        }

        public static async Task<string[]> getConstants(string name)
        {
            return (await getStringConstList(name)).OrderBy(c => c.id).Select(c => c.value).ToArray();
        }        

        #endregion

    }
}
