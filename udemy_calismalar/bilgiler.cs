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
    public partial class bilgiler : Form
    {
        public bilgiler()
        {
            InitializeComponent();
        }

        private void btnaktar_Click(object sender, EventArgs e)
        {
            bilgiliste.Items.Add("Adı: " + txtad.Text);
            bilgiliste.Items.Add("Soyadı: " + txtsoyad.Text);
            bilgiliste.Items.Add("Tc Kimlik: " + maskedtckimlik.Text);
            bilgiliste.Items.Add("Doğum Tarihi :" + maskedtckimlik.Text);
            bilgiliste.Items.Add("Şehir: " + combosehir.Text);
            bilgiliste.Items.Add("Numara: " + maskednumara.Text);
        }
    }
}
