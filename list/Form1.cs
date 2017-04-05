using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("One");
            listBox1.Items.Add("Two");

            treeView1.Nodes.Add("Parent1");
            treeView1.Nodes[0].Nodes.Add("Child1");
            treeView1.Nodes[0].Nodes.Add("Child2");
            treeView1.Nodes[0].Nodes.Add("Child3");
            treeView1.ExpandAll();

            treeView1.Nodes[0].Nodes[1].Nodes.Add("Vnuk2-1");
            treeView1.Nodes[0].Nodes[1].Collapse();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }
    }
}
