using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc10
{
    public partial class Form1 : Form
    {
        //флаг действия
        char act; //='';

        public Form1()
        {
            InitializeComponent();            
        }
              
        private void buttonNumberClick(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            char symbol = Convert.ToChar(control.Tag);
            PrintToDisplay(symbol);
        }

        private void PrintToDisplay(char symbol)
        {
            Display.Text = (Convert.ToDouble(Display.Text += symbol)).ToString();          
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {
            if (Display.Text == "")
            {
                Display.Text = "0";
            }
            Display.Text = (Convert.ToDouble(Display.Text)).ToString();
            Display.SelectionStart = Display.Text.Length;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {

        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {

        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {

        }

        private void buttonSpace_Click(object sender, EventArgs e)
        {
            Display.Text = (Convert.ToInt32(Display.Text) / 10).ToString();
        }

        private void KeyNumberDown(object sender, KeyEventArgs e)
        {
            Control control = (Control)sender;
            
            //MessageBox.Show(control.ToString());
        }

    }
}
