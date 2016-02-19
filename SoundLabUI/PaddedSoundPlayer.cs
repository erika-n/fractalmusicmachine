using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SoundLabUI
{
    class PaddedSoundPlayer
    {
        System.Media.SoundPlayer _soundPlayer;
        string _filename;

        public PaddedSoundPlayer(string filename)
        {
            _filename = filename;
        }
        public void DoWork()
        {
            if (_soundPlayer != null)
            {
                _soundPlayer.Stop();
            }
            _soundPlayer = new System.Media.SoundPlayer(_filename);
            _soundPlayer.PlaySync();
        }

    }
}
