using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AstroPlay
{
    public enum TextPosition
    { 
        Left, 
        Right, 
        Center, 
        Sliding, 
        None
    }

    class AP_ProgressBar : ProgressBar
    {
        private Color channelColor = Color.LightSteelBlue;
        private Color sliderColor = Color.RoyalBlue;
        private int channelHeight = 6;
        private int sliderHeight = 6;
        private TextPosition showValue = TextPosition.Right;

        [Category("Appearance")] public Color ChannelColor { get => channelColor; set { channelColor = value; Invalidate(); } }
        [Category("Appearance")] public Color SliderColor { get => sliderColor; set { sliderColor = value; Invalidate(); } }
        [Category("Appearance")] public int ChannelHeight { get => channelHeight; set { channelHeight = value; Invalidate(); } }
        [Category("Appearance")] public int SliderHeight { get => sliderHeight; set { sliderHeight = value; Invalidate(); } }
        [Category("Appearance")] public TextPosition ShowValue { get => showValue; set { showValue = value; Invalidate(); } }

        public AP_ProgressBar()
        {
            SetStyle(ControlStyles.UserPaint, true);
            ForeColor = Color.White;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using var brush = new SolidBrush(Parent.BackColor);
            e.Graphics.Clear(Parent.BackColor);

            int y = (sliderHeight >= channelHeight) ?
                Height - channelHeight :
                Height - ((channelHeight + sliderHeight) / 2);
            var rect = new Rectangle(0, y, Width, channelHeight);
            using var cBrush = new SolidBrush(channelColor);
            e.Graphics.FillRectangle(cBrush, rect);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            double scale = (double)(Value - Minimum) / (Maximum - Minimum);
            int sliderWidth = (int)(Width * scale);
            int y = (sliderHeight >= channelHeight) ?
                Height - sliderHeight :
                Height - ((sliderHeight + channelHeight) / 2);

            var rect = new Rectangle(0, y, sliderWidth, sliderHeight);
            using var sBrush = new SolidBrush(sliderColor);
            e.Graphics.FillRectangle(sBrush, rect);

            if (showValue != TextPosition.None)
                DrawValueText(e.Graphics, sliderWidth);
        }

        private void DrawValueText(Graphics g, int sliderWidth)
        {
            string text = Value.ToString();
            var size = TextRenderer.MeasureText(text, Font);
            var rect = new Rectangle(0, 0, size.Width, size.Height + 2);
            StringFormat sf = new();

            switch (showValue)
            {
                case TextPosition.Left: sf.Alignment = StringAlignment.Near; break;
                case TextPosition.Right: rect.X = Width - size.Width; sf.Alignment = StringAlignment.Far; break;
                case TextPosition.Center: rect.X = (Width - size.Width) / 2; sf.Alignment = StringAlignment.Center; break;
                case TextPosition.Sliding: rect.X = sliderWidth - size.Width; sf.Alignment = StringAlignment.Center; break;
            }

            using var brush = new SolidBrush(ForeColor);
            g.DrawString(text, Font, brush, rect, sf);
        }
    }
}