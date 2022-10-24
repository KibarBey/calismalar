using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace udemy_calismalar
{
    public partial class THY : Form
    {
        public THY()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Yoldumuzun Adı Soyadı: " + ad.Text);
            listBox1.Items.Add("Yolcumuzun TC'si: " + tc.Text);
            listBox1.Items.Add("Yolcumuzun Numarası: " + numara.Text);
            listBox1.Items.Add("Nereden: " + nereden.Text);
            listBox1.Items.Add("Nerye: " + nereye.Text);
            listBox1.Items.Add("Tarih: " + tarih.Text);
            listBox1.Items.Add("Saat: " + saat.Text);
            listBox1.Items.Add("Hayırlı Uçuşlar Dileriz Efenim.");
            listBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = nereye.Text;
            nereye.Text = nereden.Text;
            nereden.Text = label8.Text;
            
        }
    }
}
