using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Process_Engineering
{
    internal class Sensor
    {
        public static List<Sensor> sensors = new List<Sensor>();

        public int blm { get; set; }
        public int number { get; set; }
        public float minTorque { get; set; }        
        public float maxTorque { get; set; }

        public override string ToString()
        {
            return $" {blm} {number}";
        }

        public void copyFrom(Sensor sensor)
        {
            blm = sensor.blm;
            number = sensor.number;
            minTorque = sensor.minTorque;
            maxTorque = sensor.maxTorque;
        }

        public override bool Equals(object obj)
        {
            if (obj is Sensor sensor)
                return blm == sensor.blm
                    && number == sensor.number
                    && minTorque == sensor.minTorque
                    && maxTorque == sensor.maxTorque;
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
