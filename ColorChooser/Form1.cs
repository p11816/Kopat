using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorChooser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RedButton.Tag = Color.Red;
            YellowButton.Tag = Color.Yellow;
            GreenButton.Tag = Color.Green;
            textBoxR.Text = CurrentColorPanel.BackColor.R.ToString();
            textBoxB.Text = CurrentColorPanel.BackColor.B.ToString();
            textBoxG.Text = CurrentColorPanel.BackColor.G.ToString();

            trackBarR.Value = Convert.ToInt32(CurrentColorPanel.BackColor.R);
            trackBarB.Value = Convert.ToInt32(CurrentColorPanel.BackColor.B);
            trackBarG.Value = Convert.ToInt32(CurrentColorPanel.BackColor.G);
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            ChangeColor((System.Drawing.Color)((Control)sender).Tag);
           // CurrentColorPanel.BackColor = Color.Red;
        }

        private void YellowButton_Click(object sender, EventArgs e)
        {
            ChangeColor((System.Drawing.Color)((Control)sender).Tag);
           // CurrentColorPanel.BackColor = Color.Yellow;

        }

        private void GreenButton_Click(object sender, EventArgs e)
        {
            ChangeColor((System.Drawing.Color)((Control)sender).Tag);
            //CurrentColorPanel.BackColor = Color.Green;
        }

        private void CurrentColorPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChangeColor(Color color1)
        {
            CurrentColorPanel.BackColor = color1;
            trackBarR.Value = color1.R;
            trackBarB.Value = color1.B;
            trackBarG.Value = color1.G;
        }

        private void EnglishButton_Click(object sender, EventArgs e)
        {
            RedButton.Text = "Red";
            YellowButton.Text = "Yellow";
            GreenButton.Text = "Green";

        }

        private void RussianButton_Click(object sender, EventArgs e)
        {
            RedButton.Text = "Красный";
            YellowButton.Text = "Желтый";
            GreenButton.Text = "Зеленый";
        }

        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            ChooseColorLux();
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            ChooseColorLux();
        }

        private void trackBarG_Scroll(object sender, EventArgs e)
        {
            ChooseColorLux();
        }

        private void ChooseColorLux()
        {
            CurrentColorPanel.BackColor = Color.FromArgb(trackBarR.Value, trackBarB.Value, trackBarG.Value);
            textBoxR.Text = trackBarR.Value.ToString();
            textBoxB.Text = trackBarB.Value.ToString();
            textBoxG.Text = trackBarG.Value.ToString();
        }

        private void textBoxR_TextChanged(object sender, EventArgs e)
        {
            //допилить изменение ползунка и цвета
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxG_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
