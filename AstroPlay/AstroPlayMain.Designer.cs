namespace AstroPlay
{
    partial class AstroPlayMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AstroPlayMain));
            panelPlayerControls = new Panel();
            lblSongName = new Label();
            lblAlbumName = new Label();
            lblArtistName = new Label();
            aP_ProgressBar1 = new AP_ProgressBar();
            labelTimerRight = new Label();
            labelTimerLeft = new Label();
            pictureBox1 = new PictureBox();
            btnRepeat = new Button();
            btnPlayOrPause = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnShuffle = new Button();
            panelSideMenu = new Panel();
            btnAbout = new Button();
            btnSettings = new Button();
            panelPlaylistSubMenu = new Panel();
            btnAdd = new Button();
            btnPlaylist = new Button();
            panelMusicSubMenu = new Panel();
            btnGenre = new Button();
            btnArtist = new Button();
            btnAlbum = new Button();
            btnMusic = new Button();
            btnHome = new Button();
            panelLogo = new Panel();
            panelMainContent = new Panel();
            panelPlayerControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelSideMenu.SuspendLayout();
            panelPlaylistSubMenu.SuspendLayout();
            panelMusicSubMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelPlayerControls
            // 
            panelPlayerControls.BackColor = Color.FromArgb(10, 25, 45);
            panelPlayerControls.Controls.Add(lblSongName);
            panelPlayerControls.Controls.Add(lblAlbumName);
            panelPlayerControls.Controls.Add(lblArtistName);
            panelPlayerControls.Controls.Add(aP_ProgressBar1);
            panelPlayerControls.Controls.Add(labelTimerRight);
            panelPlayerControls.Controls.Add(labelTimerLeft);
            panelPlayerControls.Controls.Add(pictureBox1);
            panelPlayerControls.Controls.Add(btnRepeat);
            panelPlayerControls.Controls.Add(btnPlayOrPause);
            panelPlayerControls.Controls.Add(btnNext);
            panelPlayerControls.Controls.Add(btnPrevious);
            panelPlayerControls.Controls.Add(btnShuffle);
            panelPlayerControls.Dock = DockStyle.Bottom;
            panelPlayerControls.Font = new Font("Microsoft Sans Serif", 6.9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelPlayerControls.Location = new Point(0, 1014);
            panelPlayerControls.Name = "panelPlayerControls";
            panelPlayerControls.Size = new Size(1880, 196);
            panelPlayerControls.TabIndex = 0;
            // 
            // lblSongName
            // 
            lblSongName.AutoEllipsis = true;
            lblSongName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSongName.ForeColor = SystemColors.ButtonHighlight;
            lblSongName.Location = new Point(150, 7);
            lblSongName.Name = "lblSongName";
            lblSongName.Size = new Size(592, 59);
            lblSongName.TabIndex = 17;
            lblSongName.Text = "Wanna Be Startin' Somethin'";
            lblSongName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAlbumName
            // 
            lblAlbumName.AutoSize = true;
            lblAlbumName.Font = new Font("Microsoft Sans Serif", 8.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlbumName.ForeColor = SystemColors.ButtonHighlight;
            lblAlbumName.Location = new Point(151, 108);
            lblAlbumName.Name = "lblAlbumName";
            lblAlbumName.Size = new Size(102, 32);
            lblAlbumName.TabIndex = 16;
            lblAlbumName.Text = "Thriller";
            // 
            // lblArtistName
            // 
            lblArtistName.AutoSize = true;
            lblArtistName.Font = new Font("Microsoft Sans Serif", 8.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArtistName.ForeColor = SystemColors.ButtonHighlight;
            lblArtistName.Location = new Point(151, 66);
            lblArtistName.Name = "lblArtistName";
            lblArtistName.Size = new Size(224, 32);
            lblArtistName.TabIndex = 15;
            lblArtistName.Text = "Michael Jackson";
            // 
            // aP_ProgressBar1
            // 
            aP_ProgressBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            aP_ProgressBar1.BackColor = Color.White;
            aP_ProgressBar1.ChannelColor = Color.LightSteelBlue;
            aP_ProgressBar1.ChannelHeight = 6;
            aP_ProgressBar1.ForeColor = Color.White;
            aP_ProgressBar1.Location = new Point(150, 147);
            aP_ProgressBar1.Name = "aP_ProgressBar1";
            aP_ProgressBar1.ShowValue = TextPosition.None;
            aP_ProgressBar1.Size = new Size(1580, 25);
            aP_ProgressBar1.SliderColor = Color.RoyalBlue;
            aP_ProgressBar1.SliderHeight = 6;
            aP_ProgressBar1.TabIndex = 10;
            // 
            // labelTimerRight
            // 
            labelTimerRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTimerRight.BackColor = Color.FromArgb(10, 25, 45);
            labelTimerRight.Font = new Font("Microsoft Sans Serif", 8.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTimerRight.ForeColor = SystemColors.ButtonHighlight;
            labelTimerRight.Location = new Point(1740, 147);
            labelTimerRight.Name = "labelTimerRight";
            labelTimerRight.Size = new Size(120, 40);
            labelTimerRight.TabIndex = 13;
            labelTimerRight.Text = "0:00:00";
            labelTimerRight.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTimerLeft
            // 
            labelTimerLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelTimerLeft.BackColor = Color.FromArgb(10, 25, 45);
            labelTimerLeft.Font = new Font("Microsoft Sans Serif", 8.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTimerLeft.ForeColor = SystemColors.ButtonHighlight;
            labelTimerLeft.Location = new Point(10, 147);
            labelTimerLeft.Name = "labelTimerLeft";
            labelTimerLeft.Size = new Size(120, 40);
            labelTimerLeft.TabIndex = 12;
            labelTimerLeft.Text = "0:00:00";
            labelTimerLeft.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(12, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 133);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnRepeat
            // 
            btnRepeat.BackColor = Color.White;
            btnRepeat.FlatAppearance.BorderSize = 0;
            btnRepeat.FlatStyle = FlatStyle.Flat;
            btnRepeat.Font = new Font("Microsoft Sans Serif", 6F);
            btnRepeat.ForeColor = Color.Red;
            btnRepeat.Location = new Point(1153, 7);
            btnRepeat.Name = "btnRepeat";
            btnRepeat.Padding = new Padding(10, 0, 0, 0);
            btnRepeat.Size = new Size(90, 90);
            btnRepeat.TabIndex = 9;
            btnRepeat.Text = "Rep";
            btnRepeat.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRepeat.UseVisualStyleBackColor = false;
            // 
            // btnPlayOrPause
            // 
            btnPlayOrPause.BackColor = Color.FromArgb(10, 25, 45);
            btnPlayOrPause.BackgroundImage = (Image)resources.GetObject("btnPlayOrPause.BackgroundImage");
            btnPlayOrPause.BackgroundImageLayout = ImageLayout.Zoom;
            btnPlayOrPause.FlatAppearance.BorderSize = 0;
            btnPlayOrPause.FlatStyle = FlatStyle.Flat;
            btnPlayOrPause.Font = new Font("Microsoft Sans Serif", 6F);
            btnPlayOrPause.ForeColor = Color.Red;
            btnPlayOrPause.Location = new Point(961, 7);
            btnPlayOrPause.Name = "btnPlayOrPause";
            btnPlayOrPause.Padding = new Padding(10, 0, 0, 0);
            btnPlayOrPause.Size = new Size(90, 90);
            btnPlayOrPause.TabIndex = 5;
            btnPlayOrPause.UseVisualStyleBackColor = false;
            btnPlayOrPause.Click += btnPlayOrPause_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.White;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Microsoft Sans Serif", 6F);
            btnNext.ForeColor = Color.Red;
            btnNext.Location = new Point(1057, 7);
            btnNext.Name = "btnNext";
            btnNext.Padding = new Padding(10, 0, 0, 0);
            btnNext.Size = new Size(90, 90);
            btnNext.TabIndex = 6;
            btnNext.Text = "Next";
            btnNext.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.White;
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Microsoft Sans Serif", 6F);
            btnPrevious.ForeColor = Color.Red;
            btnPrevious.Location = new Point(865, 7);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Padding = new Padding(10, 0, 0, 0);
            btnPrevious.Size = new Size(90, 90);
            btnPrevious.TabIndex = 7;
            btnPrevious.Text = "Prev";
            btnPrevious.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnShuffle
            // 
            btnShuffle.BackColor = Color.White;
            btnShuffle.FlatAppearance.BorderSize = 0;
            btnShuffle.FlatStyle = FlatStyle.Flat;
            btnShuffle.Font = new Font("Microsoft Sans Serif", 6F);
            btnShuffle.ForeColor = Color.Red;
            btnShuffle.Location = new Point(769, 7);
            btnShuffle.Name = "btnShuffle";
            btnShuffle.Padding = new Padding(10, 0, 0, 0);
            btnShuffle.Size = new Size(90, 90);
            btnShuffle.TabIndex = 8;
            btnShuffle.Text = "Shuf";
            btnShuffle.TextImageRelation = TextImageRelation.ImageAboveText;
            btnShuffle.UseVisualStyleBackColor = false;
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.Black;
            panelSideMenu.Controls.Add(btnAbout);
            panelSideMenu.Controls.Add(btnSettings);
            panelSideMenu.Controls.Add(panelPlaylistSubMenu);
            panelSideMenu.Controls.Add(btnPlaylist);
            panelSideMenu.Controls.Add(panelMusicSubMenu);
            panelSideMenu.Controls.Add(btnMusic);
            panelSideMenu.Controls.Add(btnHome);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Font = new Font("Microsoft Sans Serif", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(560, 1014);
            panelSideMenu.TabIndex = 1;
            // 
            // btnAbout
            // 
            btnAbout.Dock = DockStyle.Top;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Microsoft Sans Serif", 9.900001F);
            btnAbout.ForeColor = Color.White;
            btnAbout.Location = new Point(0, 904);
            btnAbout.Name = "btnAbout";
            btnAbout.Padding = new Padding(10, 0, 0, 0);
            btnAbout.Size = new Size(560, 93);
            btnAbout.TabIndex = 7;
            btnAbout.Text = "About";
            btnAbout.TextAlign = ContentAlignment.MiddleLeft;
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Microsoft Sans Serif", 9.900001F);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(0, 811);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(10, 0, 0, 0);
            btnSettings.Size = new Size(560, 93);
            btnSettings.TabIndex = 6;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // panelPlaylistSubMenu
            // 
            panelPlaylistSubMenu.BackColor = Color.FromArgb(15, 15, 15);
            panelPlaylistSubMenu.Controls.Add(btnAdd);
            panelPlaylistSubMenu.Dock = DockStyle.Top;
            panelPlaylistSubMenu.Location = new Point(0, 707);
            panelPlaylistSubMenu.Name = "panelPlaylistSubMenu";
            panelPlaylistSubMenu.Size = new Size(560, 104);
            panelPlaylistSubMenu.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Top;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 9.900001F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(40, 0, 0, 0);
            btnAdd.Size = new Size(560, 93);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnPlaylist
            // 
            btnPlaylist.Dock = DockStyle.Top;
            btnPlaylist.FlatAppearance.BorderSize = 0;
            btnPlaylist.FlatStyle = FlatStyle.Flat;
            btnPlaylist.Font = new Font("Microsoft Sans Serif", 9.900001F);
            btnPlaylist.ForeColor = Color.White;
            btnPlaylist.Location = new Point(0, 614);
            btnPlaylist.Name = "btnPlaylist";
            btnPlaylist.Padding = new Padding(10, 0, 0, 0);
            btnPlaylist.Size = new Size(560, 93);
            btnPlaylist.TabIndex = 4;
            btnPlaylist.Text = "Playlists";
            btnPlaylist.TextAlign = ContentAlignment.MiddleLeft;
            btnPlaylist.UseVisualStyleBackColor = true;
            btnPlaylist.Click += btnPlaylist_Click;
            // 
            // panelMusicSubMenu
            // 
            panelMusicSubMenu.BackColor = Color.FromArgb(15, 15, 15);
            panelMusicSubMenu.Controls.Add(btnGenre);
            panelMusicSubMenu.Controls.Add(btnArtist);
            panelMusicSubMenu.Controls.Add(btnAlbum);
            panelMusicSubMenu.Dock = DockStyle.Top;
            panelMusicSubMenu.Location = new Point(0, 320);
            panelMusicSubMenu.Name = "panelMusicSubMenu";
            panelMusicSubMenu.Size = new Size(560, 294);
            panelMusicSubMenu.TabIndex = 3;
            // 
            // btnGenre
            // 
            btnGenre.Dock = DockStyle.Top;
            btnGenre.FlatAppearance.BorderSize = 0;
            btnGenre.FlatStyle = FlatStyle.Flat;
            btnGenre.Font = new Font("Microsoft Sans Serif", 9.900001F);
            btnGenre.ForeColor = Color.White;
            btnGenre.Location = new Point(0, 186);
            btnGenre.Name = "btnGenre";
            btnGenre.Padding = new Padding(40, 0, 0, 0);
            btnGenre.Size = new Size(560, 93);
            btnGenre.TabIndex = 5;
            btnGenre.Text = "Genre";
            btnGenre.TextAlign = ContentAlignment.MiddleLeft;
            btnGenre.UseVisualStyleBackColor = true;
            btnGenre.Click += btnGenre_Click;
            // 
            // btnArtist
            // 
            btnArtist.Dock = DockStyle.Top;
            btnArtist.FlatAppearance.BorderSize = 0;
            btnArtist.FlatStyle = FlatStyle.Flat;
            btnArtist.Font = new Font("Microsoft Sans Serif", 9.900001F);
            btnArtist.ForeColor = Color.White;
            btnArtist.Location = new Point(0, 93);
            btnArtist.Name = "btnArtist";
            btnArtist.Padding = new Padding(40, 0, 0, 0);
            btnArtist.Size = new Size(560, 93);
            btnArtist.TabIndex = 4;
            btnArtist.Text = "Artists";
            btnArtist.TextAlign = ContentAlignment.MiddleLeft;
            btnArtist.UseVisualStyleBackColor = true;
            btnArtist.Click += btnArtist_Click;
            // 
            // btnAlbum
            // 
            btnAlbum.Dock = DockStyle.Top;
            btnAlbum.FlatAppearance.BorderSize = 0;
            btnAlbum.FlatStyle = FlatStyle.Flat;
            btnAlbum.Font = new Font("Microsoft Sans Serif", 9.900001F);
            btnAlbum.ForeColor = Color.White;
            btnAlbum.Location = new Point(0, 0);
            btnAlbum.Name = "btnAlbum";
            btnAlbum.Padding = new Padding(40, 0, 0, 0);
            btnAlbum.Size = new Size(560, 93);
            btnAlbum.TabIndex = 3;
            btnAlbum.Text = "Albums";
            btnAlbum.TextAlign = ContentAlignment.MiddleLeft;
            btnAlbum.UseVisualStyleBackColor = true;
            btnAlbum.Click += btnAlbum_Click;
            // 
            // btnMusic
            // 
            btnMusic.Dock = DockStyle.Top;
            btnMusic.FlatAppearance.BorderSize = 0;
            btnMusic.FlatStyle = FlatStyle.Flat;
            btnMusic.Font = new Font("Microsoft Sans Serif", 9.900001F);
            btnMusic.ForeColor = Color.White;
            btnMusic.Location = new Point(0, 227);
            btnMusic.Name = "btnMusic";
            btnMusic.Padding = new Padding(10, 0, 0, 0);
            btnMusic.Size = new Size(560, 93);
            btnMusic.TabIndex = 2;
            btnMusic.Text = "Music";
            btnMusic.TextAlign = ContentAlignment.MiddleLeft;
            btnMusic.UseVisualStyleBackColor = true;
            btnMusic.Click += btnMusic_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Microsoft Sans Serif", 9.900001F);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(0, 134);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(10, 0, 0, 0);
            btnHome.Size = new Size(560, 93);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.DarkKhaki;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(560, 134);
            panelLogo.TabIndex = 0;
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = Color.FromArgb(15, 15, 15);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(560, 0);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(1320, 1014);
            panelMainContent.TabIndex = 2;
            // 
            // AstroPlayMain
            // 
            AutoScaleDimensions = new SizeF(19F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1880, 1210);
            Controls.Add(panelMainContent);
            Controls.Add(panelSideMenu);
            Controls.Add(panelPlayerControls);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AstroPlayMain";
            Text = "Form1";
            panelPlayerControls.ResumeLayout(false);
            panelPlayerControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelSideMenu.ResumeLayout(false);
            panelPlaylistSubMenu.ResumeLayout(false);
            panelMusicSubMenu.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPlayerControls;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMusicSubMenu;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Button btnGenre;
        private System.Windows.Forms.Button btnArtist;
        private System.Windows.Forms.Button btnAlbum;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panelPlaylistSubMenu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Button btnAbout;
        private Panel panelMainContent;
        private Button btnNext;
        private Button btnPlayOrPause;
        private Button btnPrevious;
        private Button btnRepeat;
        private Button btnShuffle;
        private AP_ProgressBar aP_ProgressBar1;
        private PictureBox pictureBox1;
        private Label labelTimerLeft;
        private Label labelTimerRight;
        private Label lblArtistName;
        private Label lblAlbumName;
        private Label lblSongName;
    }
}