namespace Process_Engineering.DTO
{
    internal class CardBase
    {
        public long? id { get; set; }

        public string cardType { get; set; }

        public string project { get; set; }

        public int number { get; set; }

        public string name { get; set; }

        public int version { get; set; }

        public string GetDesignation()
        {
            return number == 0 ? ConstStorage.CARD_IS_NOT_SET : $"{cardType}*{project}{number:000000}";
        }

        public override string ToString()
        {
            return GetDesignation() + "-" + version + " " + name;
        }

        public override bool Equals(object obj)
        {
            if (obj is CardBase card)
                return number == card.number &&
                    version == card.version &&
                    cardType == card.cardType &&
                    project == card.project &&
                    name == card.name;
            return false;
        }

        public override int GetHashCode() => id.GetHashCode();
    }
}
