namespace Task0
{
    interface IMediaPlayer
    {
        bool Start();
        bool Stop();
        bool StartAgain();
        bool GoNext();
        bool GoPrevious();
        bool GoNextPlayList();
        bool GoPreviousPlayList();
    }
}
