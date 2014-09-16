using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer Player;
        public Form1()
        {
            InitializeComponent();
            Player = new WMPLib.WindowsMediaPlayer();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            //Player.controls.previous();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Player.controls.play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (Player.playState == WMPPlayState.wmppsPaused)
            {
                Player.controls.play();
            }
            else
            {
                Player.controls.pause();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Player.controls.stop();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Player.controls.next();
        }
    }
}
