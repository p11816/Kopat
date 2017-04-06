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

namespace ListControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //comboBox1.Items.Clear();

            treeView1.Nodes.Add("parent");
            treeView1.Nodes[0].Nodes.Add("child");
            treeView1.Nodes[0].Nodes.Add("child2");
            ///       parent   child2
            treeView1.Nodes[0].Nodes[1].Nodes.Add("grandchild21");

            treeView1.ExpandAll();

            treeView1.Nodes[0].Nodes[1].Collapse();


            listBox1.Items.Add("One");
            listBox1.Items.Add("Two");

            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");

            comboBox1.SelectedIndex = 2;










            XmlDocument doc = new XmlDocument();
            doc.Load("../../cars.xml");
            string zzz = "";

            /* 
            var brands = doc.GetElementsByTagName("brand");
            foreach (XmlNode brand in brands)
            {
                if (brand.HasChildNodes) {
                    foreach (XmlNode child in brand.ChildNodes)
                    {
                        if (child.Name == "name")
                        {
                            zzz += child.InnerText;
                        }
                    }
                }
            }
            */
            var res = doc.SelectNodes("/cars/brand/name");
            foreach (XmlNode node in res)
            {
                zzz += node.InnerText;
            }

            MessageBox.Show(zzz);


            var a = doc.SelectNodes("/cars/brand[name='Buick']/models/model");
            zzz = "";
            foreach (XmlNode node in a)
            {
                zzz += node.InnerText;
            }

            MessageBox.Show(zzz);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            MessageBox.Show((string)listBox1.SelectedItem);
        }
    }
}
