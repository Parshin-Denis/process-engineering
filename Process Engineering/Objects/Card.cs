using Process_Engineering.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Process_Engineering
{
    internal class Card : CardBase
    {

        internal class Consumption
        {
            public long? partId { get; set; }
            public string partNumber { get; set; }
            public string partName { get; set; }
            public float quantity { get; set; }
            public string unit { get; set; }
            public string mark { get; set; }
        }

        internal class Phase
        {
            public int number { get; set; }
            public string description { get; set; }
        }

        internal class Screwing
        {
            public float torque { get; set; }
            public float torqueTolerance { get; set; }
            public int angle { get; set; }
            public int angleTolerance { get; set; }
        }

        internal class Page
        {
            public long id { get; set; }
            public Image picture { get; set; }
            public List<Consumption> consumptions { get; set; } = new List<Consumption>();
            public List<Phase> phases { get; set; } = new List<Phase>();
            public List<Tool> tools { get; set; } = new List<Tool>();
            public Screwing screwing { get; set; }
        }

        public string code { get; set; } = string.Empty;

        public string character { get; set; }

        public string controlPlan { get; set; }

        public string description { get; set; } = ConstStorage.CARD_CREATION;

        public long? pitchId { get; set; }

        public int? position { get; set; }

        public DateTime creationTime { get; set; }

        public DateTime updateTime { get; set; }

        public User creator { get; set; }

        public List<Page> pages { get; set; } = new List<Page>();

    }
}
