using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process_Engineering.DTO
{
    internal class ConsumptionResponse
    {
        public string partName { get; set; }

        public string partNumber { get; set; }

        public string cardTitle { get; set; }

        public string pitchNumber { get; set; }        

        public float quantity { get; set; }        

    }
}
