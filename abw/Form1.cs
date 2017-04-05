using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace abw
{
    public partial class Form1 : Form
    {
        XmlDocument document;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Mark_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Items.Clear();
            switch(Mark.SelectedIndex)
            {
                case 0:
                    Model.Items.Add("A3");
                    Model.Items.Add("A4");
                    Model.Items.Add("A6");
                    Model.Items.Add("A7");
                    Model.Items.Add("A8");
                    break;
                case 1: 
                    Model.Items.Add("3 series");
                    Model.Items.Add("5 series");
                    Model.Items.Add("7 series");
                    Model.Items.Add("X3");
                    Model.Items.Add("X5");
                    break;
                case 2:
                    Model.Items.Add("300C");
                    Model.Items.Add("Crossfire");
                    Model.Items.Add("Intrepid");
                    Model.Items.Add("Neon");
                    Model.Items.Add("Sebring");
                    break;
                case 3:
                    Model.Items.Add("Caliber");
                    Model.Items.Add("Dakota");
                    Model.Items.Add("Magnum");
                    Model.Items.Add("Ram");
                    Model.Items.Add("Viper");
                    break;
                case 4:
                    Model.Items.Add("500");
                    Model.Items.Add("Albea");
                    Model.Items.Add("Coupe");
                    Model.Items.Add("Stilo");
                    Model.Items.Add("Palio");
                    break;                    
            }
            Model.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mark.Items.Add("Audi");
            Mark.Items.Add("BMW");
            Mark.Items.Add("Chrysler");
            Mark.Items.Add("Dodge");
            Mark.Items.Add("Fiat");
            Mark.SelectedIndex = 0;

            document = new XmlDocument();
            document.Load("../../libCars.xml");

            XmlNodeList xmlNodeList1 = document.SelectNodes("/cars/Mark/name");
            foreach(XmlNode node in xmlNodeList1)
            {
                Mark2.Items.Add(node.InnerText);
            }
            Mark2.SelectedIndex = 0;
        }

        private void Mark2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model2.Items.Clear();
            string path = "/cars/Mark[name='" + Mark2.SelectedItem.ToString() + "']/models/model";
            XmlNodeList xmlNodeList2 = document.SelectNodes(path);
            foreach (XmlNode node in xmlNodeList2)
            {
               Model2.Items.Add(node.InnerText);
            }
            Model2.SelectedIndex = 0;
        }
    }
}
