using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alchemy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheckSolution_Click(object sender, EventArgs e)
        {
            textBoxSolution.Text = "";
            List<string> facts = new List<string>();
            foreach(var f in checkedListBoxFacts.CheckedItems)
            {
                facts.Add(f.ToString());
            }
            foreach (var f in facts)
                textBoxSolution.Text += f + " ";
        }

        private void comboBoxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonCheckSolution.Enabled = true;
        }

        private void checkedListBoxFacts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
