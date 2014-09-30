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
using System.IO;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public WMPLib.WindowsMediaPlayer Player;
        public Form1()
        {
            InitializeComponent();
            Player = new WMPLib.WindowsMediaPlayer();
            SQLManager.getInstance();
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            //Player.controls.previous();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Player.URL = file;
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
                        SQLManager.getInstance().Insert(file);
                        reloadList();
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

        private void tESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SQLManager.getInstance().getCount().ToString());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQLManager.getInstance().SaveDB();
        }

        public void reloadList()
        {
            songLibrary.Clear();
            List<Song> SongList = SQLManager.getInstance().getSongs();

            for (int i = 0; i < SongList.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = SongList[i].File;
                item.SubItems.Add(SongList[i].Title);
                item.SubItems.Add(SongList[i].Album);

                songLibrary.Items.Add(item);
            }
        }
    }
}
