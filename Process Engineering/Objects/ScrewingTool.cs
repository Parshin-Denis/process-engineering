using Process_Engineering.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Process_Engineering
{
    internal class ScrewingTool
    {
        public static List<ScrewingTool> screwingTools = new List<ScrewingTool>();
        public static List<StringConst> statuses = new List<StringConst>();

        public long id { get; set; }
        [JsonIgnore] public string type { get; set; }
        [JsonIgnore] public string model { get; set; }
        public string serialNumber { get; set; }
        [JsonIgnore] public string status { get; set; } = string.Empty;

        private string card_Number = string.Empty;
        public string cardNumber
        {
            get { return card_Number; }
            set
            {
                if (cardId != null)
                {
                    return;
                }
                card_Number = value ?? string.Empty;
            }
        }
        [JsonIgnore] public string pitch { get; set; }
        public float torque { get; set; }
        public float? brakeTime { get; set; }

        private long? toolType_Id;
        public long? toolTypeId
        {
            get { return toolType_Id; }
            set
            {
                toolType_Id = value;
                toolType = ScrewingToolType.types.Find(t => t.id == toolType_Id);
                type = toolType?.type;
                model = toolType?.ToString();
            }
        }

        private long? pitch_Id;
        public long? pitchId
        {
            get { return pitch_Id; }
            set
            {
                pitch_Id = value;
                pitch = pitch_Id == null ? string.Empty : Pitch.pitches.FirstOrDefault(p => p.id == pitch_Id)?.number;
            }
        }
        
        public long? cardId { get; set; }        

        private long? status_Id;
        public long? statusId
        {
            get { return status_Id; }
            set
            {
                status_Id = value;
                status = statuses.Find(s => s.id == status_Id)?.value;
            }
        }

        private string card_Name;
        public string cardName
        {
            get { return card_Name; }
            set
            {
                if (cardId != null && value == null)
                {
                    return;
                }
                card_Name = value;
            }
        }

        private CardWithScrewing cardInfo;
        public CardWithScrewing card
        {
            get { return cardInfo; }
            set
            {
                if (cardInfo == null && value == null)
                {
                    return;
                }
                cardInfo = value;
                cardId = cardInfo?.id;
                card_Number = cardInfo?.GetDesignation() ?? string.Empty;
                cardName = cardInfo?.name;
            }
        }

        private ScrewingToolType toolType;


        public void CopyFrom(ScrewingTool tool)
        {
            id = tool.id;
            type = tool.type;
            model = tool.model;
            serialNumber = tool.serialNumber;
            cardNumber = tool.cardNumber;
            pitch = tool.pitch;
            status = tool.status;
            torque = tool.torque;
            brakeTime = tool.brakeTime;
            toolTypeId = tool.toolTypeId;
            pitchId = tool.pitchId;
            card = tool.card;
            statusId = tool.statusId;
            card_Number = tool.cardNumber;
            card_Name = tool.cardName;
        }

        public void ReplaceWith(ScrewingTool tool)
        {
            tool.cardNumber = cardNumber;
            tool.cardName = cardName;
            tool.pitch = pitch;
            tool.torque = torque;
            tool.pitchId = pitchId;
            tool.card = card;
            tool.statusId = 1;
        }        

        public ScrewingToolType GetToolType()
        {
            return toolType;
        }

        public override string ToString()
        {
            return $"№{id:0000} {model}";
        }

        public bool IsTorqueAchivable() => torque == 0 || torque >= toolType?.minTorque && torque <= toolType?.maxTorque;
        public bool EqualCardTorque() => card?.screwing == null || card?.screwing.torque == torque;
        public bool IsTorqueCorrect() => EqualCardTorque() && IsTorqueAchivable();        

        public bool IsCardActual() => cardId == null || card.isActual;
        public bool IsCardWithScrewing() => cardId == null || card.screwing != null;
        public bool IsCardCorrect() => IsCardActual() && IsCardWithScrewing();       

        public bool IsPitchCorrect() => cardId == null || pitchId == card.pitchId;

        public bool HasAnomaly() => !(IsTorqueCorrect() && IsCardCorrect() && IsPitchCorrect());

        public override bool Equals(object obj)
        {
            if (obj is ScrewingTool tool)
                return id == tool.id
                    && serialNumber.Equals(tool.serialNumber)
                    && torque == tool.torque
                    && toolTypeId == tool.toolTypeId
                    && pitchId == tool.pitchId
                    && cardId == tool.cardId
                    && statusId == tool.statusId
                    && cardName == tool.cardName
                    && cardNumber == tool.cardNumber;
            return false;
        }

        public override int GetHashCode() => base.GetHashCode();

    }

}
