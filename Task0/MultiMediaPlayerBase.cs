using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0
{
    public abstract class MultiMediaPlayerBase : MediaPlayerBase
    {
        public int VolumeValue
        {
            get => VolumeValue;
            private set => VolumeValue = value < 0 ? 0 : value;
        }

        public void IncreaseVolume(int value) { }
        public void ReduceVolume(int value) { }
        public abstract bool Find(object obj);
    }
}
