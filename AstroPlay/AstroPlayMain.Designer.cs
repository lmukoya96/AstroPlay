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
            panelPlayerControls = new Panel();
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
            panelSideMenu.SuspendLayout();
            panelPlaylistSubMenu.SuspendLayout();
            panelMusicSubMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelPlayerControls
            // 
            panelPlayerControls.BackColor = Color.FromArgb(10, 25, 45);
            panelPlayerControls.Controls.Add(btnRepeat);
            panelPlayerControls.Controls.Add(btnPlayOrPause);
            panelPlayerControls.Controls.Add(btnNext);
            panelPlayerControls.Controls.Add(btnPrevious);
            panelPlayerControls.Controls.Add(btnShuffle);
            panelPlayerControls.Dock = DockStyle.Bottom;
            panelPlayerControls.Font = new Font("Microsoft Sans Serif", 6F);
            panelPlayerControls.Location = new Point(0, 1024);
            panelPlayerControls.Name = "panelPlayerControls";
            panelPlayerControls.Size = new Size(2000, 186);
            panelPlayerControls.TabIndex = 0;
            // 
            // btnRepeat
            // 
            btnRepeat.BackColor = Color.Red;
            btnRepeat.FlatAppearance.BorderSize = 0;
            btnRepeat.FlatStyle = FlatStyle.Flat;
            btnRepeat.Font = new Font("Microsoft Sans Serif", 6F);
            btnRepeat.ForeColor = Color.White;
            btnRepeat.Location = new Point(1153, 7);
            btnRepeat.Name = "btnRepeat";
            btnRepeat.Padding = new Padding(10, 0, 0, 0);
            btnRepeat.Size = new Size(90, 90);
            btnRepeat.TabIndex = 9;
            btnRepeat.Text = "Rep";
            btnRepeat.TextAlign = ContentAlignment.MiddleLeft;
            btnRepeat.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRepeat.UseVisualStyleBackColor = false;
            // 
            // btnPlayOrPause
            // 
            btnPlayOrPause.BackColor = Color.Red;
            btnPlayOrPause.FlatAppearance.BorderSize = 0;
            btnPlayOrPause.FlatStyle = FlatStyle.Flat;
            btnPlayOrPause.Font = new Font("Microsoft Sans Serif", 6F);
            btnPlayOrPause.ForeColor = Color.White;
            btnPlayOrPause.Location = new Point(961, 7);
            btnPlayOrPause.Name = "btnPlayOrPause";
            btnPlayOrPause.Padding = new Padding(10, 0, 0, 0);
            btnPlayOrPause.Size = new Size(90, 90);
            btnPlayOrPause.TabIndex = 5;
            btnPlayOrPause.Text = "Play";
            btnPlayOrPause.TextAlign = ContentAlignment.MiddleLeft;
            btnPlayOrPause.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Red;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Microsoft Sans Serif", 6F);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(1057, 7);
            btnNext.Name = "btnNext";
            btnNext.Padding = new Padding(10, 0, 0, 0);
            btnNext.Size = new Size(90, 90);
            btnNext.TabIndex = 6;
            btnNext.Text = "Next";
            btnNext.TextAlign = ContentAlignment.MiddleLeft;
            btnNext.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.Red;
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Microsoft Sans Serif", 6F);
            btnPrevious.ForeColor = Color.White;
            btnPrevious.Location = new Point(865, 7);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Padding = new Padding(10, 0, 0, 0);
            btnPrevious.Size = new Size(90, 90);
            btnPrevious.TabIndex = 7;
            btnPrevious.Text = "Prev";
            btnPrevious.TextAlign = ContentAlignment.MiddleLeft;
            btnPrevious.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnShuffle
            // 
            btnShuffle.BackColor = Color.Red;
            btnShuffle.FlatAppearance.BorderSize = 0;
            btnShuffle.FlatStyle = FlatStyle.Flat;
            btnShuffle.Font = new Font("Microsoft Sans Serif", 6F);
            btnShuffle.ForeColor = Color.White;
            btnShuffle.Location = new Point(769, 7);
            btnShuffle.Name = "btnShuffle";
            btnShuffle.Padding = new Padding(10, 0, 0, 0);
            btnShuffle.Size = new Size(90, 90);
            btnShuffle.TabIndex = 8;
            btnShuffle.Text = "Shuf";
            btnShuffle.TextAlign = ContentAlignment.MiddleLeft;
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
            panelSideMenu.Size = new Size(560, 1024);
            panelSideMenu.TabIndex = 1;
            // 
            // btnAbout
            // 
            btnAbout.Dock = DockStyle.Top;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Microsoft Sans Serif", 9.900001F);
            btnAbout.ForeColor = Color.White;
            btnAbout.Location = new Point(0, 919);
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
            btnSettings.Location = new Point(0, 826);
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
            panelPlaylistSubMenu.Location = new Point(0, 722);
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
            btnPlaylist.Location = new Point(0, 629);
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
            panelMusicSubMenu.Location = new Point(0, 335);
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
            btnMusic.Location = new Point(0, 242);
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
            btnHome.Location = new Point(0, 149);
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
            panelLogo.Size = new Size(560, 149);
            panelLogo.TabIndex = 0;
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = Color.FromArgb(15, 15, 15);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(560, 0);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(1440, 1024);
            panelMainContent.TabIndex = 2;
            // 
            // AstroPlayMain
            // 
            AutoScaleDimensions = new SizeF(19F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2000, 1210);
            Controls.Add(panelMainContent);
            Controls.Add(panelSideMenu);
            Controls.Add(panelPlayerControls);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AstroPlayMain";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panelPlayerControls.ResumeLayout(false);
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
    }
}