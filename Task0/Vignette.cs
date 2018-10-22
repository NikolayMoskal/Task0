using System;

namespace Task0
{
    public class Vignette : Effect
    {
        public int Vertical { get; set; }
        public int Horizontal { get; set; }
        public int CleanZone { get; set; }
        public int Tension { get; set; }

        public override void ApplyEffect()
        {
            throw new NotImplementedException();
        }
    }
}
