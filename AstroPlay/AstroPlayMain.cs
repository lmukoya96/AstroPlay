using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstroPlay
{
    public partial class AstroPlayMain : Form
    {
        private Button currentButton;   // Stores the button that is currently selected (highlighted in blue)
        private Form activeForm = null; // Holds a reference to the currently loaded form inside the main content panel
        private System.Windows.Forms.Timer playbackTimer;
        private bool isPlaying = false;

        public AstroPlayMain()
        {
            InitializeComponent();         // Standard WinForms setup method that initializes UI components
            CustomizeDesign();            // Hides all submenus initially
            ApplyHoverEffect();           // Adds hover behavior to all buttons
            panelPlayerControls.SizeChanged += panelPlayerControls_SizeChanged;
            playbackTimer = new System.Windows.Forms.Timer();
            playbackTimer.Interval = 100; // 100 ms
            playbackTimer.Tick += PlaybackTimer_Tick;


        }

        // Hides all submenu panels by default when the app launches
        private void CustomizeDesign()
        {
            panelMusicSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
        }

        // Ensures all submenus are hidden
        private void HideSubMenu()
        {
            if (panelMusicSubMenu.Visible == true)
            {
                panelMusicSubMenu.Visible = false;
            }
            if (panelPlaylistSubMenu.Visible == true)
            {
                panelPlaylistSubMenu.Visible = false;
            }
        }

        // Displays the submenu passed as argument and hides the rest
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();           // Hide any other open submenus
                subMenu.Visible = true; // Show the one that was clicked
            }
            else
            {
                subMenu.Visible = false; // Clicking again hides it
            }
        }

        // Highlights the newly clicked button and resets the previous one
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                // Only change state if a new button is clicked
                if (currentButton != (Button)senderBtn)
                {
                    DisableButton(); // Reset appearance of all buttons
                    currentButton = (Button)senderBtn;

                    // Style the newly selected button
                    currentButton.BackColor = Color.FromArgb(0, 122, 204); // Bright blue background
                    currentButton.ForeColor = Color.White;                // White text
                    currentButton.Font = new Font(currentButton.Font, FontStyle.Bold); // Bold font
                }
            }
        }

        // Resets all side menu buttons to their default appearance
        private void DisableButton()
        {
            foreach (Control previousBtn in panelSideMenu.Controls)
            {
                // Only affect Button controls, not panels or labels
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Black;                     // Reset background color
                    previousBtn.ForeColor = Color.White;                     // Reset text color
                    previousBtn.Font = new Font(previousBtn.Font, FontStyle.Regular); // Remove bold
                }
            }
        }

        // ============ BUTTON CLICK HANDLERS ============

        // HOME
        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            // You can load a child form here with OpenChildForm(new HomeForm());
            HideSubMenu();
        }

        // MUSIC
        private void btnMusic_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ShowSubMenu(panelMusicSubMenu); // Toggle the music submenu
        }

        // ALBUM (submenu under Music)
        private void btnAlbum_Click(object sender, EventArgs e)
        {
            // Load album view in future
            HideSubMenu(); // Hide the submenu after selection
        }

        // ARTIST (submenu under Music)
        private void btnArtist_Click(object sender, EventArgs e)
        {
            // Load artist view
            HideSubMenu();
        }

        // GENRE (submenu under Music)
        private void btnGenre_Click(object sender, EventArgs e)
        {
            // Load genre view
            HideSubMenu();
        }

        // PLAYLIST
        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ShowSubMenu(panelPlaylistSubMenu); // Toggle playlist submenu
        }

        // ADD NEW PLAYLIST (submenu under Playlist)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Code to create a new playlist
            HideSubMenu(); // Hide after adding
        }

        // SETTINGS
        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            // Future: load a settings form here
            HideSubMenu();
        }

        // ABOUT
        private void btnAbout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            // Future: show about info here
            HideSubMenu();
        }

        // ============ HOVER EFFECTS ============

        // Adds mouse enter/leave events to a button to simulate hover
        private void HoverEffect(Button button)
        {
            // When mouse hovers over the button
            button.MouseEnter += (s, e) => button.BackColor = Color.FromArgb(0, 122, 204);

            // When mouse leaves the button
            button.MouseLeave += (s, e) =>
            {
                // If it's not the currently selected (active) button, reset it
                if (button != currentButton)
                    button.BackColor = Color.Black;
            };
        }

        // Apply the hover effect to every interactive button
        private void ApplyHoverEffect()
        {
            HoverEffect(btnHome);
            HoverEffect(btnMusic);
            HoverEffect(btnAlbum);
            HoverEffect(btnArtist);
            HoverEffect(btnGenre);
            HoverEffect(btnPlaylist);
            HoverEffect(btnAdd);
            HoverEffect(btnSettings);
            HoverEffect(btnAbout);
        }

        // This method dynamically arranges the playback control buttons (Prev, Play, Next, etc.)
        // to always stay horizontally centered and vertically near the top inside panelPlayerControls.
        // It runs whenever panelPlayerControls is resized.
        private void panelPlayerControls_SizeChanged(object? sender, EventArgs e)
        {
            // Create an array of buttons in the order you want them to appear
            Button[] buttons = { btnShuffle, btnPrevious, btnPlayOrPause, btnNext, btnRepeat };

            // Top margin for each button individually
            var topMargins = new Dictionary<Button, int>
            {
                { btnShuffle, 25 },
                { btnPrevious, 25 },
                { btnPlayOrPause, 7 },  // It's larger, so smaller top margin keeps it visually centered
                { btnNext, 25 },
                { btnRepeat, 25 }
            };

            int spacing = 10; // Space in pixels between each button

            // Calculate the total width occupied by all buttons (excluding spacing)
            int totalWidth = buttons.Sum(btn => btn.Width) + spacing * (buttons.Length - 1);

            // Calculate starting X position to center the group
            int startX = (panelPlayerControls.Width - totalWidth) / 2;

            foreach (Button btn in buttons)
            {
                btn.Left = startX;
                btn.Top = topMargins.ContainsKey(btn) ? topMargins[btn] : 15; // fallback to 15 if not defined
                startX += btn.Width + spacing;
            }

            // === LABEL RESIZING CODE ===
            int rightMargin = 20;
            int maxLabelWidth = btnShuffle.Left - lblSongName.Left - rightMargin;
            lblSongName.Width = maxLabelWidth > 0 ? maxLabelWidth : 0;
        }

        // ============ LOAD CHILD FORMS ============

        // Loads a form into the main content panel, closing the previous one if necessary
        private void OpenChildForm(Form ChildForm)
        {
            if (activeForm != null)
            {
                activeForm.Close(); // Close previously loaded form
            }

            activeForm = ChildForm;
            activeForm.TopLevel = false; // Makes it a control inside this form
            activeForm.FormBorderStyle = FormBorderStyle.None; // Removes window borders
            activeForm.Dock = DockStyle.Fill; // Make it fill the panel

            panelMainContent.Controls.Add(ChildForm); // Add to main panel
            panelMainContent.Tag = ChildForm; // Optional tracking
            activeForm.BringToFront(); // Bring to top
            activeForm.Show(); // Display it
        }

        private void btnPlayOrPause_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                btnPlayOrPause.BackgroundImage = Image.FromFile("Icons/play.png"); // play icon
                isPlaying = false;
                playbackTimer.Stop(); // This stops the timer when Pause is clicked
                                      // Pause your audio playback here
            }
            else
            {
                btnPlayOrPause.BackgroundImage = Image.FromFile("Icons/pause.png"); // pause icon
                isPlaying = true;
                playbackTimer.Start(); // This starts the timer when Play is clicked
                                       // Start or resume your audio playback here
            }
        }

        private void PlaybackTimer_Tick(object? sender, EventArgs e)
        {
            // Prevent going above the maximum
            if (aP_ProgressBar1.Value < aP_ProgressBar1.Maximum)
            {
                aP_ProgressBar1.Value += 1;
            }
            else
            {
                playbackTimer.Stop(); // Optional: stop when full
            }
        }
    }
}