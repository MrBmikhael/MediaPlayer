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
using System.IO;


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

            UltraID3 tagReader = new UltraID3();
            tagReader.Read(file);

            if (tagReader.ID3v2Tag.ExistsInFile)
            {
                //MessageBox.Show("ID3V2 Tags Found");
                int i = 0;

                SongsDBDataSetTableAdapters.SongsTableAdapter s = new SongsDBDataSetTableAdapters.SongsTableAdapter();

                s.Insert(0, file, tagReader.ID3v2Tag.Title, tagReader.ID3v2Tag.Artist, tagReader.ID3v2Tag.Album, (int)tagReader.ID3v2Tag.Year, tagReader.ID3v2Tag.Comments, tagReader.ID3v2Tag.Genre);
                

                int count = s.GetData().Count;
            }
            else if (tagReader.ID3v1Tag.ExistsInFile)
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

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[]) (e.Data.GetData(DataFormats.FileDrop));
                foreach (string file in files)
                {
                    if (File.Exists(file) && file.EndsWith(".mp3"))
                    {
                        // Add file to SQL Database
                        MessageBox.Show(file);
                    }
                }
            }

        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
