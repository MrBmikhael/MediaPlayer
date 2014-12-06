namespace MediaPlayer
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
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Library");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Playlists");
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
            this.songLibViewOpts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ArtistViewOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.AlbumViewOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.YearViewOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.commentViewOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.genreViewOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.songLibContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistContext = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.duration2 = new System.Windows.Forms.Label();
            this.duration1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.volumeBar1 = new System.Windows.Forms.TrackBar();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playASongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.createPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playRecentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToCurrentSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.increaseVolumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseVolumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.shuffleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repeatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.playlistContextMenu.SuspendLayout();
            this.songLibViewOpts.SuspendLayout();
            this.songLibContext.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.mainPanel.SuspendLayout();
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
            this.songLibrary.HideSelection = false;
            this.songLibrary.LabelWrap = false;
            this.songLibrary.Location = new System.Drawing.Point(183, 0);
            this.songLibrary.Name = "songLibrary";
            this.songLibrary.Size = new System.Drawing.Size(670, 486);
            this.songLibrary.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.songLibrary.TabIndex = 0;
            this.songLibrary.UseCompatibleStateImageBehavior = false;
            this.songLibrary.View = System.Windows.Forms.View.Details;
            this.songLibrary.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.songLibrary_ColumnClick);
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
            // songLibViewOpts
            // 
            this.songLibViewOpts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArtistViewOpt,
            this.AlbumViewOpt,
            this.YearViewOpt,
            this.commentViewOpt,
            this.genreViewOpt});
            this.songLibViewOpts.Name = "songLibViewOpts";
            this.songLibViewOpts.Size = new System.Drawing.Size(129, 114);
            // 
            // ArtistViewOpt
            // 
            this.ArtistViewOpt.Checked = true;
            this.ArtistViewOpt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ArtistViewOpt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ArtistViewOpt.Name = "ArtistViewOpt";
            this.ArtistViewOpt.Size = new System.Drawing.Size(128, 22);
            this.ArtistViewOpt.Text = "Artist";
            this.ArtistViewOpt.Click += new System.EventHandler(this.ArtistViewOpt_Click);
            // 
            // AlbumViewOpt
            // 
            this.AlbumViewOpt.Checked = true;
            this.AlbumViewOpt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AlbumViewOpt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AlbumViewOpt.Name = "AlbumViewOpt";
            this.AlbumViewOpt.Size = new System.Drawing.Size(128, 22);
            this.AlbumViewOpt.Text = "Album";
            this.AlbumViewOpt.Click += new System.EventHandler(this.AlbumViewOpt_Click);
            // 
            // YearViewOpt
            // 
            this.YearViewOpt.Checked = true;
            this.YearViewOpt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.YearViewOpt.Name = "YearViewOpt";
            this.YearViewOpt.Size = new System.Drawing.Size(128, 22);
            this.YearViewOpt.Text = "Year";
            this.YearViewOpt.Click += new System.EventHandler(this.YearViewOpt_Click);
            // 
            // commentViewOpt
            // 
            this.commentViewOpt.Checked = true;
            this.commentViewOpt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.commentViewOpt.Name = "commentViewOpt";
            this.commentViewOpt.Size = new System.Drawing.Size(128, 22);
            this.commentViewOpt.Text = "Comment";
            this.commentViewOpt.Click += new System.EventHandler(this.commentViewOpt_Click);
            // 
            // genreViewOpt
            // 
            this.genreViewOpt.Checked = true;
            this.genreViewOpt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.genreViewOpt.Name = "genreViewOpt";
            this.genreViewOpt.Size = new System.Drawing.Size(128, 22);
            this.genreViewOpt.Text = "Genre";
            this.genreViewOpt.Click += new System.EventHandler(this.genreViewOpt_Click);
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
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.duration2);
            this.panel1.Controls.Add(this.duration1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Location = new System.Drawing.Point(12, 526);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 117);
            this.panel1.TabIndex = 1;
            // 
            // duration2
            // 
            this.duration2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.duration2.AutoSize = true;
            this.duration2.Location = new System.Drawing.Point(814, 45);
            this.duration2.Name = "duration2";
            this.duration2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.duration2.Size = new System.Drawing.Size(43, 13);
            this.duration2.TabIndex = 9;
            this.duration2.Text = "0:00:00";
            this.duration2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // duration1
            // 
            this.duration1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.duration1.AutoSize = true;
            this.duration1.Location = new System.Drawing.Point(3, 45);
            this.duration1.Name = "duration1";
            this.duration1.Size = new System.Drawing.Size(43, 13);
            this.duration1.TabIndex = 8;
            this.duration1.Text = "0:00:00";
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
            this.panel2.Location = new System.Drawing.Point(183, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 68);
            this.panel2.TabIndex = 6;
            // 
            // volumeBar1
            // 
            this.volumeBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.volumeBar1.Location = new System.Drawing.Point(48, 44);
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
            this.btnNext.Location = new System.Drawing.Point(372, 2);
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
            this.btnPrev.Location = new System.Drawing.Point(48, 2);
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
            this.btnStop.Location = new System.Drawing.Point(291, 2);
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
            this.btnPause.Location = new System.Drawing.Point(129, 2);
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
            this.btnPlay.Location = new System.Drawing.Point(210, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 33);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(0, 3);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(853, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.controlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
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
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.previousToolStripMenuItem,
            this.playRecentToolStripMenuItem,
            this.goToCurrentSongToolStripMenuItem,
            this.toolStripSeparator3,
            this.increaseVolumeToolStripMenuItem,
            this.decreaseVolumeToolStripMenuItem,
            this.toolStripSeparator4,
            this.shuffleToolStripMenuItem,
            this.repeatToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.previousToolStripMenuItem.Text = "Previous";
            this.previousToolStripMenuItem.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // playRecentToolStripMenuItem
            // 
            this.playRecentToolStripMenuItem.Name = "playRecentToolStripMenuItem";
            this.playRecentToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.playRecentToolStripMenuItem.Text = "Play Recent";
            this.playRecentToolStripMenuItem.DropDownOpened += new System.EventHandler(this.playRecentToolStripMenuItem_DropDownOpened);
            // 
            // goToCurrentSongToolStripMenuItem
            // 
            this.goToCurrentSongToolStripMenuItem.Name = "goToCurrentSongToolStripMenuItem";
            this.goToCurrentSongToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.goToCurrentSongToolStripMenuItem.Text = "Go to Current Song";
            this.goToCurrentSongToolStripMenuItem.Click += new System.EventHandler(this.goToCurrentSongToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(173, 6);
            // 
            // increaseVolumeToolStripMenuItem
            // 
            this.increaseVolumeToolStripMenuItem.Name = "increaseVolumeToolStripMenuItem";
            this.increaseVolumeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.increaseVolumeToolStripMenuItem.Text = "Increase Volume";
            this.increaseVolumeToolStripMenuItem.Click += new System.EventHandler(this.increaseVolumeToolStripMenuItem_Click);
            // 
            // decreaseVolumeToolStripMenuItem
            // 
            this.decreaseVolumeToolStripMenuItem.Name = "decreaseVolumeToolStripMenuItem";
            this.decreaseVolumeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.decreaseVolumeToolStripMenuItem.Text = "Decrease Volume";
            this.decreaseVolumeToolStripMenuItem.Click += new System.EventHandler(this.decreaseVolumeToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(173, 6);
            // 
            // shuffleToolStripMenuItem
            // 
            this.shuffleToolStripMenuItem.CheckOnClick = true;
            this.shuffleToolStripMenuItem.Name = "shuffleToolStripMenuItem";
            this.shuffleToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.shuffleToolStripMenuItem.Text = "Shuffle";
            this.shuffleToolStripMenuItem.Click += new System.EventHandler(this.shuffleToolStripMenuItem_Click);
            // 
            // repeatToolStripMenuItem
            // 
            this.repeatToolStripMenuItem.CheckOnClick = true;
            this.repeatToolStripMenuItem.Name = "repeatToolStripMenuItem";
            this.repeatToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.repeatToolStripMenuItem.Text = "Repeat";
            this.repeatToolStripMenuItem.Click += new System.EventHandler(this.repeatToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(0, -2);
            this.treeView1.Name = "treeView1";
            treeNode19.Name = "libNode";
            treeNode19.Text = "Library";
            treeNode20.Name = "playlistsNode";
            treeNode20.Text = "Playlists";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            this.treeView1.Size = new System.Drawing.Size(177, 488);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPanel.Controls.Add(this.treeView1);
            this.mainPanel.Controls.Add(this.songLibrary);
            this.mainPanel.Location = new System.Drawing.Point(12, 27);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(860, 493);
            this.mainPanel.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.Enabled = false;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar1.Location = new System.Drawing.Point(3, 32);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(854, 10);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 10;
            // 
            // LibraryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 656);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(810, 625);
            this.Name = "LibraryView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LibraryView_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.playlistContextMenu.ResumeLayout(false);
            this.songLibViewOpts.ResumeLayout(false);
            this.songLibContext.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void songLibrary_DragLeave(object sender, System.Windows.Forms.DragEventArgs e)
        {
            throw new System.NotImplementedException();
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
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playRecentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToCurrentSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem increaseVolumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseVolumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem shuffleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repeatToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label duration2;
        private System.Windows.Forms.Label duration1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

