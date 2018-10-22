using System.Collections.Generic;

namespace Task0
{
    public abstract class MediaPlayerBase : IMediaPlayer
    {
        protected IList<PlayList> playLists;

        public bool AddPlayList(PlayList playList) { return true; }

        public abstract bool GoNext();
        public abstract bool GoNextPlayList();
        public abstract bool GoPrevious();
        public abstract bool GoPreviousPlayList();

        public bool RemovePlayList(PlayList playList) { return true; }

        public abstract bool Start();
        public abstract bool StartAgain();
        public abstract bool Stop();
    }
}
