using System;
using System.Drawing;
using System.Windows.Forms;

namespace Color_Selector
{
    public partial class ColorSelectorMain : Form
    {
        public ColorSelectorMain()
        {
            InitializeComponent();


            trackRed.Maximum = 255;
            trackRed.Minimum = 0;
            trackRed.TickFrequency = 5;
            trackRed.TickStyle = TickStyle.BottomRight;
            trackRed.Scroll += new EventHandler(trackBar_Scroll);

            trackGreen.Maximum = 255;
            trackGreen.Minimum = 0;
            trackGreen.TickFrequency = 5;
            trackGreen.TickStyle = TickStyle.BottomRight;
            trackGreen.Scroll += new EventHandler(trackBar_Scroll);

            trackBlue.Maximum = 255;
            trackBlue.Minimum = 0;
            trackBlue.TickFrequency = 5;
            trackBlue.TickStyle = TickStyle.BottomRight;
            trackBlue.Scroll += new EventHandler(trackBar_Scroll);
        }
     

        private void trackBar_Scroll(object sender, System.EventArgs e)
        {
            showValues(trackRed.Value, trackGreen.Value, trackBlue.Value);
            selectedColor(trackRed.Value, trackGreen.Value, trackBlue.Value);
        }

        private void showValues(int red, int green, int blue)
        {
            lblRed.Text = "" + trackRed.Value + " = " + trackRed.Value.ToString("X");
            lblGreen.Text = "" + trackGreen.Value + " = " + trackGreen.Value.ToString("X");
            lblBlue.Text = "" + trackBlue.Value + " = " + trackBlue.Value.ToString("X");
        }

        private void selectedColor(int red, int green, int blue)
       {
            BackColor = Color.FromArgb(trackRed.Value, trackGreen.Value, trackBlue.Value);
        }
    }
}
