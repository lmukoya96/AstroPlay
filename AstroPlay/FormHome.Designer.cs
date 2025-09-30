namespace AstroPlay
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            lblWelcome = new Label();
            lblWelcomeSubtext = new Label();
            panelMain = new Panel();
            btnOpenFiles = new Button();
            lblHome = new Label();
            pictureBoxHome = new PictureBox();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(12, 45);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(597, 27);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to AstroPlay!";
            // 
            // lblWelcomeSubtext
            // 
            lblWelcomeSubtext.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblWelcomeSubtext.BackColor = Color.Transparent;
            lblWelcomeSubtext.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcomeSubtext.Location = new Point(12, 72);
            lblWelcomeSubtext.Name = "lblWelcomeSubtext";
            lblWelcomeSubtext.Size = new Size(597, 20);
            lblWelcomeSubtext.TabIndex = 1;
            lblWelcomeSubtext.Text = "Play your music, explore playlists, and rediscover favorites.";
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.BackColor = Color.Transparent;
            panelMain.Controls.Add(pictureBoxHome);
            panelMain.Controls.Add(btnOpenFiles);
            panelMain.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelMain.Location = new Point(12, 95);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(597, 343);
            panelMain.TabIndex = 2;
            // 
            // btnOpenFiles
            // 
            btnOpenFiles.BackColor = Color.WhiteSmoke;
            btnOpenFiles.FlatAppearance.BorderSize = 0;
            btnOpenFiles.FlatStyle = FlatStyle.Flat;
            btnOpenFiles.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenFiles.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpenFiles.Location = new Point(194, 3);
            btnOpenFiles.Name = "btnOpenFiles";
            btnOpenFiles.Size = new Size(108, 30);
            btnOpenFiles.TabIndex = 1;
            btnOpenFiles.Text = "Open File(s)";
            btnOpenFiles.UseVisualStyleBackColor = false;
            // 
            // lblHome
            // 
            lblHome.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHome.Location = new Point(12, 9);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(127, 36);
            lblHome.TabIndex = 3;
            lblHome.Text = "Home";
            // 
            // pictureBoxHome
            // 
            pictureBoxHome.BackColor = Color.Transparent;
            pictureBoxHome.BackgroundImage = (Image)resources.GetObject("pictureBoxHome.BackgroundImage");
            pictureBoxHome.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxHome.Location = new Point(3, 3);
            pictureBoxHome.Name = "pictureBoxHome";
            pictureBoxHome.Size = new Size(185, 185);
            pictureBoxHome.TabIndex = 12;
            pictureBoxHome.TabStop = false;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(621, 450);
            Controls.Add(lblHome);
            Controls.Add(panelMain);
            Controls.Add(lblWelcomeSubtext);
            Controls.Add(lblWelcome);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHome";
            ShowIcon = false;
            Text = "FormHome";
            WindowState = FormWindowState.Maximized;
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcome;
        private Label lblWelcomeSubtext;
        private Panel panelMain;
        private Label lblHome;
        private Button btnOpenFiles;
        private PictureBox pictureBoxHome;
    }
}