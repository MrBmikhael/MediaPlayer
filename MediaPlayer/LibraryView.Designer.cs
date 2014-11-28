﻿namespace MediaPlayer
{
    partial class LibraryView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryView));
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Library");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Playlists");
            this.playlistContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openInANewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.songLibrary = new System.Windows.Forms.ListView();
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.songLibContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistContext = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.volumeBar1 = new System.Windows.Forms.TrackBar();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playASongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.createPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.songLibViewOpts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AlbumViewOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.ArtistViewOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.YearViewOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.commentViewOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.genreViewOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistContextMenu.SuspendLayout();
            this.songLibContext.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.songLibViewOpts.SuspendLayout();
            this.SuspendLayout();
            // 
            // playlistContextMenu
            // 
            this.playlistContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openInANewWindowToolStripMenuItem,
            this.toolStripMenuItem2});
            this.playlistContextMenu.Name = "playlistContextMenu";
            this.playlistContextMenu.Size = new System.Drawing.Size(198, 48);
            // 
            // openInANewWindowToolStripMenuItem
            // 
            this.openInANewWindowToolStripMenuItem.Name = "openInANewWindowToolStripMenuItem";
            this.openInANewWindowToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.openInANewWindowToolStripMenuItem.Text = "Open in a new Window";
            this.openInANewWindowToolStripMenuItem.Click += new System.EventHandler(this.openInANewWindowToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(197, 22);
            this.toolStripMenuItem2.Text = "Delete Playlist";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // songLibrary
            // 
            this.songLibrary.AllowDrop = true;
            this.songLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songLibrary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTitle,
            this.columnArtist,
            this.columnAlbum,
            this.columnYear,
            this.columnComment,
            this.columnGenre});
            this.songLibrary.ContextMenuStrip = this.songLibViewOpts;
            this.songLibrary.FullRowSelect = true;
            this.songLibrary.GridLines = true;
            this.songLibrary.Location = new System.Drawing.Point(195, 27);
            this.songLibrary.Name = "songLibrary";
            this.songLibrary.Size = new System.Drawing.Size(587, 465);
            this.songLibrary.TabIndex = 0;
            this.songLibrary.UseCompatibleStateImageBehavior = false;
            this.songLibrary.View = System.Windows.Forms.View.Details;
            this.songLibrary.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.songLibrary_ItemDrag);
            this.songLibrary.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.songLibrary.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            this.songLibrary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.songLibrary_KeyDown);
            this.songLibrary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.songLibrary_MouseDown);
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Title";
            this.columnTitle.Width = 230;
            // 
            // columnArtist
            // 
            this.columnArtist.Text = "Artist";
            // 
            // columnAlbum
            // 
            this.columnAlbum.Text = "Album";
            // 
            // columnYear
            // 
            this.columnYear.Text = "Year";
            // 
            // columnComment
            // 
            this.columnComment.Text = "Comment";
            // 
            // columnGenre
            // 
            this.columnGenre.Text = "Genre";
            // 
            // songLibContext
            // 
            this.songLibContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileToolStripMenuItem,
            this.deleteSelectedToolStripMenuItem,
            this.playlistContext});
            this.songLibContext.Name = "contextMenuStrip1";
            this.songLibContext.Size = new System.Drawing.Size(155, 70);
            this.songLibContext.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.songLibContext_Closed);
            // 
            // addFileToolStripMenuItem
            // 
            this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            this.addFileToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addFileToolStripMenuItem.Text = "Add File";
            this.addFileToolStripMenuItem.Click += new System.EventHandler(this.addFileToolStripMenuItem_Click);
            // 
            // deleteSelectedToolStripMenuItem
            // 
            this.deleteSelectedToolStripMenuItem.Name = "deleteSelectedToolStripMenuItem";
            this.deleteSelectedToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.deleteSelectedToolStripMenuItem.Text = "Delete Selected";
            this.deleteSelectedToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedToolStripMenuItem1_Click);
            // 
            // playlistContext
            // 
            this.playlistContext.Name = "playlistContext";
            this.playlistContext.Size = new System.Drawing.Size(154, 22);
            this.playlistContext.Text = "Add to Playlist";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 498);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 76);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.volumeBar1);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPrev);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnPause);
            this.panel2.Controls.Add(this.btnPlay);
            this.panel2.Location = new System.Drawing.Point(183, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 68);
            this.panel2.TabIndex = 6;
            // 
            // volumeBar1
            // 
            this.volumeBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.volumeBar1.Location = new System.Drawing.Point(3, 44);
            this.volumeBar1.Maximum = 100;
            this.volumeBar1.Name = "volumeBar1";
            this.volumeBar1.Size = new System.Drawing.Size(398, 45);
            this.volumeBar1.TabIndex = 6;
            this.volumeBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeBar1.Value = 50;
            this.volumeBar1.Scroll += new System.EventHandler(this.volumeBar1_Scroll);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Image = global::MediaPlayer.Properties.Resources.next;
            this.btnNext.Location = new System.Drawing.Point(327, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 33);
            this.btnNext.TabIndex = 5;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrev.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrev.BackgroundImage = global::MediaPlayer.Properties.Resources.background;
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrev.Image = global::MediaPlayer.Properties.Resources.prev;
            this.btnPrev.Location = new System.Drawing.Point(3, 2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 33);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStop.BackgroundImage = global::MediaPlayer.Properties.Resources.background;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Image = global::MediaPlayer.Properties.Resources.stop;
            this.btnStop.Location = new System.Drawing.Point(246, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 33);
            this.btnStop.TabIndex = 4;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPause.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPause.BackgroundImage = global::MediaPlayer.Properties.Resources.background;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPause.Image = global::MediaPlayer.Properties.Resources.pause;
            this.btnPause.Location = new System.Drawing.Point(84, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 33);
            this.btnPause.TabIndex = 2;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlay.BackgroundImage = global::MediaPlayer.Properties.Resources.background;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Image = global::MediaPlayer.Properties.Resources.play;
            this.btnPlay.Location = new System.Drawing.Point(165, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 33);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSongsToolStripMenuItem,
            this.playASongToolStripMenuItem,
            this.deleteSelectedToolStripMenuItem1,
            this.toolStripSeparator1,
            this.createPlaylistToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addSongsToolStripMenuItem
            // 
            this.addSongsToolStripMenuItem.Name = "addSongsToolStripMenuItem";
            this.addSongsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addSongsToolStripMenuItem.Text = "Add Songs";
            this.addSongsToolStripMenuItem.Click += new System.EventHandler(this.addFileToolStripMenuItem_Click);
            // 
            // playASongToolStripMenuItem
            // 
            this.playASongToolStripMenuItem.Name = "playASongToolStripMenuItem";
            this.playASongToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.playASongToolStripMenuItem.Text = "Play a Song";
            this.playASongToolStripMenuItem.Click += new System.EventHandler(this.playASongToolStripMenuItem_Click);
            // 
            // deleteSelectedToolStripMenuItem1
            // 
            this.deleteSelectedToolStripMenuItem1.Name = "deleteSelectedToolStripMenuItem1";
            this.deleteSelectedToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.deleteSelectedToolStripMenuItem1.Text = "Delete Selected";
            this.deleteSelectedToolStripMenuItem1.Click += new System.EventHandler(this.deleteSelectedToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // createPlaylistToolStripMenuItem
            // 
            this.createPlaylistToolStripMenuItem.Name = "createPlaylistToolStripMenuItem";
            this.createPlaylistToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.createPlaylistToolStripMenuItem.Text = "Create Playlist";
            this.createPlaylistToolStripMenuItem.Click += new System.EventHandler(this.createPlaylistToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(12, 27);
            this.treeView1.Name = "treeView1";
            treeNode5.Name = "libNode";
            treeNode5.Text = "Library";
            treeNode6.Name = "playlistsNode";
            treeNode6.Text = "Playlists";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(177, 465);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // songLibViewOpts
            // 
            this.songLibViewOpts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArtistViewOpt,
            this.AlbumViewOpt,
            this.YearViewOpt,
            this.commentViewOpt,
            this.genreViewOpt});
            this.songLibViewOpts.Name = "songLibViewOpts";
            this.songLibViewOpts.Size = new System.Drawing.Size(153, 136);
            // 
            // AlbumViewOpt
            // 
            this.AlbumViewOpt.Checked = true;
            this.AlbumViewOpt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AlbumViewOpt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AlbumViewOpt.Name = "AlbumViewOpt";
            this.AlbumViewOpt.Size = new System.Drawing.Size(152, 22);
            this.AlbumViewOpt.Text = "Album";
            this.AlbumViewOpt.Click += new System.EventHandler(this.AlbumViewOpt_Click);
            // 
            // ArtistViewOpt
            // 
            this.ArtistViewOpt.Checked = true;
            this.ArtistViewOpt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ArtistViewOpt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ArtistViewOpt.Name = "ArtistViewOpt";
            this.ArtistViewOpt.Size = new System.Drawing.Size(152, 22);
            this.ArtistViewOpt.Text = "Artist";
            this.ArtistViewOpt.Click += new System.EventHandler(this.ArtistViewOpt_Click);
            // 
            // YearViewOpt
            // 
            this.YearViewOpt.Checked = true;
            this.YearViewOpt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.YearViewOpt.Name = "YearViewOpt";
            this.YearViewOpt.Size = new System.Drawing.Size(152, 22);
            this.YearViewOpt.Text = "Year";
            this.YearViewOpt.Click += new System.EventHandler(this.YearViewOpt_Click);
            // 
            // commentViewOpt
            // 
            this.commentViewOpt.Checked = true;
            this.commentViewOpt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.commentViewOpt.Name = "commentViewOpt";
            this.commentViewOpt.Size = new System.Drawing.Size(152, 22);
            this.commentViewOpt.Text = "Comment";
            this.commentViewOpt.Click += new System.EventHandler(this.commentViewOpt_Click);
            // 
            // genreViewOpt
            // 
            this.genreViewOpt.Checked = true;
            this.genreViewOpt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.genreViewOpt.Name = "genreViewOpt";
            this.genreViewOpt.Size = new System.Drawing.Size(152, 22);
            this.genreViewOpt.Text = "Genre";
            this.genreViewOpt.Click += new System.EventHandler(this.genreViewOpt_Click);
            // 
            // LibraryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 587);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.songLibrary);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(810, 625);
            this.Name = "LibraryView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.playlistContextMenu.ResumeLayout(false);
            this.songLibContext.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.songLibViewOpts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView songLibrary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnArtist;
        private System.Windows.Forms.ColumnHeader columnAlbum;
        private System.Windows.Forms.ColumnHeader columnYear;
        private System.Windows.Forms.ColumnHeader columnComment;
        private System.Windows.Forms.ColumnHeader columnGenre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ContextMenuStrip songLibContext;
        private System.Windows.Forms.ToolStripMenuItem addFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSongsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playASongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedToolStripMenuItem1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip playlistContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem createPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem openInANewWindowToolStripMenuItem;
        private System.Windows.Forms.TrackBar volumeBar1;
        private System.Windows.Forms.ToolStripMenuItem playlistContext;
        private System.Windows.Forms.ContextMenuStrip songLibViewOpts;
        private System.Windows.Forms.ToolStripMenuItem ArtistViewOpt;
        private System.Windows.Forms.ToolStripMenuItem AlbumViewOpt;
        private System.Windows.Forms.ToolStripMenuItem YearViewOpt;
        private System.Windows.Forms.ToolStripMenuItem commentViewOpt;
        private System.Windows.Forms.ToolStripMenuItem genreViewOpt;
    }
}
