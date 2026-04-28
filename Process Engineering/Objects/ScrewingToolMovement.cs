using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Process_Engineering
{
    internal class ScrewingToolMovement
    {
        public static List<ScrewingToolMovement> screwingToolMovements = new List<ScrewingToolMovement>();

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

        public string status { get; set; }
        
        public string card { get; set; }

        public string pitch { get; set; }

        public float torque { get; set; }
        
        public string creator { get; set; }

    }

}
