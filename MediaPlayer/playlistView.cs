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
    public partial class playlistView : Form
    {
        public PlayerWrapper PlayerW;
        public int currentlyPlaying;
        public string playlistName;
        public playlistView(string playlistName)
        {
            InitializeComponent();

            PlayerW = PlayerWrapper.getInstance();
            this.playlistName = playlistName;
            reloadList();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (songLibrary.Items.Count == 0)
            {
                MessageBox.Show("Please add some songs first.");
                return;
            }

            int i = currentlyPlaying;

            songLibrary.Items[currentlyPlaying].Selected = false;

            if (i == 0)
            {
                PlayerW.Player.controls.stop();
                PlayerW.Player.URL = songLibrary.Items[songLibrary.Items.Count - 1].Text;
                PlayerW.Player.controls.play();
                currentlyPlaying = songLibrary.Items.Count - 1;
            }
            else
            {
                i--;
                PlayerW.Player.controls.stop();
                PlayerW.Player.URL = songLibrary.Items[i].Text;
                PlayerW.Player.controls.play();
                currentlyPlaying = i;
            }

            songLibrary.Items[currentlyPlaying].Selected = true;
            songLibrary.Focus();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (songLibrary.Items.Count == 0)
            {
                MessageBox.Show("Please add some songs first.");
                return;
            }

            if (PlayerW.Player.playState == WMPPlayState.wmppsPaused)
            {
                PlayerW.Player.controls.play();
                return;
            }

            songLibrary.Items[currentlyPlaying].Selected = false;

            if (songLibrary.SelectedItems.Count > 0)
            {
                PlayerW.Player.URL = songLibrary.SelectedItems[0].Text;
                currentlyPlaying = songLibrary.Items.IndexOf(songLibrary.SelectedItems[0]);
            }
            else if (songLibrary.Items.Count > 0)
            {
                PlayerW.Player.URL = songLibrary.Items[0].Text;
                currentlyPlaying = 0;
            }

            PlayerW.Player.controls.play();
            songLibrary.Items[currentlyPlaying].Selected = true;
            songLibrary.Focus();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (songLibrary.Items.Count == 0)
            {
                MessageBox.Show("Please add some songs first.");
                return;
            }

            songLibrary.Items[currentlyPlaying].Selected = false;

            if (PlayerW.Player.playState == WMPPlayState.wmppsPaused)
            {
                PlayerW.Player.controls.play();
            }
            else
            {
                PlayerW.Player.controls.pause();
            }
            songLibrary.Items[currentlyPlaying].Selected = true;
            songLibrary.Focus();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (songLibrary.Items.Count == 0)
            {
                MessageBox.Show("Please add some songs first.");
                return;
            }
            
            PlayerW.Player.controls.stop();
            songLibrary.Items[currentlyPlaying].Selected = true;
            songLibrary.Focus();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (songLibrary.Items.Count == 0)
            {
                MessageBox.Show("Please add some songs first.");
                return;
            }

            int i = currentlyPlaying;

            songLibrary.Items[currentlyPlaying].Selected = false;

            if (i == songLibrary.Items.Count - 1)
            {
                PlayerW.Player.controls.stop();
                PlayerW.Player.URL = songLibrary.Items[0].Text;
                PlayerW.Player.controls.play();
                currentlyPlaying = 0;
            }
            else
            {
                i++;
                PlayerW.Player.controls.stop();
                PlayerW.Player.URL = songLibrary.Items[i].Text;
                PlayerW.Player.controls.play();
                currentlyPlaying = i;
            }

            songLibrary.Items[currentlyPlaying].Selected = true;
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
                    {
                        SQLManager.getInstance().Insert(file);
                        Playlist.addToPlalist(playlistName, Library.getSongID(file));
                    }
                }

                reloadList();
            }
            else if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                ListViewItem a = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                songLibrary.Items.Add((ListViewItem)a.Clone());
                Playlist.addToPlalist(playlistName, Library.getSongID(a.Text));
            }

        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else if (e.Data.GetDataPresent(typeof(ListViewItem)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        public void reloadList()
        {
            songLibrary.Items.Clear();
            List<Song> SongList = Playlist.getPlaylistContents(playlistName);

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
                PlayerW.Player.URL = openSongs.FileNames[0].ToString();
                PlayerW.Player.controls.play();
            }
        }

        private void deleteSelectedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in songLibrary.SelectedItems)
            {
                Playlist.DeleteFromPlaylist(Playlist.getPlaylistID(playlistName), Library.getSongID(item.Text));
            }

            reloadList();
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
                    int id = Library.getSongID(file);
                    Playlist.addToPlalist(playlistName, id);
                }

                reloadList();
            }
        }

        private void volumeBar1_Scroll(object sender, EventArgs e)
        {
            PlayerW.Player.settings.volume = volumeBar1.Value;
        }

    }
}
