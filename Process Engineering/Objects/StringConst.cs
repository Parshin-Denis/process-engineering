namespace Process_Engineering
{
    internal class StringConst
    {
        public long? id { get; set; }
        public string value { get; set; } = "-не задан-";

        public override string ToString()
        {
            return value;
        }
    }
}
