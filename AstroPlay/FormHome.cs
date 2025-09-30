using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AstroPlay
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();

            // Ensure picture fits nicely
            pictureBoxHome.SizeMode = PictureBoxSizeMode.Zoom;

            MakeCircular(pictureBoxHome);

            // Re-apply when controls resize (handles layout changes)
            pictureBoxHome.Resize += (s, e) => MakeCircular(pictureBoxHome);
        }

        private void MakeCircular(PictureBox pictureBox) // Makes a PictureBox circular. If the PictureBox isn't square, the circle will be centered.
        {
            if (pictureBox.Width <= 0 || pictureBox.Height <= 0) return;

            int diameter = Math.Min(pictureBox.Width, pictureBox.Height);
            int offsetX = (pictureBox.Width - diameter) / 2;
            int offsetY = (pictureBox.Height - diameter) / 2;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(offsetX, offsetY, diameter, diameter);
                pictureBox.Region = new Region(path);
            }
        }
    }
}
