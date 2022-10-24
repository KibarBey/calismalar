using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace udemy_calismalar
{
    public partial class abudikgubudik : Form
    {
        public abudikgubudik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Emirhan Emre ÇELİK";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Emirhan Emre";
            label7.Text = "ÇELİK";
            label8.Text = "Yazılım";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label9.Text = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text + " " + textBox3.Text + " " + textBox4.Text);
        }
    }
}
