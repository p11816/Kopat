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
        char act;
        double buffer;
        bool firstAction;

        public Form1()
        {
            InitializeComponent();
            act = ' ';
            buffer = 0;
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

        private void FillBuffer(string str1)
        {
            buffer = Convert.ToDouble(str1);
            Display.Text = "0";
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {
            //дописать корректный ввод нуля после запятой
            //дописать использование запятой
            if (Display.Text == "")
            {
                Display.Text = "0";
            }
            Display.Text = (Convert.ToDouble(Display.Text)).ToString();
            Display.SelectionStart = Display.Text.Length;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            act = '+';
            FillBuffer(Display.Text);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            act = '-';
            FillBuffer(Display.Text);
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            act = '*';
            FillBuffer(Display.Text);
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            act = '/';
            FillBuffer(Display.Text);
        }
        
        private void buttonSQRT_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(Display.Text);
            Display.Text = Math.Round(Math.Sqrt(temp), 5).ToString();
        }


        //backspace button
        private void buttonSpace_Click(object sender, EventArgs e)
        {
            Display.Text = (Convert.ToInt32(Display.Text) / 10).ToString();
        }

        private void KeyNumberDown(object sender, KeyEventArgs e)
        {
            //Control control = (Control)sender;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            switch(act)
            {
                case '+':
                    buffer += Convert.ToDouble(Display.Text);
                    Display.Text = buffer.ToString();
                    break;
                case '-':
                    buffer -= Convert.ToDouble(Display.Text);
                    Display.Text = buffer.ToString();
                    break;
                case '/':
                    double temp = Convert.ToDouble(Display.Text);
                    if (temp != 0)
                    {
                        buffer /= temp;
                        Display.Text = buffer.ToString();
                    }          
                    else
                    {
                        MessageBox.Show("You can not divide it by zero");
                    }
                    break;
                case '*':
                    buffer *= Convert.ToDouble(Display.Text);
                    Display.Text = buffer.ToString();
                    break;
                default:
                    break;
            }
            buffer = 0;
        }



    }
}
