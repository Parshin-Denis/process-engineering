using System.Collections.Generic;

namespace Process_Engineering
{
    internal class Pitch
    {
        public static List<Pitch> pitches = new List<Pitch>();

        public static Pitch GetPitch(long? id)
        {
            return pitches.Find(p => id == p.id);
        }

        public long? id { get; set; }
        public string number { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;

        public Pitch() { }

        public Pitch(string number) : this()
        {
            this.number = number;
        }

        public override string ToString()
        {
            return $" {number}";
        }

        public void CopyFrom(Pitch pitch)
        {
            id = pitch.id;
            number = pitch.number;
            name = pitch.name;
        }

        public bool Contains(string text)
        {
            string textToFind = text.ToLower();
            return number.ToLower().Contains(textToFind) ? true : name.ToLower().Contains(textToFind);
        }

        public override bool Equals(object obj)
        {
            if (obj is Pitch pitch)
                return number.Equals(pitch.number);
            return false;
        }

        public override int GetHashCode() => id.GetHashCode();

    }
}
