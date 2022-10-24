namespace udemy_calismalar
{
    partial class Sinav
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sinav));
            this.richtextsoru = new System.Windows.Forms.RichTextBox();
            this.BtnA = new System.Windows.Forms.Button();
            this.BtnB = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsoruno = new System.Windows.Forms.Label();
            this.lbldogru = new System.Windows.Forms.Label();
            this.lblyanlis = new System.Windows.Forms.Label();
            this.btnsonraki = new System.Windows.Forms.Button();
            this.btnbasla = new System.Windows.Forms.Button();
            this.truepictur = new System.Windows.Forms.PictureBox();
            this.redpictur = new System.Windows.Forms.PictureBox();
            this.dogrucevap = new System.Windows.Forms.Label();
            this.verilencevap = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.truepictur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redpictur)).BeginInit();
            this.SuspendLayout();
            // 
            // richtextsoru
            // 
            this.richtextsoru.Enabled = false;
            this.richtextsoru.ForeColor = System.Drawing.SystemColors.MenuText;
            this.richtextsoru.Location = new System.Drawing.Point(1, 18);
            this.richtextsoru.Margin = new System.Windows.Forms.Padding(4);
            this.richtextsoru.Name = "richtextsoru";
            this.richtextsoru.Size = new System.Drawing.Size(656, 160);
            this.richtextsoru.TabIndex = 0;
            this.richtextsoru.Text = "";
            // 
            // BtnA
            // 
            this.BtnA.Enabled = false;
            this.BtnA.Location = new System.Drawing.Point(0, 185);
            this.BtnA.Margin = new System.Windows.Forms.Padding(4);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(324, 48);
            this.BtnA.TabIndex = 1;
            this.BtnA.Text = "A";
            this.BtnA.UseVisualStyleBackColor = true;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // BtnB
            // 
            this.BtnB.Enabled = false;
            this.BtnB.Location = new System.Drawing.Point(333, 185);
            this.BtnB.Margin = new System.Windows.Forms.Padding(4);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(324, 48);
            this.BtnB.TabIndex = 2;
            this.BtnB.Text = "B";
            this.BtnB.UseVisualStyleBackColor = true;
            this.BtnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // BtnC
            // 
            this.BtnC.Enabled = false;
            this.BtnC.Location = new System.Drawing.Point(0, 241);
            this.BtnC.Margin = new System.Windows.Forms.Padding(4);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(324, 48);
            this.BtnC.TabIndex = 3;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnD
            // 
            this.BtnD.Enabled = false;
            this.BtnD.Location = new System.Drawing.Point(333, 241);
            this.BtnD.Margin = new System.Windows.Forms.Padding(4);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(324, 48);
            this.BtnD.TabIndex = 4;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = true;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(675, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soru No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(691, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dogru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(693, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yanlış:";
            // 
            // lblsoruno
            // 
            this.lblsoruno.AutoSize = true;
            this.lblsoruno.Location = new System.Drawing.Point(757, 22);
            this.lblsoruno.Name = "lblsoruno";
            this.lblsoruno.Size = new System.Drawing.Size(20, 24);
            this.lblsoruno.TabIndex = 8;
            this.lblsoruno.Text = "0";
            // 
            // lbldogru
            // 
            this.lbldogru.AutoSize = true;
            this.lbldogru.Location = new System.Drawing.Point(757, 56);
            this.lbldogru.Name = "lbldogru";
            this.lbldogru.Size = new System.Drawing.Size(20, 24);
            this.lbldogru.TabIndex = 9;
            this.lbldogru.Text = "0";
            // 
            // lblyanlis
            // 
            this.lblyanlis.AutoSize = true;
            this.lblyanlis.Location = new System.Drawing.Point(757, 94);
            this.lblyanlis.Name = "lblyanlis";
            this.lblyanlis.Size = new System.Drawing.Size(20, 24);
            this.lblyanlis.TabIndex = 10;
            this.lblyanlis.Text = "0";
            // 
            // btnsonraki
            // 
            this.btnsonraki.Enabled = false;
            this.btnsonraki.Location = new System.Drawing.Point(665, 130);
            this.btnsonraki.Margin = new System.Windows.Forms.Padding(4);
            this.btnsonraki.Name = "btnsonraki";
            this.btnsonraki.Size = new System.Drawing.Size(205, 48);
            this.btnsonraki.TabIndex = 11;
            this.btnsonraki.Text = "Sonraki Soru";
            this.btnsonraki.UseVisualStyleBackColor = true;
            this.btnsonraki.Click += new System.EventHandler(this.btnsonraki_Click);
            // 
            // btnbasla
            // 
            this.btnbasla.Location = new System.Drawing.Point(665, 130);
            this.btnbasla.Margin = new System.Windows.Forms.Padding(4);
            this.btnbasla.Name = "btnbasla";
            this.btnbasla.Size = new System.Drawing.Size(205, 48);
            this.btnbasla.TabIndex = 12;
            this.btnbasla.Text = "Başla";
            this.btnbasla.UseVisualStyleBackColor = true;
            this.btnbasla.Click += new System.EventHandler(this.btnbasla_Click);
            // 
            // truepictur
            // 
            this.truepictur.Image = ((System.Drawing.Image)(resources.GetObject("truepictur.Image")));
            this.truepictur.Location = new System.Drawing.Point(783, 58);
            this.truepictur.Name = "truepictur";
            this.truepictur.Size = new System.Drawing.Size(26, 22);
            this.truepictur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.truepictur.TabIndex = 13;
            this.truepictur.TabStop = false;
            this.truepictur.Visible = false;
            // 
            // redpictur
            // 
            this.redpictur.Image = ((System.Drawing.Image)(resources.GetObject("redpictur.Image")));
            this.redpictur.Location = new System.Drawing.Point(783, 95);
            this.redpictur.Name = "redpictur";
            this.redpictur.Size = new System.Drawing.Size(26, 23);
            this.redpictur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redpictur.TabIndex = 14;
            this.redpictur.TabStop = false;
            this.redpictur.Visible = false;
            // 
            // dogrucevap
            // 
            this.dogrucevap.AutoSize = true;
            this.dogrucevap.Location = new System.Drawing.Point(815, 58);
            this.dogrucevap.Name = "dogrucevap";
            this.dogrucevap.Size = new System.Drawing.Size(61, 24);
            this.dogrucevap.TabIndex = 15;
            this.dogrucevap.Text = "label4";
            this.dogrucevap.Visible = false;
            // 
            // verilencevap
            // 
            this.verilencevap.AutoSize = true;
            this.verilencevap.Location = new System.Drawing.Point(815, 94);
            this.verilencevap.Name = "verilencevap";
            this.verilencevap.Size = new System.Drawing.Size(61, 24);
            this.verilencevap.TabIndex = 15;
            this.verilencevap.Text = "label4";
            this.verilencevap.Visible = false;
            // 
            // time
            // 
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(675, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 37);
            this.label4.TabIndex = 16;
            this.label4.Text = "Süre:";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltime.Location = new System.Drawing.Point(754, 205);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(46, 37);
            this.lbltime.TabIndex = 17;
            this.lbltime.Text = "30";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(795, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 37);
            this.label5.TabIndex = 18;
            this.label5.Text = "saniye";
            // 
            // Sinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 304);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.verilencevap);
            this.Controls.Add(this.dogrucevap);
            this.Controls.Add(this.redpictur);
            this.Controls.Add(this.truepictur);
            this.Controls.Add(this.btnbasla);
            this.Controls.Add(this.btnsonraki);
            this.Controls.Add(this.lblyanlis);
            this.Controls.Add(this.lbldogru);
            this.Controls.Add(this.lblsoruno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.richtextsoru);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sinav";
            this.Text = "Sinav";
            this.Load += new System.EventHandler(this.Sinav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.truepictur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redpictur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtextsoru;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsoruno;
        private System.Windows.Forms.Label lbldogru;
        private System.Windows.Forms.Label lblyanlis;
        private System.Windows.Forms.Button btnsonraki;
        private System.Windows.Forms.Button btnbasla;
        private System.Windows.Forms.PictureBox truepictur;
        private System.Windows.Forms.PictureBox redpictur;
        private System.Windows.Forms.Label dogrucevap;
        private System.Windows.Forms.Label verilencevap;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label label5;
    }
}