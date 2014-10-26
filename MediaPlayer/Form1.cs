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
        public ListViewItem currentlyPlaying;
        public Form1()
        {
            InitializeComponent();
            Player = new WMPLib.WindowsMediaPlayer();
            treeView1.Nodes[1].Expand();
            reloadList();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (songLibrary.Items.Count < 1)
            {
                MessageBox.Show("the library is empty.");
                return;
            }

            int i = songLibrary.Items.IndexOf(currentlyPlaying);

            if (currentlyPlaying != null)
                songLibrary.Items[songLibrary.Items.IndexOf(currentlyPlaying)].Selected = false;

            if (i == 0)
            {
                Player.controls.stop();
                Player.URL = songLibrary.Items[songLibrary.Items.Count-1].Text;
                Player.controls.play();
                currentlyPlaying = songLibrary.Items[songLibrary.Items.Count - 1];
            }
            else
            {
                i--;
                Player.controls.stop();
                Player.URL = songLibrary.Items[i].Text;
                Player.controls.play();
                currentlyPlaying = songLibrary.Items[i];
            }

            songLibrary.Items[songLibrary.Items.IndexOf(currentlyPlaying)].Selected = true;
            songLibrary.Focus();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (Player.playState == WMPPlayState.wmppsPaused)
            {
                Player.controls.play();
                return;
            }

            if (currentlyPlaying != null)
                songLibrary.Items[songLibrary.Items.IndexOf(currentlyPlaying)].Selected = false;

            if (songLibrary.SelectedItems.Count > 0)
            {
                Player.URL = songLibrary.SelectedItems[0].Text;
                currentlyPlaying = songLibrary.SelectedItems[0];
            }
            else if (songLibrary.Items.Count > 0)
            {
                Player.URL = songLibrary.Items[0].Text;
                currentlyPlaying = songLibrary.Items[0];
            }
            else
            {
                MessageBox.Show("The library is empty.");
            }

            Player.controls.play();
            songLibrary.Items[songLibrary.Items.IndexOf(currentlyPlaying)].Selected = true;
            songLibrary.Focus();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (currentlyPlaying != null)
                songLibrary.Items[songLibrary.Items.IndexOf(currentlyPlaying)].Selected = false;

            if (Player.playState == WMPPlayState.wmppsPaused)
            {
                Player.controls.play();
            }
            else
            {
                Player.controls.pause();
            }
            songLibrary.Items[songLibrary.Items.IndexOf(currentlyPlaying)].Selected = true;
            songLibrary.Focus();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Player.controls.stop();

            if (currentlyPlaying != null)
                songLibrary.Items[songLibrary.Items.IndexOf(currentlyPlaying)].Selected = true;

            songLibrary.Focus();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (songLibrary.Items.Count < 1)
            {
                MessageBox.Show("the library is empty.");
                return;
            }

            int i = songLibrary.Items.IndexOf(currentlyPlaying);

            if (currentlyPlaying != null)
                songLibrary.Items[songLibrary.Items.IndexOf(currentlyPlaying)].Selected = false;

            if (i == songLibrary.Items.Count - 1)
            {
                Player.controls.stop();
                Player.URL = songLibrary.Items[0].Text;
                Player.controls.play();
                currentlyPlaying = songLibrary.Items[0];
            }
            else
            {
                i++;
                Player.controls.stop();
                Player.URL = songLibrary.Items[i].Text;
                Player.controls.play();
                currentlyPlaying = songLibrary.Items[i];
            }

            songLibrary.Items[songLibrary.Items.IndexOf(currentlyPlaying)].Selected = true;
            songLibrary.Focus();
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[]) (e.Data.GetData(DataFormats.FileDrop));
                foreach (string file in files)
                {
                    if (File.Exists(file) && file.EndsWith(".mp3"))
                        SQLManager.getInstance().Insert(file);
                }

                reloadList();
            }

        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Player.controls.stop();
            SQLManager.getInstance().CloseDB();
        }

        public void reloadList()
        {
            songLibrary.Items.Clear();
            List<Song> SongList = Library.getSongs();

            for (int i = 0; i < SongList.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = SongList[i].File;
                item.SubItems.Add(SongList[i].Title);
                item.SubItems.Add(SongList[i].Artist);
                item.SubItems.Add(SongList[i].Album);
                item.SubItems.Add(SongList[i].Year.ToString());
                item.SubItems.Add(SongList[i].Comment);
                item.SubItems.Add(SongList[i].Genre);

                songLibrary.Items.Add(item);
            }
        }

        private void deleteSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < songLibrary.SelectedItems.Count; i++)
            {
                Library.deleteSong(songLibrary.SelectedItems[i].Text);
            }

            reloadList();
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playASongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openSongs = new OpenFileDialog();
            openSongs.Multiselect = false;
            openSongs.Filter = "*.mp3|*.mp3";

            if (openSongs.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Player.URL = openSongs.FileNames[0].ToString();
                Player.controls.play();
            }
        }

        private void deleteSelectedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in songLibrary.SelectedItems)
            {
                songLibrary.Items.Remove(item);
                Library.deleteSong(item.Text);
            }
        }

        private void addFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openSongs = new OpenFileDialog();
            openSongs.Multiselect = true;
            openSongs.Filter = "*.mp3|*.mp3";

            if (openSongs.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string file in openSongs.FileNames)
                {
                    SQLManager.getInstance().Insert(file);
                }

                reloadList();
            }
        }

        private void reloadPlaylists()
        {
            treeView1.Nodes[1].Nodes.Clear();
            
            List<string> playlists = Playlist.getAllPlaylists();

            foreach (string a in playlists)
            {
                treeView1.Nodes[1].Nodes.Add(a).ContextMenuStrip = playlistContextMenu;
            }
            treeView1.Refresh();
        }
        private void createPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create Playlist
            CreatePlaylistForm CPF = new CreatePlaylistForm();

            if (CPF.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                reloadPlaylists();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Playlist.deletePlaylist(treeView1.SelectedNode.Text);
            reloadPlaylists();
        }
    }
}
