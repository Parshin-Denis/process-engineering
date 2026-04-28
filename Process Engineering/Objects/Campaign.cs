using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Process_Engineering
{
    internal class Campaign
    {
        public static List<Campaign> campaigns = new List<Campaign>();
        public long? id { get; set; }
        public int number { get; set; }
        public DateTime startDate { get; set; }
        public DateTime? finishDate { get; set; }
        public int blm { get; set; }
        public string sector { get; set; }
        public int toolType { get; set; }
        [JsonIgnore] public string techType { get; set; }

        public int? totalToolsCount { get; set; }

        public int? toolsCheckedOKCount { get; set; }

        public int? toolsCheckedNOKCount { get; set; }

        public int? toolsNotCheckedCount { get; set; }

        public List<ScrewingTool> tools { get; set; }

        public List<long> toolsNok { get; set; }

        public List<long> toolsNotChecked { get; set; }

        public string checker { get; set; }

        public void copyFrom(Campaign campaign)
        {
            id = campaign.id;
            number = campaign.number;
            blm = campaign.blm;
            sector = campaign.sector;
            toolType = campaign.toolType;
            techType = campaign.techType;
            startDate = campaign.startDate;
            finishDate = campaign.finishDate;
            totalToolsCount = campaign.totalToolsCount;
            toolsCheckedOKCount = campaign.toolsCheckedOKCount;
            toolsCheckedNOKCount = campaign.toolsCheckedNOKCount;
            toolsNotCheckedCount = campaign.toolsNotCheckedCount;
            checker = campaign.checker;
        }

        public void setDetails()
        {
            startDate = startDate.ToLocalTime();
            finishDate = finishDate?.ToLocalTime();
            techType = toolType > 2 ? ConstStorage.SCREWING_TOOL_TYPES[toolType - 3] : "Все типы";
        }

        public override string ToString()
        {
            return $"BLM: {blm}     Номер: {number}    Сектор: {sector}    Тип инструмента: {techType}     Количество инструментов: {totalToolsCount} шт.";
        }
    }
}
