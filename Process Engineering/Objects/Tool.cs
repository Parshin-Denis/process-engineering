using System.Collections.Generic;

namespace Process_Engineering
{
    internal class Tool
    {
        public static List<Tool> tools = new List<Tool>();

        public long? id { get; set; }
        public string number { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return $" {number} {name}";
        }

        public void copyFrom(Tool tool)
        {
            id = tool.id;
            number = tool.number;
            name = tool.name;
        }

        public bool Contains(string text)
        {
            string textToFind = text.ToLower();
            return number.ToLower().Contains(textToFind) ? true : name.ToLower().Contains(textToFind);
        }
    }
}
