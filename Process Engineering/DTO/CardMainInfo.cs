using System;
using static Process_Engineering.Card;

namespace Process_Engineering.DTO
{
    internal class CardMainInfo : CardBase
    {

        public string code { get; set; }

        public string character { get; set; }

        public string controlPlan { get; set; }

        public User creator { get; set; }

        public DateTime creationTime { get; set; }

        public DateTime updateTime { get; set; }

        public Screwing screwing { set; get; }

        public string screwingTool { get; set; }

        public long? pitchId { get; set; }

        public int? position { get; set; }

    }
}
