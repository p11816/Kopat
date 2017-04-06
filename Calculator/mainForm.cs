using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Digit0_Click(object sender, EventArgs e)
        {
            AddDigitToDisplay('0');
        }

        private void Digit1_Click(object sender, EventArgs e)
        {
            //получили объект, пославший событие - нажатую кнопку
            var control = (Control)sender;
            //получили тэг кнопки
            var tag = (String)control.Tag;
            //взяли первую букву и передали в метод
            AddDigitToDisplay(tag[0]);
            //строчка ниже почти аналогична выше трем
            //AddDigitToDisplay(Convert.ToChar(((Control)sender).Tag));
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            Convert.ToInt32(Display.ToString());
        }

        private void EquallyButton_Click(object sender, EventArgs e)
        {

        }
        private void Display_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDigitToDisplay(char userDigit)
        {
            if (Display.Text.Length < 8)
            {
                Display.Text += userDigit;
            }
        }
    }
}
