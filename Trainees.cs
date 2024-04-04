using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;

namespace Day_7
{
    public partial class Trainees : Form
    {
        public Trainees()
        {
            InitializeComponent();
        }

        private void Trainees_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            var list  = checkedListBox1.CheckedItems;
            if (list != null)
            {
               
            }

            for (int i = list.Count-1 ; i >= 0; i--)
            {
                checkedListBox2.Items.Add(list[i]);
                checkedListBox1.Items.Remove(list[i]);
            }




        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            var list = checkedListBox1.Items;
            if (list != null)
            {

            }

            for (int i = list.Count - 1; i >= 0; i--)
            {
                checkedListBox2.Items.Add(list[i]);
                checkedListBox1.Items.Remove(list[i]);
            }

        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            var list = checkedListBox2.CheckedItems;
            if (list != null)
            {

            }

            for (int i = list.Count - 1; i >= 0; i--)
            {
                checkedListBox1.Items.Add(list[i]);
                checkedListBox2.Items.Remove(list[i]);
            }

        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            var list = checkedListBox2.Items;
            if (list != null)
            {

            }

            for (int i = list.Count - 1; i >= 0; i--)
            {
                checkedListBox1.Items.Add(list[i]);
                checkedListBox2.Items.Remove(list[i]);
            }

        }
    }
}
