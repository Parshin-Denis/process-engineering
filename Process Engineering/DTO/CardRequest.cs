using System;
using System.Collections.Generic;

namespace Process_Engineering
{
    internal class CardRequest
    {

        internal class ConsumptionRequest
        {
            public long? partId { get; set; }
            public float quantity { get; set; }
            public string mark { get; set; }
        }

        internal class PageRequest
        {
            public List<ConsumptionRequest> consumptions { get; set; } = new List<ConsumptionRequest>();
            public List<Card.Phase> phases { get; set; } = new List<Card.Phase>();
            public List<long> tools { get; set; } = new List<long>();
            public Card.Screwing screwing { get; set; }
        }

        public string cardType { get; set; }

        public string project { get; set; }

        public string name { get; set; }

        public string code { get; set; }

        public string character { get; set; }

        public string controlPlan { get; set; }

        public string description { get; set; }

        public List<PageRequest> pages { get; set; } = new List<PageRequest>();

        public static CardRequest fromCard(Card card)
        {
            CardRequest request = new CardRequest();
            request.cardType = card.cardType;
            request.project = card.project;
            request.name = card.name;
            request.code = card.code;
            request.character = card.character;
            request.controlPlan = card.controlPlan;
            request.description = card.description;
            foreach (Card.Page page in card.pages)
            {
                PageRequest pageRequest = new PageRequest();
                foreach (Card.Consumption consumption in page.consumptions)
                {
                    ConsumptionRequest consumptionRequest = new ConsumptionRequest();
                    consumptionRequest.mark = consumption.mark;
                    consumptionRequest.quantity = consumption.quantity;
                    consumptionRequest.partId = consumption.partId;
                    pageRequest.consumptions.Add(consumptionRequest);
                }
                pageRequest.phases = page.phases;
                foreach (Tool tool in page.tools)
                {
                    pageRequest.tools.Add(Convert.ToInt64(tool.id));
                }
                pageRequest.screwing = page.screwing;
                request.pages.Add(pageRequest);
            }
            return request;
        }

    }
}
