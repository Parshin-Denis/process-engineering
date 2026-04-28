using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Process_Engineering
{
    internal class ScrewingToolType
    {
        public static List<ScrewingToolType> types = new List<ScrewingToolType>();

        private long? Id;
        public long? id
        {
            get { return Id; }
            set
            {
                Id = value;
                number = Tool.tools.FirstOrDefault(t => t.id == Id)?.number;
            }
        }
        [JsonIgnore] public string number { get; set; } = string.Empty;
        [JsonIgnore] public string type { get; set; } = string.Empty;

        private int tech_Type;
        public int techType
        {
            get { return tech_Type; }
            set
            {
                tech_Type = value;
                type = value > 2 ? ConstStorage.SCREWING_TOOL_TYPES[value - 3] : string.Empty;
            }
        }
        public string brand { get; set; }
        public string model { get; set; }
        public float minTorque { get; set; }
        public float maxTorque { get; set; }
        public int tolerance { get; set; }

        public override string ToString()
        {
            return $" {brand} {model}";
        }

        public void copyFrom(ScrewingToolType toolType)
        {
            id = toolType.id;
            number = toolType.number;
            type = toolType.type;
            techType = toolType.techType;
            brand = toolType.brand;
            model = toolType.model;
            minTorque = toolType.minTorque;
            maxTorque = toolType.maxTorque;
            tolerance = toolType.tolerance;
        }

        public bool Contains(string text)
        {
            string textToFind = text.ToLower();
            return number.ToLower().Contains(textToFind)
                || (brand ?? string.Empty).ToLower().Contains(textToFind)
                || model.ToLower().Contains(textToFind)
                || type.ToLower().Contains(textToFind);
        }

        public override bool Equals(object obj)
        {
            if (obj is ScrewingToolType toolType)
                return id == toolType.id
                    && techType == toolType.techType
                    && brand == toolType.brand
                    && model == toolType.model
                    && minTorque == toolType.minTorque
                    && maxTorque == toolType.maxTorque
                    && tolerance == toolType.tolerance;
            return false;
        }

        public override int GetHashCode() => base.GetHashCode();
    }
}
