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
        // This holds a reference to the button that is currently "active" (e.g. highlighted)
        private Button currentButton;

        public AstroPlayMain()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        private void CustomizeDesign()
        {
            panelMusicSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
        }
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
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        // Highlights the newly clicked button and resets the previous one
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                // If the clicked button is different from the currently active one
                if (currentButton != (Button)senderBtn)
                {
                    // Reset the appearance of the previously active button
                    DisableButton();

                    // Set the new current button
                    currentButton = (Button)senderBtn;

                    // Change its appearance to show it's active
                    currentButton.BackColor = Color.FromArgb(0, 122, 204); // A nice blue
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font(currentButton.Font, FontStyle.Bold); // Optional: bold font
                }
            }
        }

        // Resets all top-level buttons in the side menu to default style
        private void DisableButton()
        {
            // Loop through each control inside the side menu panel
            foreach (Control previousBtn in panelSideMenu.Controls)
            {
                // Only apply this to buttons, not panels
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Black;         // Default background
                    previousBtn.ForeColor = Color.White;         // Default text color
                    previousBtn.Font = new Font(previousBtn.Font, FontStyle.Regular); // Unbold
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ShowSubMenu(panelMusicSubMenu);
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            //..
            HideSubMenu();
        }

        private void btnArtist_Click(object sender, EventArgs e)
        {
            //..
            HideSubMenu();
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            //..
            HideSubMenu();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ShowSubMenu(panelPlaylistSubMenu);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Code to add a new playlist
            HideSubMenu();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private Form activeForm = null;

        private void OpenChildForm(Form ChildForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = ChildForm;
            activeForm.TopLevel = false;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            activeForm.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(ChildForm);
            panelMainContent.Tag = ChildForm;
            activeForm.BringToFront();
            activeForm.Show();
        }
    }
}