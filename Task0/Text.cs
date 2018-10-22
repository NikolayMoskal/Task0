using System;
using System.Drawing;

namespace Task0
{
    public class Text : Effect
    {
        public Font Font { get; set; }
        public int RotateAngle { get; set; }
        public int Alignment { get; set; }
        public Point Coordinate { get; set; }

        public override void ApplyEffect()
        {
            throw new NotImplementedException();
        }
    }
}
