using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process_Engineering.Objects
{
    internal class CardDescription
    {
        public static List<CardDescription> cardDescriptions = new List<CardDescription>();

        public int version { get; set; }

        private DateTime? CreationTime;
        public DateTime? creationTime
        {
            get
            {
                return CreationTime;
            }
            set
            {
                CreationTime = value.HasValue ? value?.ToLocalTime() : null;
            }
        }

        public string description { get; set; }

        public string creatorName { get; set; }
    }
}
