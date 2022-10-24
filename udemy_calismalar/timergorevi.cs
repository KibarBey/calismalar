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
    public partial class timergorevi : Form
    {
        public timergorevi()
        {
            InitializeComponent();
        }
        int sayac = 0;
        int saat = 0, dakika = 0, saniye = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            saniye++;
            lblsaniye.Text=saniye.ToString();

            if(saniye==60)
            {
                saniye = 0;
                dakika++;
                lbldakika.Text=dakika.ToString();
            }
            if(dakika==60)
            {
                dakika = 0;
                saat++;
                lblsaat.Text=saat.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            sayac++;
            if(sayac<=30)
            {
                this.BackColor = Color.Red;
            }
            else if(sayac<=40)
            {
                this.BackColor=Color.Yellow;
            }
            else if(sayac<=70)
            {
                this.BackColor = Color.Green;
            }
            else if(sayac>70)
            {
                sayac = 0;
            }
            label1.Text = sayac.ToString();
        }

        private void timergorevi_Load(object sender, EventArgs e)
        {
            timer2.Interval = 1;
        }
    }
}
