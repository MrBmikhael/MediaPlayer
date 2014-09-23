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
using HundredMilesSoftware.UltraID3Lib;

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
            string file = "C:\\Users\\bishoy\\Downloads\\mawaly_Amr-Dyab_129213.mp3";

            UltraID3 a = new UltraID3();
            a.Read(file);
            
            if (a.ID3v2Tag.ExistsInFile)
            {
                MessageBox.Show("ID3V2 Tags Found");
            }
            else if (a.ID3v1Tag.ExistsInFile)
            {
                MessageBox.Show("ID3V1 Tags Found");
            }
            else
            {
                MessageBox.Show("No Tags Found");
            }

            Player.URL = file;
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
