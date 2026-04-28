using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Process_Engineering.DTO
{
    internal class CardList
    {
        [JsonPropertyName("cardList")]
        public List<CardShortInfo> cards { get; set; }

        public long totalCount { get; set; }
        
    }

}
