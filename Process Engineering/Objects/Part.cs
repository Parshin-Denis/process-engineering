using System.Collections.Generic;

namespace Process_Engineering
{
    internal class Part
    {
        public static List<Part> parts = new List<Part>();

        public long? id { get; set; }
        public string number { get; set; }
        public string name { get; set; }
        public string unit { get; set; }

        public override string ToString()
        {
            return $" {number} {name}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Part part)
                return id == part.id
                    && number == part.number;
            return false;
        }

        public override int GetHashCode() => id.GetHashCode();

        public void CopyFrom(Part part)
        {
            id = part.id;
            number = part.number;
            name = part.name;
            unit = part.unit;
        }

        public bool Contains(string text)
        {
            string textToFind = text.ToLower();
            return number.ToLower().Contains(textToFind) ? true : name.ToLower().Contains(textToFind);
        }
    }
}
