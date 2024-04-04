using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_7
{
    public partial class Registeration : Form
    {
        public Registeration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 5)
            {
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
            
            
            if (!textBox2.Text.Contains("@")){
                label6.Visible = true;
            }
            else
            {
                label6.Visible = false;
            }
            
            if (!(checkBox1.Checked) || (checkBox2.Checked ) || (checkBox3.Checked)) {
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
            }
            
            if (!((textBox1.Text.Length < 5) || !textBox2.Text.Contains("@") || !(checkBox1.Checked) || (checkBox2.Checked) || (checkBox3.Checked)))
            {
                label8.Visible = true;

            }
            else
            {
                label8.Visible = false;
            }
        }
    }
}
