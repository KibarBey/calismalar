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
    public partial class Sinav : Form
    {
        public Sinav()
        {
            InitializeComponent();
        }

        int soruno = 0;
        int dogru = 0;
        int yanlis = 0;
        private void Sinav_Load(object sender, EventArgs e)
        {

        }

        private void btnbasla_Click(object sender, EventArgs e)
        {
            time.Start();
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            richtextsoru.Enabled = false;

            btnsonraki.Enabled = false;
            btnbasla.Visible = false;
            soruno++;
            lblsoruno.Text = soruno.ToString();

            if (soruno == 1)
            {
                richtextsoru.Text = "PHP DİLİNDE EKRANA YAZDIRMA KOMUTU NEDİR ?";
                BtnA.Text = "echo";
                BtnB.Text = "console.write";
                BtnC.Text = "print";
                BtnD.Text = "printf";
                dogrucevap.Text = "echo";                
            }
            else
            {
                MessageBox.Show("ERROR 404 NOT FOUND");
            }
        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            time.Start();
            times = 30;
            lbltime.Text = "30";
            soruno++;
            lblsoruno.Text = soruno.ToString();
            richtextsoru.Enabled = false;

            lbldogru.Text=dogru.ToString();
            lblyanlis.Text=yanlis.ToString();

            btnsonraki.Enabled = false;
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;

            if (soruno == 2)
            {
                richtextsoru.Text = "C# dilini diğer dillerden ayıran özelliği nedir ?";
                BtnA.Text = "Form özelliği olması";
                BtnB.Text = "basit olması";
                BtnC.Text = "zor olması";
                BtnD.Text = "ilk dildir";
                dogrucevap.Text = "Form özelliği olması";
            }
            if(soruno == 3)
            {
                richtextsoru.Text = "Python dilini diğer dillerden ayıran özelliği nedir ?";
                BtnA.Text = "türkler yapmıştır";
                BtnB.Text = "yunan olması";
                BtnC.Text = "zor olması";
                BtnD.Text = "her alana sahiptir";
                dogrucevap.Text = "her alana sahiptir";
                btnsonraki.Text = "Sonuçlar";
                btnsonraki.Enabled = false;
               
            }
            if(soruno==4)
            {
                soruno = 3;
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                btnsonraki.Enabled = false;
                time.Stop();
                lblsoruno.Text = soruno.ToString();
                soruno -= 1;
            }

        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            btnsonraki.Enabled = true;
            time.Stop();

            verilencevap.Text = BtnA.Text;
            if(dogrucevap.Text==verilencevap.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                truepictur.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                redpictur.Visible = true;
            }
            
        }

        private void BtnB_Click(object sender, EventArgs e)
        {            
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false; 
            btnsonraki.Enabled = true;
            time.Stop();

            verilencevap.Text = BtnB.Text;
            if (dogrucevap.Text == verilencevap.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                truepictur.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                redpictur.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {            
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            btnsonraki.Enabled = true;
            time.Stop();

            verilencevap.Text = BtnC.Text;
            if (dogrucevap.Text == verilencevap.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                truepictur.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                redpictur.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {            
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            btnsonraki.Enabled = true;
            time.Stop();

            verilencevap.Text = BtnD.Text;
            if (dogrucevap.Text == verilencevap.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                truepictur.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                redpictur.Visible = true;
            }
        }
        int times=30 ;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Interval = 1000;
            times--;
            lbltime.Text = times.ToString();

            if(times==0)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                btnsonraki.Enabled = true;
                times = 30;
                time.Stop();
            }

        }
    }
}
