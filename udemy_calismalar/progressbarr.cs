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
    public partial class progressbarr : Form
    {
        public progressbarr()
        {
            InitializeComponent();
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            progressBar1.Value += 10;
            if(progressBar1.Value==100)
            {
                timer1.Stop();
                timer2.Start();
            }
            if(progressBar2.Value%10==0)
            {
                label1.BackColor = Color.White;
            }
            if(progressBar2.Value%10==5)
            {
                label1.BackColor = Color.Red;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            progressBar2.Value += 5;
            if(progressBar2.Value==100)
            {
                timer2.Stop();
            }
        }
    }
}
