namespace Process_Engineering.DTO
{
    internal class CardShortInfo : CardBase
    {

        public string code { get; set; }

        public string character { get; set; }

        public void copyFrom(Card card)
        {
            foreach (var field in typeof(CardShortInfo).GetProperties())
            {
                field.SetValue(this, typeof(Card).GetProperty(field.Name).GetValue(card));
            }
        }

        public static CardShortInfo getFrom(Card card)
        {
            CardShortInfo cardShort = new CardShortInfo();
            cardShort.copyFrom(card);
            return cardShort;
        }

    }
}
