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
            panelProgressBar = new Panel();
            panel1 = new Panel();
            lblSongName = new Label();
            lblAlbumName = new Label();
            lblArtistName = new Label();
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
            pictureBoxLogo = new PictureBox();
            panelMainContent = new Panel();
            panelPlayerControls.SuspendLayout();
            panelProgressBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelSideMenu.SuspendLayout();
            panelPlaylistSubMenu.SuspendLayout();
            panelMusicSubMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelPlayerControls
            // 
            panelPlayerControls.BackColor = Color.FromArgb(10, 25, 45);
            panelPlayerControls.CausesValidation = false;
            panelPlayerControls.Controls.Add(panelProgressBar);
            panelPlayerControls.Controls.Add(lblSongName);
            panelPlayerControls.Controls.Add(lblAlbumName);
            panelPlayerControls.Controls.Add(lblArtistName);
            panelPlayerControls.Controls.Add(labelTimerRight);
            panelPlayerControls.Controls.Add(labelTimerLeft);
            panelPlayerControls.Controls.Add(pictureBox1);
            panelPlayerControls.Controls.Add(btnRepeat);
            panelPlayerControls.Controls.Add(btnPlayOrPause);
            panelPlayerControls.Controls.Add(btnNext);
            panelPlayerControls.Controls.Add(btnPrevious);
            panelPlayerControls.Controls.Add(btnShuffle);
            panelPlayerControls.Dock = DockStyle.Bottom;
            panelPlayerControls.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelPlayerControls.Location = new Point(0, 450);
            panelPlayerControls.Name = "panelPlayerControls";
            panelPlayerControls.Size = new Size(901, 106);
            panelPlayerControls.TabIndex = 0;
            // 
            // panelProgressBar
            // 
            panelProgressBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelProgressBar.BackColor = Color.LightSteelBlue;
            panelProgressBar.Controls.Add(panel1);
            panelProgressBar.Location = new Point(85, 89);
            panelProgressBar.Name = "panelProgressBar";
            panelProgressBar.Size = new Size(731, 5);
            panelProgressBar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 5);
            panel1.TabIndex = 0;
            // 
            // lblSongName
            // 
            lblSongName.AutoEllipsis = true;
            lblSongName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSongName.ForeColor = Color.LightSteelBlue;
            lblSongName.Location = new Point(85, 4);
            lblSongName.Name = "lblSongName";
            lblSongName.Size = new Size(319, 30);
            lblSongName.TabIndex = 17;
            lblSongName.Text = "Wanna Be Startin' Somethin'";
            lblSongName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAlbumName
            // 
            lblAlbumName.AutoSize = true;
            lblAlbumName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlbumName.ForeColor = Color.LightSteelBlue;
            lblAlbumName.Location = new Point(85, 56);
            lblAlbumName.Name = "lblAlbumName";
            lblAlbumName.Size = new Size(48, 16);
            lblAlbumName.TabIndex = 16;
            lblAlbumName.Text = "Thriller";
            // 
            // lblArtistName
            // 
            lblArtistName.AutoSize = true;
            lblArtistName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArtistName.ForeColor = Color.LightSteelBlue;
            lblArtistName.Location = new Point(85, 34);
            lblArtistName.Name = "lblArtistName";
            lblArtistName.Size = new Size(108, 16);
            lblArtistName.TabIndex = 15;
            lblArtistName.Text = "Michael Jackson";
            // 
            // labelTimerRight
            // 
            labelTimerRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTimerRight.BackColor = Color.FromArgb(10, 25, 45);
            labelTimerRight.Font = new Font("Microsoft Sans Serif", 8.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTimerRight.ForeColor = SystemColors.ButtonHighlight;
            labelTimerRight.Location = new Point(842, 83);
            labelTimerRight.Name = "labelTimerRight";
            labelTimerRight.Size = new Size(47, 15);
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
            labelTimerLeft.Location = new Point(12, 83);
            labelTimerLeft.Name = "labelTimerLeft";
            labelTimerLeft.Size = new Size(47, 15);
            labelTimerLeft.TabIndex = 12;
            labelTimerLeft.Text = "0:00:00";
            labelTimerLeft.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSteelBlue;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 67);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnRepeat
            // 
            btnRepeat.BackColor = Color.Transparent;
            btnRepeat.BackgroundImage = (Image)resources.GetObject("btnRepeat.BackgroundImage");
            btnRepeat.BackgroundImageLayout = ImageLayout.Stretch;
            btnRepeat.FlatAppearance.BorderSize = 0;
            btnRepeat.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRepeat.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRepeat.FlatStyle = FlatStyle.Flat;
            btnRepeat.Font = new Font("Microsoft Sans Serif", 6F);
            btnRepeat.ForeColor = Color.Red;
            btnRepeat.Location = new Point(554, 25);
            btnRepeat.Name = "btnRepeat";
            btnRepeat.Padding = new Padding(10, 0, 0, 0);
            btnRepeat.Size = new Size(25, 25);
            btnRepeat.TabIndex = 9;
            btnRepeat.TabStop = false;
            btnRepeat.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRepeat.UseVisualStyleBackColor = false;
            btnRepeat.Click += btnRepeat_Click;
            // 
            // btnPlayOrPause
            // 
            btnPlayOrPause.BackColor = Color.FromArgb(10, 25, 45);
            btnPlayOrPause.BackgroundImage = (Image)resources.GetObject("btnPlayOrPause.BackgroundImage");
            btnPlayOrPause.BackgroundImageLayout = ImageLayout.Zoom;
            btnPlayOrPause.FlatAppearance.BorderSize = 0;
            btnPlayOrPause.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPlayOrPause.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPlayOrPause.FlatStyle = FlatStyle.Flat;
            btnPlayOrPause.Font = new Font("Microsoft Sans Serif", 6F);
            btnPlayOrPause.ForeColor = Color.Red;
            btnPlayOrPause.Location = new Point(472, 15);
            btnPlayOrPause.Name = "btnPlayOrPause";
            btnPlayOrPause.Padding = new Padding(10, 0, 0, 0);
            btnPlayOrPause.Size = new Size(45, 45);
            btnPlayOrPause.TabIndex = 5;
            btnPlayOrPause.UseVisualStyleBackColor = false;
            btnPlayOrPause.Click += btnPlayOrPause_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Transparent;
            btnNext.BackgroundImage = (Image)resources.GetObject("btnNext.BackgroundImage");
            btnNext.BackgroundImageLayout = ImageLayout.Stretch;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Microsoft Sans Serif", 6F);
            btnNext.ForeColor = Color.Red;
            btnNext.Location = new Point(523, 25);
            btnNext.Name = "btnNext";
            btnNext.Padding = new Padding(10, 0, 0, 0);
            btnNext.Size = new Size(25, 25);
            btnNext.TabIndex = 6;
            btnNext.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.Transparent;
            btnPrevious.BackgroundImage = (Image)resources.GetObject("btnPrevious.BackgroundImage");
            btnPrevious.BackgroundImageLayout = ImageLayout.Stretch;
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Microsoft Sans Serif", 6F);
            btnPrevious.ForeColor = Color.Red;
            btnPrevious.Location = new Point(441, 25);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Padding = new Padding(10, 0, 0, 0);
            btnPrevious.Size = new Size(25, 25);
            btnPrevious.TabIndex = 7;
            btnPrevious.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnShuffle
            // 
            btnShuffle.BackColor = Color.Transparent;
            btnShuffle.BackgroundImage = (Image)resources.GetObject("btnShuffle.BackgroundImage");
            btnShuffle.BackgroundImageLayout = ImageLayout.Stretch;
            btnShuffle.FlatAppearance.BorderSize = 0;
            btnShuffle.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnShuffle.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnShuffle.FlatStyle = FlatStyle.Flat;
            btnShuffle.Font = new Font("Microsoft Sans Serif", 6F);
            btnShuffle.ForeColor = Color.Red;
            btnShuffle.Location = new Point(410, 25);
            btnShuffle.Name = "btnShuffle";
            btnShuffle.Padding = new Padding(10, 0, 0, 0);
            btnShuffle.Size = new Size(25, 25);
            btnShuffle.TabIndex = 8;
            btnShuffle.TextImageRelation = TextImageRelation.ImageAboveText;
            btnShuffle.UseVisualStyleBackColor = false;
            btnShuffle.Click += btnShuffle_Click;
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
            panelSideMenu.Size = new Size(280, 450);
            panelSideMenu.TabIndex = 1;
            // 
            // btnAbout
            // 
            btnAbout.Dock = DockStyle.Top;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Microsoft Sans Serif", 9.900001F);
            btnAbout.ForeColor = Color.LightSteelBlue;
            btnAbout.Image = (Image)resources.GetObject("btnAbout.Image");
            btnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbout.Location = new Point(0, 398);
            btnAbout.Name = "btnAbout";
            btnAbout.Padding = new Padding(10, 0, 0, 0);
            btnAbout.Size = new Size(280, 40);
            btnAbout.TabIndex = 7;
            btnAbout.Text = "         About";
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
            btnSettings.ForeColor = Color.LightSteelBlue;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 358);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(10, 0, 0, 0);
            btnSettings.Size = new Size(280, 40);
            btnSettings.TabIndex = 6;
            btnSettings.Text = "         Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // panelPlaylistSubMenu
            // 
            panelPlaylistSubMenu.BackColor = Color.FromArgb(15, 15, 15);
            panelPlaylistSubMenu.Controls.Add(btnAdd);
            panelPlaylistSubMenu.Dock = DockStyle.Top;
            panelPlaylistSubMenu.Location = new Point(0, 314);
            panelPlaylistSubMenu.Name = "panelPlaylistSubMenu";
            panelPlaylistSubMenu.Size = new Size(280, 44);
            panelPlaylistSubMenu.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Top;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 9.900001F);
            btnAdd.ForeColor = Color.LightSteelBlue;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(40, 0, 0, 0);
            btnAdd.Size = new Size(280, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "         Add";
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
            btnPlaylist.ForeColor = Color.LightSteelBlue;
            btnPlaylist.Image = (Image)resources.GetObject("btnPlaylist.Image");
            btnPlaylist.ImageAlign = ContentAlignment.MiddleLeft;
            btnPlaylist.Location = new Point(0, 274);
            btnPlaylist.Name = "btnPlaylist";
            btnPlaylist.Padding = new Padding(10, 0, 0, 0);
            btnPlaylist.Size = new Size(280, 40);
            btnPlaylist.TabIndex = 4;
            btnPlaylist.Text = "         Playlists";
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
            panelMusicSubMenu.Location = new Point(0, 147);
            panelMusicSubMenu.Name = "panelMusicSubMenu";
            panelMusicSubMenu.Size = new Size(280, 127);
            panelMusicSubMenu.TabIndex = 3;
            // 
            // btnGenre
            // 
            btnGenre.Dock = DockStyle.Top;
            btnGenre.FlatAppearance.BorderSize = 0;
            btnGenre.FlatStyle = FlatStyle.Flat;
            btnGenre.Font = new Font("Microsoft Sans Serif", 9.900001F);
            btnGenre.ForeColor = Color.LightSteelBlue;
            btnGenre.Image = (Image)resources.GetObject("btnGenre.Image");
            btnGenre.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenre.Location = new Point(0, 80);
            btnGenre.Name = "btnGenre";
            btnGenre.Padding = new Padding(40, 0, 0, 0);
            btnGenre.Size = new Size(280, 40);
            btnGenre.TabIndex = 5;
            btnGenre.Text = "         Genre";
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
            btnArtist.ForeColor = Color.LightSteelBlue;
            btnArtist.Image = (Image)resources.GetObject("btnArtist.Image");
            btnArtist.ImageAlign = ContentAlignment.MiddleLeft;
            btnArtist.Location = new Point(0, 40);
            btnArtist.Name = "btnArtist";
            btnArtist.Padding = new Padding(40, 0, 0, 0);
            btnArtist.Size = new Size(280, 40);
            btnArtist.TabIndex = 4;
            btnArtist.Text = "         Artists";
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
            btnAlbum.ForeColor = Color.LightSteelBlue;
            btnAlbum.Image = (Image)resources.GetObject("btnAlbum.Image");
            btnAlbum.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlbum.Location = new Point(0, 0);
            btnAlbum.Name = "btnAlbum";
            btnAlbum.Padding = new Padding(40, 0, 0, 0);
            btnAlbum.Size = new Size(280, 40);
            btnAlbum.TabIndex = 3;
            btnAlbum.Text = "         Albums";
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
            btnMusic.ForeColor = Color.LightSteelBlue;
            btnMusic.Image = (Image)resources.GetObject("btnMusic.Image");
            btnMusic.ImageAlign = ContentAlignment.MiddleLeft;
            btnMusic.Location = new Point(0, 107);
            btnMusic.Name = "btnMusic";
            btnMusic.Padding = new Padding(10, 0, 0, 0);
            btnMusic.Size = new Size(280, 40);
            btnMusic.TabIndex = 2;
            btnMusic.Text = "         Music";
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
            btnHome.ForeColor = Color.LightSteelBlue;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 67);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(10, 0, 0, 0);
            btnHome.Size = new Size(280, 40);
            btnHome.TabIndex = 1;
            btnHome.Text = "         Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.DarkKhaki;
            panelLogo.Controls.Add(pictureBoxLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(280, 67);
            panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImage = (Image)resources.GetObject("pictureBoxLogo.BackgroundImage");
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Dock = DockStyle.Fill;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(280, 67);
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = Color.FromArgb(15, 15, 15);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(280, 0);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(621, 450);
            panelMainContent.TabIndex = 2;
            // 
            // AstroPlayMain
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 556);
            Controls.Add(panelMainContent);
            Controls.Add(panelSideMenu);
            Controls.Add(panelPlayerControls);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "AstroPlayMain";
            Text = "Form1";
            panelPlayerControls.ResumeLayout(false);
            panelPlayerControls.PerformLayout();
            panelProgressBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelSideMenu.ResumeLayout(false);
            panelPlaylistSubMenu.ResumeLayout(false);
            panelMusicSubMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
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
        private Button btnShuffle;
        private PictureBox pictureBox1;
        private Label labelTimerLeft;
        private Label labelTimerRight;
        private Label lblArtistName;
        private Label lblAlbumName;
        private Label lblSongName;
        private Panel panelProgressBar;
        private Panel panel1;
        private Button btnRepeat;
        private PictureBox pictureBoxLogo;
    }
}