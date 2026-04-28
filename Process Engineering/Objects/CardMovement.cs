using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process_Engineering.Objects
{
    internal class CardMovement
    {
        public static List<CardMovement> cardMovements = new List<CardMovement>();

        private DateTime? EventTime;
        public DateTime? eventTime
        {
            get
            {
                return EventTime;
            }
            set
            {
                EventTime = value.HasValue ? value?.ToLocalTime() : null;
            }
        }

        public string pitch { get; set; }

        public string creator { get; set; }
    }
}
