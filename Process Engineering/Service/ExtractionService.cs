using Process_Engineering.DTO;
using Process_Engineering.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Process_Engineering.Service
{
    internal class ExtractionService
    {
        public static void show(Card card)
        {
            try
            {
                IXlsService xlsService = getXlsService();
                getWorkBook(card, xlsService, true);
            }
            catch
            {
                MessageBox.Show(ConstStorage.OPEN_ERROR, "Открытие гаммы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void show(List<ConsumptionResponse> consumptionList)
        {
            try
            {
                IXlsService xlsService = getXlsService();
                xlsService.open(string.Empty, true);                
                xlsService.setTextFormat(1, "A:A");

                int RowNumber = 1;
                xlsService.setTextValue(1, $"A{RowNumber}", "Номер детали");
                xlsService.setTextValue(1, $"B{RowNumber}", "Название детали");
                xlsService.setTextValue(1, $"C{RowNumber}", "Номер гаммы");
                xlsService.setTextValue(1, $"D{RowNumber}", "Пост");
                xlsService.setTextValue(1, $"E{RowNumber}", "Количество");
                xlsService.setTextValue(1, $"F{RowNumber++}", "Ед. изм.");
                foreach (ConsumptionResponse consumption in consumptionList)
                {
                    xlsService.setTextValue(1, $"A{RowNumber}", consumption.partNumber);
                    xlsService.setTextValue(1, $"B{RowNumber}", consumption.partName);
                    xlsService.setTextValue(1, $"C{RowNumber}", consumption.cardTitle);
                    xlsService.setTextValue(1, $"D{RowNumber}", consumption.pitchNumber);
                    xlsService.setTextValue(1, $"E{RowNumber}", consumption.quantity.ToString());
                    xlsService.setTextValue(1, $"F{RowNumber++}", consumption.unit);
                }
                if (xlsService is ExcelService excelService)
                {
                    excelService.autoFit(1);
                }
            }
            catch
            {
                MessageBox.Show(ConstStorage.OPEN_ERROR, "Выгрузка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void show(Pitch pitch, List<CardShortInfo> cards)
        {
            try
            {
                IXlsService xlsService = getXlsService();
                FileStream excelFile = File.OpenWrite(Path.GetTempFileName());
                excelFile.Write(Resources.ChronoTemplate, 0, Resources.ChronoTemplate.Length);
                excelFile.Close();
                xlsService.open(excelFile.Name, true);
                int rowNumber = 15;
                xlsService.setTextValue(1, "A2", pitch.number);
                foreach (CardShortInfo card in cards)
                {
                    if (rowNumber > 60)
                    {
                        xlsService.copyRow(1, rowNumber - 1);
                    }
                    xlsService.setTextValue(1, $"B{rowNumber}", card.GetDesignation());
                    xlsService.setTextValue(1, $"C{rowNumber}", card.character == "-" ? "" : card.character);
                    xlsService.setTextValue(1, $"D{rowNumber++}", card.name);
                }
            }
            catch
            {
                MessageBox.Show(ConstStorage.OPEN_ERROR, "Хронология", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void getWorkBook(Card card, IXlsService xlsService, bool visible)
        {
            byte[] cardTemplate = Resources.CardTemplate;
            FileStream excelFile = File.OpenWrite(Path.GetTempFileName());
            excelFile.Write(cardTemplate, 0, cardTemplate.Length);
            excelFile.Close();
            xlsService.open(excelFile.Name, visible);

            for (int i = 1; i < card.pages.Count; i++)
            {
                xlsService.copySheet(i);
            }
            for (int i = 0; i < card.pages.Count; i++)
            {
                setMainParameters(xlsService, i + 1, card);
                setAdditionalParameters(xlsService, i + 1, card.pages[i]);
                xlsService.setTextValue(i + 1, "AD3", $"{i + 1}/{card.pages.Count}");
                if (card.pages[i].picture != null)
                {
                    xlsService.setPicture(i + 1, card.pages[i].picture, "B9", "S56", true);
                }
                if (card.character != null && !card.character.Equals("-"))
                {
                    xlsService.setPicture(i + 1, (Image)Resources.ResourceManager.GetObject(card.character), "L5", "M5", false);
                }
            }
        }

        private static void setMainParameters(IXlsService xlsService, int sheetNumber, Card card)
        {
            xlsService.setTextValue(sheetNumber, "B5", card.code);
            xlsService.setTextValue(sheetNumber, "C3", card.cardType);
            xlsService.setTextValue(sheetNumber, "E3", card.project);
            xlsService.setTextValue(sheetNumber, "H3", card.name);
            xlsService.setTextValue(sheetNumber, "G3", card.version.ToString());
            xlsService.setTextValue(sheetNumber, "F3", card.number.ToString("000000"));
            xlsService.setTextValue(sheetNumber, "U56", card.creationTime.ToString("d"));
            xlsService.setTextValue(sheetNumber, "Q5", card.creationTime.ToString("d"));
            xlsService.setTextValue(sheetNumber, "N5", card.controlPlan);
        }

        private static void setAdditionalParameters(IXlsService xlsService, int sheetNumber, Card.Page page)
        {
            for (int k = 0; k < page.consumptions.Count; k++)
            {
                xlsService.setTextValue(sheetNumber, $"B{k + 60}", page.consumptions[k].partNumber);
                xlsService.setTextValue(sheetNumber, $"E{k + 60}", page.consumptions[k].partName);
                xlsService.setTextValue(sheetNumber, $"M{k + 60}", page.consumptions[k].quantity.ToString());
                xlsService.setTextValue(sheetNumber, $"N{k + 60}", page.consumptions[k].unit);
                xlsService.setTextValue(sheetNumber, $"O{k + 60}", page.consumptions[k].mark);
            }
            for (int k = 0; k < page.phases.Count; k++)
            {
                xlsService.setTextValue(sheetNumber, $"U{k * 5 + 8}", page.phases[k].number.ToString());
                xlsService.setTextValue(sheetNumber, $"V{k * 5 + 8}", page.phases[k].description);
                if (page.phases[k].number == 0)
                {
                    xlsService.setPicture(sheetNumber, Resources.Key, $"U{k * 5 + 8}", $"U{k * 5 + 12}", false);
                }
            }
            for (int k = 0; k < page.tools.Count; k++)
            {
                xlsService.setTextValue(sheetNumber, $"P{k + 60}", page.tools[k].number);
                xlsService.setTextValue(sheetNumber, $"R{k + 60}", page.tools[k].name);
            }
            if (page.screwing != null)
            {
                xlsService.setTextValue(sheetNumber, "AA60", $"{page.screwing.torque} \u00B1 {page.screwing.torqueTolerance}");
                if (page.screwing.angle != 0)
                {
                    xlsService.setTextValue(sheetNumber, "AC60", $"{page.screwing.angle} \u00b1 {page.screwing.angleTolerance}");
                }
            }
        }

        public static void printCard(List<Card> cards, string printer, ProgressBar progressBar)
        {
            try
            {
                IXlsService xlsService = getXlsService();
                progressBar.Minimum = 0;
                progressBar.Maximum = cards.Count;
                for (int i = 0; i < cards.Count; i++)
                {
                    progressBar.Value = i + 1;
                    progressBar.Refresh();
                    getWorkBook(cards[i], xlsService, false);
                    xlsService.print(printer);
                    xlsService.close();
                    Thread.Sleep(500);
                }
                xlsService.closeApp();
            }
            catch
            {
                MessageBox.Show(ConstStorage.OPEN_ERROR, ConstStorage.CARDS_PRINTING, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void extractCard(List<Card> cards, ProgressBar progressBar)
        {
            try
            {
                IXlsService xlsService = getXlsService();
                progressBar.Minimum = 0;
                progressBar.Maximum = cards.Count;
                for (int i = 0; i < cards.Count; i++)
                {
                    progressBar.Value = i + 1;
                    progressBar.Refresh();
                    string pitchNumber = Pitch.pitches.Find(p => p.id == cards[i].pitchId)?.number;
                    DirectoryInfo directory = new DirectoryInfo($"Стандарты\\M6\\{pitchNumber}");
                    if (!directory.Exists)
                    {
                        directory.Create();
                    }
                    string cardNumber = cards[i].GetDesignation().Replace("*", "_");
                    if (File.Exists($"{directory.FullName}\\{cards[i].position:00} {cardNumber}.xls"))
                    {
                        continue;
                    }
                    getWorkBook(cards[i], xlsService, false);
                    xlsService.save($"{directory.FullName}\\{cards[i].position:00} {cardNumber}.xls");
                    xlsService.close();
                }
                xlsService.closeApp();
            }
            catch
            {
                MessageBox.Show(ConstStorage.OPEN_ERROR, ConstStorage.CARDS_PRINTING, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void printToolLabel(List<ScrewingTool> tools, System.Drawing.Printing.PrinterSettings printerSettings, ProgressBar progressBar)
        {
            try
            {
                IXlsService xlsService = getXlsService();
                progressBar.Minimum = 0;
                progressBar.Maximum = tools.Count;
                FileStream excelFile = File.OpenWrite(Path.GetTempFileName());
                excelFile.Write(Resources.ToolLabelTemplate, 0, Resources.ToolLabelTemplate.Length);
                excelFile.Close();
                xlsService.open(excelFile.Name, false);
                foreach (ScrewingTool tool in tools)
                {
                    progressBar.Value = tools.IndexOf(tool) + 1;
                    progressBar.Refresh();
                    ScrewingToolType type = tool.GetToolType();
                    xlsService.setTextValue(1, "A1", type?.model);
                    xlsService.setTextValue(1, "B1", tool.id.ToString());
                    xlsService.setTextValue(1, "A2", !tool.cardNumber.Equals(string.Empty) ? $"Гамма: {tool.cardNumber}" : string.Empty);
                    xlsService.setTextValue(1, "B2", tool.serialNumber);
                    xlsService.setTextValue(1, "A3", getPitchNumber(tool));
                    xlsService.setTextValue(1, "B3", DateTime.Now.ToString("d"));
                    xlsService.setTextValue(1, "A4", $"{tool.torque} Нм  {type?.tolerance} %");
                    xlsService.setTextValue(1, "A5", tool.cardName);
                    for (int i = 1; i < printerSettings.Copies && i < 10; i++)
                    {
                        xlsService.copyRange(1, "A1:B5", $"A{i * 5 + 1}");
                    }
                    xlsService.print(printerSettings.PrinterName);
                    Thread.Sleep(500);
                }
                xlsService.close();
                xlsService.closeApp();
            }
            catch (Exception)
            {
                MessageBox.Show(ConstStorage.OPEN_ERROR, ConstStorage.LABELS_PRINTING, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string getPitchNumber(ScrewingTool tool)
        {
            if (tool.pitchId == null) return string.Empty;
            string pitchNumber = tool.pitch.Contains("/") ? tool.pitch.Split('/')[1] : tool.pitch;
            return $"Пост: {pitchNumber}";
        }

        internal static void getCampaignResult(Campaign campaign)
        {
            try
            {
                IXlsService xlsService = getXlsService();
                FileStream excelFile = File.OpenWrite(Path.GetTempFileName());
                excelFile.Write(Resources.CampaignResultTemplate, 0, Resources.CampaignResultTemplate.Length);
                excelFile.Close();
                xlsService.open(excelFile.Name, true);

                xlsService.setTextValue(1, "C2", $"BLM {campaign.blm}");
                xlsService.setTextValue(1, "C3", $"{campaign.number}");
                xlsService.setTextValue(1, "C4", campaign.sector);
                xlsService.setTextValue(1, "C5", campaign.techType);
                xlsService.setTextValue(1, "C6", $"{campaign.totalToolsCount}");
                xlsService.setTextValue(1, "C7", $"{campaign.toolsCheckedOKCount}");
                xlsService.setTextValue(1, "C8", $"{campaign.toolsCheckedNOKCount}");
                xlsService.setTextValue(1, "C9", $"{campaign.toolsNotCheckedCount}");
                xlsService.setTextValue(1, "C10", campaign.startDate.ToString("f"));
                xlsService.setTextValue(1, "C11", campaign.finishDate?.ToString("f"));
                xlsService.setTextValue(1, "C12", campaign.checker);
                xlsService.setTextValue(1, "C13", campaign.totalToolsCount == campaign.toolsCheckedOKCount ? "OK" : "NOK");

                xlsService.setTextValue(1, "C14", $"{campaign.toolsCheckedNOKCount} шт.");
                xlsService.setTextValue(1, "A15", string.Join(";  ", campaign.toolsNok.Select(t => t.ToString())));
                xlsService.setTextValue(1, "C27", $"{campaign.toolsNotCheckedCount} шт.");
                xlsService.setTextValue(1, "A28", string.Join(";  ", campaign.toolsNotChecked.Select(t => t.ToString())));
            }
            catch (Exception e)
            {
                MessageBox.Show(ConstStorage.OPEN_ERROR + " " + e.Message, "Результаты кампании", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal static IXlsService getXlsService()
        {
            try
            {
                Type officeType = Type.GetTypeFromProgID("Excel.Application");
                if (officeType == null)
                {
                    return new LibreService();
                }
                else
                {                    
                    return new ExcelService();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(ConstStorage.APP_NOT_FOUND, ConstStorage.EXTRACTION_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
