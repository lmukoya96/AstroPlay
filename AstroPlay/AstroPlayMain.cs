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
        private enum RepeatMode
        {
            None,
            RepeatAll,
            RepeatOne
        }

        private Button currentButton;   // Stores the button that is currently selected (highlighted in blue)
        private Form activeForm = null; // Holds a reference to the currently loaded form inside the main content panel
        private System.Windows.Forms.Timer playbackTimer;
        private RepeatMode repeatMode = RepeatMode.None;
        private bool isPlaying = false;
        private bool isShuffled = false;
        private bool isDragging = false;
        private double simulatedProgressRatio = 0.0; // Represents playback progress (0.0 to 1.0)
        TimeSpan simulatedTotalTime = TimeSpan.FromMinutes(3); // Example: 3 minutes
        TimeSpan simulatedCurrentTime = TimeSpan.Zero;


        public AstroPlayMain()
        {
            InitializeComponent();         // Standard WinForms setup method that initializes UI components
            CustomizeDesign();            // Hides all submenus initially
            ApplyHoverEffect();           // Adds hover behavior to all buttons
            panelPlayerControls.SizeChanged += panelPlayerControls_SizeChanged;
            panelProgressBar.MouseDown += panelProgressBar_MouseDown;
            panelProgressBar.MouseMove += panelProgressBar_MouseMove;
            panelProgressBar.MouseUp += panelProgressBar_MouseUp;
            panelProgressBar.Paint += panelProgressBar_Paint;
            MakeButtonUnfocusable(btnRepeat);
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

        private void panelProgressBar_MouseDown(object? sender, MouseEventArgs e)// Triggered when the user presses down the mouse on the progress bar
        {
            isDragging = true; // Start dragging

            float ratio = (float)e.X / panelProgressBar.Width;
            simulatedProgressRatio = Math.Clamp(ratio, 0f, 1f);
            panelProgressBar.Invalidate(); // Optional visual feedback
        }

        private void panelProgressBar_MouseUp(object? sender, MouseEventArgs e) // Triggered when the user releases the mouse button
        {
            if (!isDragging) return;

            isDragging = false;

            float ratio = (float)e.X / panelProgressBar.Width;
            simulatedProgressRatio = Math.Clamp(ratio, 0f, 1f);

            simulatedCurrentTime = TimeSpan.FromSeconds(simulatedTotalTime.TotalSeconds * simulatedProgressRatio);
            panelProgressBar.Invalidate();
        }

        private void panelProgressBar_MouseMove(object? sender, MouseEventArgs e) // Triggered when the user moves the mouse while holding it down
        {
            if (isDragging)
            {
                float ratio = (float)e.X / panelProgressBar.Width;
                simulatedProgressRatio = Math.Clamp(ratio, 0f, 1f);
                panelProgressBar.Invalidate(); // Show live dragging effect
            }
        }

        private void panelProgressBar_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Draw the base bar (e.g. grey background)
            using (SolidBrush backgroundBrush = new SolidBrush(Color.LightSteelBlue))
            {
                g.FillRectangle(backgroundBrush, 0, 0, panelProgressBar.Width, panelProgressBar.Height);
            }

            // Draw the progress part (e.g. blue foreground)
            int progressWidth = (int)(panelProgressBar.Width * simulatedProgressRatio);

            using (SolidBrush progressBrush = new SolidBrush(Color.RoyalBlue))
            {
                g.FillRectangle(progressBrush, 0, 0, progressWidth, panelProgressBar.Height);
            }
        }

        /*
        // Event handler to allow the user to seek through the audio by clicking on the progress bar
        private void panelProgressBar_MouseDown(object sender, MouseEventArgs e)
        {
            // Safety check: if the audio reader or output device isn't initialized, do nothing
            if (audioFileReader == null || outputDevice == null)
                return;

            // Calculate the ratio of the mouse click position relative to the total width of the progress bar
            float ratio = (float)e.X / panelProgressBar.Width;

            // Clamp the ratio between 0 and 1 to avoid out-of-bounds errors (e.g., clicking slightly outside the bar)
            ratio = Math.Clamp(ratio, 0f, 1f);

            // Calculate the new playback position based on the ratio and set the audio's current time
            audioFileReader.CurrentTime = TimeSpan.FromSeconds(audioFileReader.TotalTime.TotalSeconds * ratio);

            // Optional: update the visual progress bar immediately after seeking (if such a method exists in your code)
            UpdateProgressBar();
        }
        
        private void UpdateProgressBar()
        {
            if (audioFileReader == null || audioFileReader.TotalTime.TotalSeconds == 0) return;

            float progressRatio = (float)(audioFileReader.CurrentTime.TotalSeconds / audioFileReader.TotalTime.TotalSeconds);
            panelProgressFill.Width = (int)(panelProgressBar.Width * progressRatio);
        }
        */

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
        private void MakeButtonUnfocusable(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn.TabStop = false;
            //btn.SetStyle(ControlStyles.Selectable, false); // Optional, for advanced scenarios
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
                { btnPlayOrPause, 15 },  // It's larger, so smaller top margin keeps it visually centered
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
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            if (isShuffled)
            {
                btnShuffle.BackgroundImage = Image.FromFile("Icons/shuffle.png"); // shuffle icon
                isShuffled = false;
                // Add logic to disable shuffle mode here
            }
            else
            {
                btnShuffle.BackgroundImage = Image.FromFile("Icons/shuffled.png"); // shuffled icon
                isShuffled = true;
                // Add logic to disable shuffle mode here
            }
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            // Cycle the mode
            repeatMode = (RepeatMode)(((int)repeatMode + 1) % 3);

            if (repeatMode == RepeatMode.None)
            {
                btnRepeat.BackgroundImage = Image.FromFile("Icons/repeat_off.png");
            }
            else if (repeatMode == RepeatMode.RepeatAll)
            {
                btnRepeat.BackgroundImage = Image.FromFile("Icons/repeat_all.png");
            }
            else if (repeatMode == RepeatMode.RepeatOne)
            {
                btnRepeat.BackgroundImage = Image.FromFile("Icons/repeat_one.png");
            }

            this.ActiveControl = null;

            lblSongName.Focus(); //

            if (repeatMode == RepeatMode.RepeatOne)
            {
                // replay the same track
            }
            else if (repeatMode == RepeatMode.RepeatAll)
            {
                // move to next track, loop back to first if at end
            }
            else
            {
                // stop playback
            }
        }

        private void PlaybackTimer_Tick(object? sender, EventArgs e)
        {
            if (!isPlaying || isDragging) return; // Don't update while dragging

            if (simulatedCurrentTime < simulatedTotalTime)
            {
                simulatedCurrentTime = simulatedCurrentTime.Add(TimeSpan.FromSeconds(1));
                simulatedProgressRatio = simulatedCurrentTime.TotalSeconds / simulatedTotalTime.TotalSeconds;
                panelProgressBar.Invalidate();
            }
            else
            {
                playbackTimer.Stop();
                isPlaying = false;
                btnPlayOrPause.BackgroundImage = Image.FromFile("Icons/play.png");

                // Reset visual and simulated time
                simulatedProgressRatio = 0.0;
                simulatedCurrentTime = TimeSpan.Zero;
                panelProgressBar.Invalidate();
            }
        }
    }
}