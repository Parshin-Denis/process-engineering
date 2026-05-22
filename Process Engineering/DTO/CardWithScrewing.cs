using System.Collections.Generic;
using static Process_Engineering.Card;

namespace Process_Engineering.DTO
{
    internal class CardWithScrewing : CardBase
    {

        public static List<CardWithScrewing> cards;

        public Screwing screwing { set; get; }

        public long? pitchId { get; set; }        

        public bool isActual { get; set; }

    }
}
