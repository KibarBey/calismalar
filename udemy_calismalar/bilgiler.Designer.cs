namespace udemy_calismalar
{
    partial class bilgiler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.maskedtckimlik = new System.Windows.Forms.MaskedTextBox();
            this.maskednumara = new System.Windows.Forms.MaskedTextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.datedogum = new System.Windows.Forms.DateTimePicker();
            this.combosehir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bilgiliste = new System.Windows.Forms.ListBox();
            this.btnaktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedtckimlik
            // 
            this.maskedtckimlik.Location = new System.Drawing.Point(225, 96);
            this.maskedtckimlik.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.maskedtckimlik.Mask = "000-000-00-000";
            this.maskedtckimlik.Name = "maskedtckimlik";
            this.maskedtckimlik.Size = new System.Drawing.Size(176, 34);
            this.maskedtckimlik.TabIndex = 0;
            // 
            // maskednumara
            // 
            this.maskednumara.Location = new System.Drawing.Point(225, 209);
            this.maskednumara.Mask = "(999) 000-0000";
            this.maskednumara.Name = "maskednumara";
            this.maskednumara.Size = new System.Drawing.Size(176, 34);
            this.maskednumara.TabIndex = 1;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(225, 14);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(176, 34);
            this.txtad.TabIndex = 2;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(225, 54);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(176, 34);
            this.txtsoyad.TabIndex = 3;
            // 
            // datedogum
            // 
            this.datedogum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datedogum.Location = new System.Drawing.Point(225, 138);
            this.datedogum.Name = "datedogum";
            this.datedogum.Size = new System.Drawing.Size(176, 22);
            this.datedogum.TabIndex = 4;
            // 
            // combosehir
            // 
            this.combosehir.FormattingEnabled = true;
            this.combosehir.Items.AddRange(new object[] {
            "01 Adana",
            "02 Adıyaman",
            "03 Afyon ",
            "04 Ağrı ",
            "05 Amasya",
            "06 Ankara",
            "07 Antalya",
            "08 Artvin",
            "09 Aydın",
            "10 Balıkesir",
            "11 Bilecik",
            "12 Bingöl",
            "13 Bitlis",
            "14 Bolu",
            "15 Burdur",
            "16 Bursa",
            "17 Çanakkale",
            "18 Çankırı",
            "19 Çorum",
            "20 Denizli",
            "21 Diyarbakır",
            "22 Edirne",
            "23 Elazığ",
            "24 Erzincan",
            "25 Erzurum",
            "26 Eskişehir",
            "27 Gaziantep",
            "28 Giresun",
            "29 Gümüşhane",
            "30 Hakkari",
            "31 Hatay",
            "32 Isparta",
            "33 İçel (Mersin)",
            "34 İstanbul",
            "35 İzmir",
            "36 Kars",
            "37 Kastamonu",
            "38 Kayseri",
            "39 Kırklareli",
            "40 Kırşehir",
            "41 Kocaeli",
            "42 Konya",
            "43 Kütahya",
            "44 Malatya",
            "45 Manisa",
            "46 K.maraş",
            "47 Mardin",
            "48 Muğla",
            "49 Muş",
            "50 Nevşehir",
            "51 Niğde",
            "52 Ordu",
            "53 Rize",
            "54 Sakarya",
            "55 Samsun",
            "56 Siirt",
            "57 Sinop",
            "58 Sivas",
            "59 Tekirdağ",
            "60 Tokat",
            "61 Trabzon",
            "62 Tunceli",
            "63 Şanlıurfa",
            "64 Uşak",
            "65 Van",
            "66 Yozgat",
            "67 Zonguldak",
            "68 Aksaray",
            "69 Bayburt",
            "70 Karaman",
            "71 Kırıkkale",
            "72 Batman",
            "73 Şırnak",
            "74 Bartın",
            "75 Ardahan",
            "76 Iğdır",
            "77 Yalova",
            "78 Karabük",
            "79 Kilis",
            "80 Osmaniye",
            "81 Düzce"});
            this.combosehir.Location = new System.Drawing.Point(225, 166);
            this.combosehir.Name = "combosehir";
            this.combosehir.Size = new System.Drawing.Size(176, 37);
            this.combosehir.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tc Kimlik:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Şehir:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Numara:";
            // 
            // bilgiliste
            // 
            this.bilgiliste.FormattingEnabled = true;
            this.bilgiliste.ItemHeight = 29;
            this.bilgiliste.Location = new System.Drawing.Point(491, 12);
            this.bilgiliste.Name = "bilgiliste";
            this.bilgiliste.Size = new System.Drawing.Size(374, 236);
            this.bilgiliste.TabIndex = 7;
            // 
            // btnaktar
            // 
            this.btnaktar.Location = new System.Drawing.Point(225, 249);
            this.btnaktar.Name = "btnaktar";
            this.btnaktar.Size = new System.Drawing.Size(176, 41);
            this.btnaktar.TabIndex = 8;
            this.btnaktar.Text = "Bilgileri aktar";
            this.btnaktar.UseVisualStyleBackColor = true;
            this.btnaktar.Click += new System.EventHandler(this.btnaktar_Click);
            // 
            // ödev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 330);
            this.Controls.Add(this.btnaktar);
            this.Controls.Add(this.bilgiliste);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combosehir);
            this.Controls.Add(this.datedogum);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.maskednumara);
            this.Controls.Add(this.maskedtckimlik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "ödev";
            this.Text = "ödev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedtckimlik;
        private System.Windows.Forms.MaskedTextBox maskednumara;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.DateTimePicker datedogum;
        private System.Windows.Forms.ComboBox combosehir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox bilgiliste;
        private System.Windows.Forms.Button btnaktar;
    }
}