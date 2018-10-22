using System.Collections.Generic;

namespace Task0
{
    public class ImageEditor
    {
        private IList<Effect> effects;

        public void Rotate(int angle) { }
        public bool AddEffect(Effect effect) { return true; }
        public void Resize(int newWidth, int newHeight) { }
        public bool SaveChanges() { return true; }
    }
}
