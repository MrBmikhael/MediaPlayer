using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace MediaPlayer
{
    public class PlayerWrapper
    {
        public WMPLib.WindowsMediaPlayer Player;
        private static PlayerWrapper instance = null;

        private PlayerWrapper()
        {
            Player = new WindowsMediaPlayer();
            Player.settings.volume = 50;
        }

        public static PlayerWrapper getInstance()
        {
            if (instance == null)
                instance = new PlayerWrapper();
            return instance;
        }
    }
}
