using Process_Engineering.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using unoidl.com.sun.star.task;

namespace Process_Engineering
{
    internal class CardFilter
    {
        public bool isActual { get; set; } = true;

        public string cardType { get; set; }

        public string project { get; set; }

        public int? number { get; set; }

        public string name { get; set; }

        public string code { get; set; }

        public string character { get; set; }        

        public long? pitchId { get; set; }

        public long? userId { get; set; }        

        public long? partId { get; set; }        

        
        public string getQuery()
        {
            List<string> requestParams = new List<string>();
            foreach(var field in typeof(CardFilter).GetProperties())
            {
                if(field.GetValue(this) == default) { continue; }
                requestParams.Add($"{field.Name}={field.GetValue(this)}");
            }
            return string.Join("&", requestParams.ToArray());
        }
    }
}
