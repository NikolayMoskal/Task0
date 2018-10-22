using System;

namespace Task0
{
    public class ImageViewer : Viewable
    {
        public ImageEditor ImageEditor { get; private set; }

        public ImageViewer(ImageEditor imageEditor)
        {
            ImageEditor = imageEditor;
        }

        public void MoveImage(int up, int left) { }

        public void Magnifier() { }

        public void Navigate() { }

        public override bool GoNext()
        {
            throw new NotImplementedException();
        }

        public override bool GoNextPlayList()
        {
            throw new NotImplementedException();
        }

        public override bool GoPrevious()
        {
            throw new NotImplementedException();
        }

        public override bool GoPreviousPlayList()
        {
            throw new NotImplementedException();
        }

        public override void Scale(double times)
        {
            throw new NotImplementedException();
        }

        public override bool Start()
        {
            throw new NotImplementedException();
        }

        public override bool StartAgain()
        {
            throw new NotImplementedException();
        }

        public override bool Stop()
        {
            throw new NotImplementedException();
        }

        public override void ToFullScreen()
        {
            throw new NotImplementedException();
        }
    }
}
