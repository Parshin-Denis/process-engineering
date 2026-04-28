using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Process_Engineering
{
    internal class ToolCheck
    {
        public static List<ToolCheck> toolChecks = new List<ToolCheck>();

        public long toolId { get; set; }
        private DateTime? CheckTime;
        public DateTime? checkTime
        {
            get
            {
                return CheckTime;
            }
            set
            {
                CheckTime = value.HasValue ? value?.ToLocalTime() : null;
            }
        }
        public float torqueNominal { get; set; }

        public float? torque1 { get; set; }

        public float? torque2 { get; set; }

        public float? torque3 { get; set; }

        public float? torqueSpread { get; set; }

        public float? torqueAverage { get; set; }

        public float? angleAverage { get; set; }

        public float? brakeTime { get; set; }

        public float? brakeAngle { get; set; }

        public int? codeResult { get; set; }

        public int? sensorNumber { get; set; }
    }
}
