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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked && radioButton2.Checked && radioButton3.Checked) {
                textBox1.Text = 0.ToString();
                
            }else if (radioButton1.Checked)
            {
                var res = Convert.ToDouble(textBox1.Text) / 1000;
                textBox2.Text = res.ToString();
            }else if (radioButton2.Checked)
            {
                var res = Convert.ToDouble(textBox1.Text) / 1609.34;
                textBox2.Text = res.ToString();
            }
            else if (radioButton3.Checked)
            {
                var res = Convert.ToDouble(textBox1.Text) * 1609.34;
                textBox2.Text = res.ToString();

            }


        }
    }
}
