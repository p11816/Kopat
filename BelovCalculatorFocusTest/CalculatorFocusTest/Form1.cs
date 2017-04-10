using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorFocusTest
{
    public partial class Form1 : Form, ICalculatorController
    {
        List<Button> digitButtons = new List<Button>();

        private CalculatorModel model = new CalculatorModel();

        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            this.KeyPreview = true;
            digitButtons.Add(button1);
            digitButtons.Add(button2);
            for (int i = 0; i < digitButtons.Count; i++)  
            {
                digitButtons[i].Tag = i;
                digitButtons[i].Text = i.ToString();
                digitButtons[i].Click += DigitButtonClick;
            }

            // Set up binary operations
            plusBtn.Tag = CalculatorModel.Operation.Plus;
            equalsBtn.Tag = CalculatorModel.Operation.Equals;
            plusBtn.Click += binaryOperationClick;
            equalsBtn.Click += binaryOperationClick;
        }

        void binaryOperationClick(object sender, EventArgs e)
        {
            BinaryOperation((CalculatorModel.Operation)((Button)sender).Tag);
            label1.Text = model.VisibleRegister.ToString();
        }

        private void DigitButtonClick(object sender, EventArgs e)
        {
            DigitPress((int)((Button)sender).Tag);
            label1.Text = model.VisibleRegister.ToString();
        }

        

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (true) // *** я верю, что символ норм.
            {
                DigitPress(Convert.ToInt32(e.KeyChar));
            }
        }

        


        public void DigitPress(int digit)
        {
            model.DigitPressed(digit);
        }

        public void BinaryOperation(CalculatorModel.Operation op)
        {
            model.BinaryOperation(op);
        }
    }
}
