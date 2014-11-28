﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;
using System.Threading;

namespace MediaPlayer
{
    public partial class LibraryView : Form
    {
        public PlayerWrapper PlayerW;
        public int currentlyPlaying = 0;
        public bool playlistSelected = false;
        public LibraryView()
        {
            InitializeComponent();
            PlayerW = PlayerWrapper.getInstance();

            songLibrary.Columns[0].Tag = "Title";
            songLibrary.Columns[1].Tag = "Artist";
            songLibrary.Columns[2].Tag = "Album";
            songLibrary.Columns[3].Tag = "Year";
            songLibrary.Columns[4].Tag = "Comment";
            songLibrary.Columns[5].Tag = "Genre";

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
                        Library.insert(file);

                        if (playlistSelected)
                            Playlist.addToPlalist(treeView1.SelectedNode.Text, Library.getSongID(file));
                    }
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
            PlayerW.Player.controls.stop();
            SQLManager.getInstance().CloseDB();
        }

        public void reloadList()
        {
            songLibrary.Items.Clear();
            List<Song> SongList = new List<Song>();

            if (treeView1.SelectedNode != null)
            {
                if (treeView1.SelectedNode.Text == "Library" || treeView1.SelectedNode.Text == "Playlists")
                {
                    SongList = Library.getSongs();
                    playlistSelected = false;
                }
                else
                {
                    SongList = Playlist.getPlaylistContents(treeView1.SelectedNode.Text);
                    playlistSelected = true;
                }
            }
            else
            {
                SongList = Library.getSongs();
            }

            for (int i = 0; i < SongList.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = SongList[i].Title;
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
                PlayerW.Player.URL = openSongs.FileNames[0].ToString();
                PlayerW.Player.controls.play();
            }
        }

        private void deleteSelectedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in songLibrary.SelectedItems)
            {
                if (playlistSelected)
                {
                    Playlist.DeleteFromPlaylist(Playlist.getPlaylistID(treeView1.SelectedNode.Text), Library.getSongID(item.Text));
                }
                else
                {
                    songLibrary.Items.Remove(item);
                    Library.deleteSong(item.Text);
                }
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
                    Library.insert(file);
                }

                reloadList();
            }
        }

        private void reloadPlaylists()
        {
            treeView1.Nodes[1].Nodes.Clear();
            playlistContext.DropDownItems.Clear();

            List<string> playlists = Playlist.getAllPlaylists();

            foreach (string a in playlists)
            {
                treeView1.Nodes[1].Nodes.Add(a).ContextMenuStrip = playlistContextMenu;

                ToolStripMenuItem item = new ToolStripMenuItem(a);
                item.Click += item_Click;
                playlistContext.DropDownItems.Add(item);

            }
            treeView1.Refresh();
            treeView1.Nodes[1].Expand();
        }

        void item_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in songLibrary.SelectedItems)
            {
                Playlist.addToPlalist(sender.ToString(), Library.getSongID(item.Text));
            }
        }
        private void createPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatePlaylistForm CPF = new CreatePlaylistForm();

            if (CPF.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                reloadPlaylists();
            }

            treeView1.SelectedNode = treeView1.Nodes[1].LastNode;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this playlist?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Playlist.deletePlaylist(treeView1.SelectedNode.Text);
                reloadPlaylists();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reloadList();
            reloadPlaylists();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            reloadList();
        }

        private void openInANewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playlistView a = new playlistView(treeView1.SelectedNode.Text);
            a.Show();

            treeView1.SelectedNode = treeView1.Nodes[0];
        }

        private void songLibrary_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        private void volumeBar1_Scroll(object sender, EventArgs e)
        {
            PlayerW.Player.settings.volume = volumeBar1.Value;
        }

        private void songLibrary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "I")
            {
                if (volumeBar1.Value < 100) 
                {
                    volumeBar1.Value += 5;
                    PlayerW.Player.settings.volume = volumeBar1.Value;
                }
                
            }

            if (e.Control && e.KeyCode.ToString() == "D")
            {
                if (volumeBar1.Value > 0) 
                { 
                    volumeBar1.Value -= 5;
                    PlayerW.Player.settings.volume = volumeBar1.Value;
                }
                
            }
        }

        private void songLibrary_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                songLibrary.ContextMenuStrip = songLibContext;
            }
        }

        private void songLibContext_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            songLibrary.ContextMenuStrip = songLibViewOpts;
        }

        private void ArtistViewOpt_Click(object sender, EventArgs e)
        {
            ArtistViewOpt.Checked = !ArtistViewOpt.Checked;

            if (ArtistViewOpt.Checked)
            {
                //songLibrary.Columns.Insert(1, "Artist");
                //songLibrary.Columns[1].Tag = "Artist";

                songLibrary.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            else
            {
                songLibrary.Columns[1].Width = 0;
                //for (int i = 0; i < songLibrary.Columns.Count; i++)
                //{
                //    if (songLibrary.Columns[i].Tag.Equals("Artist"))
                //    {
                //        songLibrary.Columns.RemoveAt(i);
                //    }
                //}
            }
        }

        private void AlbumViewOpt_Click(object sender, EventArgs e)
        {
            AlbumViewOpt.Checked = !AlbumViewOpt.Checked;

            if (AlbumViewOpt.Checked)
            {
                songLibrary.Columns.Insert(2, "Album");
                songLibrary.Columns[2].Tag = "Album";
            }
            else
            {
                for (int i = 0; i < songLibrary.Columns.Count; i++)
                {
                    if (songLibrary.Columns[i].Tag.Equals("Album"))
                    {
                        songLibrary.Columns.RemoveAt(i);
                    }
                }
            }
        }

        private void YearViewOpt_Click(object sender, EventArgs e)
        {
            YearViewOpt.Checked = !YearViewOpt.Checked;

            if (YearViewOpt.Checked)
            {
                songLibrary.Columns.Insert(3, "Year");
                songLibrary.Columns[3].Tag = "Year";
            }
            else
            {
                for (int i = 0; i < songLibrary.Columns.Count; i++)
                {
                    if (songLibrary.Columns[i].Tag.Equals("Year"))
                    {
                        songLibrary.Columns.RemoveAt(i);
                    }
                }
            }
        }

        private void commentViewOpt_Click(object sender, EventArgs e)
        {
            commentViewOpt.Checked = !commentViewOpt.Checked;

            if (commentViewOpt.Checked)
            {
                int c = songLibrary.Columns.Count;
                songLibrary.Columns.Insert(c, "Comment");
                songLibrary.Columns[c].Tag = "Comment";
            }
            else
            {
                for (int i = 0; i < songLibrary.Columns.Count; i++)
                {
                    if (songLibrary.Columns[i].Tag.Equals("Comment"))
                    {
                        songLibrary.Columns.RemoveAt(i);
                    }
                }
            }
        }

        private void genreViewOpt_Click(object sender, EventArgs e)
        {
            genreViewOpt.Checked = !genreViewOpt.Checked;

            if (genreViewOpt.Checked)
            {
                songLibrary.Columns.Insert(5, "Genre");
                songLibrary.Columns[5].Tag = "Genre";
            }
            else
            {
                for (int i = 0; i < songLibrary.Columns.Count; i++)
                {
                    if (songLibrary.Columns[i].Tag.Equals("Genre"))
                    {
                        songLibrary.Columns.RemoveAt(i);
                    }
                }
            }
        }



    }
}