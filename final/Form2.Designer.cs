
namespace final
{
    partial class doviz
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dolaralis = new System.Windows.Forms.Label();
            this.dolarsatis = new System.Windows.Forms.Label();
            this.euroalis = new System.Windows.Forms.Label();
            this.eurosatis = new System.Windows.Forms.Label();
            this.btnbozdur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtkalan = new System.Windows.Forms.TextBox();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.txttutar = new System.Windows.Forms.TextBox();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.txtkur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.saat = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.sterlinalis = new System.Windows.Forms.Label();
            this.sterlinsatis = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.dinaralis = new System.Windows.Forms.Label();
            this.dinarsatis = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(80, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar/TL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(345, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Satış";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(80, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 45);
            this.label3.TabIndex = 0;
            this.label3.Text = "Euro/TL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.LawnGreen;
            this.label4.Location = new System.Drawing.Point(211, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 45);
            this.label4.TabIndex = 0;
            this.label4.Text = "Alış";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dolaralis
            // 
            this.dolaralis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dolaralis.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dolaralis.ForeColor = System.Drawing.Color.Red;
            this.dolaralis.Location = new System.Drawing.Point(211, 217);
            this.dolaralis.Name = "dolaralis";
            this.dolaralis.Size = new System.Drawing.Size(110, 45);
            this.dolaralis.TabIndex = 0;
            this.dolaralis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dolaralis.Click += new System.EventHandler(this.dolaralis_Click);
            // 
            // dolarsatis
            // 
            this.dolarsatis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dolarsatis.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dolarsatis.ForeColor = System.Drawing.Color.Red;
            this.dolarsatis.Location = new System.Drawing.Point(345, 217);
            this.dolarsatis.Name = "dolarsatis";
            this.dolarsatis.Size = new System.Drawing.Size(110, 45);
            this.dolarsatis.TabIndex = 0;
            this.dolarsatis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dolarsatis.Click += new System.EventHandler(this.dolarsatis_Click);
            // 
            // euroalis
            // 
            this.euroalis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.euroalis.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.euroalis.ForeColor = System.Drawing.Color.Red;
            this.euroalis.Location = new System.Drawing.Point(211, 276);
            this.euroalis.Name = "euroalis";
            this.euroalis.Size = new System.Drawing.Size(110, 45);
            this.euroalis.TabIndex = 0;
            this.euroalis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.euroalis.Click += new System.EventHandler(this.euroalis_Click);
            // 
            // eurosatis
            // 
            this.eurosatis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eurosatis.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eurosatis.ForeColor = System.Drawing.Color.Red;
            this.eurosatis.Location = new System.Drawing.Point(345, 275);
            this.eurosatis.Name = "eurosatis";
            this.eurosatis.Size = new System.Drawing.Size(110, 45);
            this.eurosatis.TabIndex = 0;
            this.eurosatis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.eurosatis.Click += new System.EventHandler(this.eurosatis_Click);
            // 
            // btnbozdur
            // 
            this.btnbozdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbozdur.Location = new System.Drawing.Point(187, 317);
            this.btnbozdur.Name = "btnbozdur";
            this.btnbozdur.Size = new System.Drawing.Size(175, 64);
            this.btnbozdur.TabIndex = 1;
            this.btnbozdur.Text = "Bozdurma";
            this.btnbozdur.UseVisualStyleBackColor = true;
            this.btnbozdur.Click += new System.EventHandler(this.btnbozdur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.txtkalan);
            this.groupBox1.Controls.Add(this.btnhesapla);
            this.groupBox1.Controls.Add(this.btnbozdur);
            this.groupBox1.Controls.Add(this.txttutar);
            this.groupBox1.Controls.Add(this.txtmiktar);
            this.groupBox1.Controls.Add(this.txtkur);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(549, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 397);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Döviz İşlem";
            // 
            // txtkalan
            // 
            this.txtkalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkalan.ForeColor = System.Drawing.Color.Red;
            this.txtkalan.Location = new System.Drawing.Point(165, 256);
            this.txtkalan.Multiline = true;
            this.txtkalan.Name = "txtkalan";
            this.txtkalan.Size = new System.Drawing.Size(180, 45);
            this.txtkalan.TabIndex = 17;
            this.txtkalan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnhesapla
            // 
            this.btnhesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhesapla.Location = new System.Drawing.Point(6, 317);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(175, 64);
            this.btnhesapla.TabIndex = 1;
            this.btnhesapla.Text = "Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // txttutar
            // 
            this.txttutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttutar.ForeColor = System.Drawing.Color.Red;
            this.txttutar.Location = new System.Drawing.Point(165, 184);
            this.txttutar.Multiline = true;
            this.txttutar.Name = "txttutar";
            this.txttutar.Size = new System.Drawing.Size(180, 45);
            this.txttutar.TabIndex = 17;
            this.txttutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmiktar
            // 
            this.txtmiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmiktar.ForeColor = System.Drawing.Color.Red;
            this.txtmiktar.Location = new System.Drawing.Point(165, 113);
            this.txtmiktar.Multiline = true;
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(180, 45);
            this.txtmiktar.TabIndex = 17;
            this.txtmiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtkur
            // 
            this.txtkur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkur.ForeColor = System.Drawing.Color.Red;
            this.txtkur.Location = new System.Drawing.Point(165, 42);
            this.txtkur.Multiline = true;
            this.txtkur.Name = "txtkur";
            this.txtkur.Size = new System.Drawing.Size(180, 45);
            this.txtkur.TabIndex = 17;
            this.txtkur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtkur.TextChanged += new System.EventHandler(this.txtkur_TextChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(23, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 45);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kalan";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(23, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 45);
            this.label8.TabIndex = 6;
            this.label8.Text = "Kur";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(23, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 45);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tutar";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(23, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 45);
            this.label7.TabIndex = 5;
            this.label7.Text = "Miktar";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saat
            // 
            this.saat.BackColor = System.Drawing.Color.Transparent;
            this.saat.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saat.Location = new System.Drawing.Point(507, 20);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(201, 46);
            this.saat.TabIndex = 0;
            this.saat.Text = "saat";
            // 
            // tarih
            // 
            this.tarih.BackColor = System.Drawing.Color.Transparent;
            this.tarih.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tarih.Location = new System.Drawing.Point(210, 20);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(201, 46);
            this.tarih.TabIndex = 0;
            this.tarih.Text = "tarih";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(80, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 45);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sterlin/TL";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sterlinalis
            // 
            this.sterlinalis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sterlinalis.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sterlinalis.ForeColor = System.Drawing.Color.Red;
            this.sterlinalis.Location = new System.Drawing.Point(211, 335);
            this.sterlinalis.Name = "sterlinalis";
            this.sterlinalis.Size = new System.Drawing.Size(110, 45);
            this.sterlinalis.TabIndex = 0;
            this.sterlinalis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sterlinalis.Click += new System.EventHandler(this.sterlinalis_Click);
            // 
            // sterlinsatis
            // 
            this.sterlinsatis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sterlinsatis.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sterlinsatis.ForeColor = System.Drawing.Color.Red;
            this.sterlinsatis.Location = new System.Drawing.Point(345, 335);
            this.sterlinsatis.Name = "sterlinsatis";
            this.sterlinsatis.Size = new System.Drawing.Size(110, 45);
            this.sterlinsatis.TabIndex = 0;
            this.sterlinsatis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sterlinsatis.Click += new System.EventHandler(this.sterlinsatis_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(80, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 45);
            this.label11.TabIndex = 0;
            this.label11.Text = "Kuveyt Dinarı/TL";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dinaralis
            // 
            this.dinaralis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dinaralis.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dinaralis.ForeColor = System.Drawing.Color.Red;
            this.dinaralis.Location = new System.Drawing.Point(211, 394);
            this.dinaralis.Name = "dinaralis";
            this.dinaralis.Size = new System.Drawing.Size(110, 45);
            this.dinaralis.TabIndex = 0;
            this.dinaralis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dinaralis.Click += new System.EventHandler(this.dinaralis_Click);
            // 
            // dinarsatis
            // 
            this.dinarsatis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dinarsatis.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dinarsatis.ForeColor = System.Drawing.Color.Red;
            this.dinarsatis.Location = new System.Drawing.Point(345, 394);
            this.dinarsatis.Name = "dinarsatis";
            this.dinarsatis.Size = new System.Drawing.Size(110, 45);
            this.dinarsatis.TabIndex = 0;
            this.dinarsatis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dinarsatis.Click += new System.EventHandler(this.dinarsatis_Click);
            // 
            // doviz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(990, 702);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.dinarsatis);
            this.Controls.Add(this.sterlinsatis);
            this.Controls.Add(this.dinaralis);
            this.Controls.Add(this.sterlinalis);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.eurosatis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.euroalis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dolarsatis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dolaralis);
            this.Controls.Add(this.label1);
            this.Name = "doviz";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.doviz_FormClosing);
            this.Load += new System.EventHandler(this.doviz_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dolaralis;
        private System.Windows.Forms.Label dolarsatis;
        private System.Windows.Forms.Label euroalis;
        private System.Windows.Forms.Label eurosatis;
        private System.Windows.Forms.Button btnbozdur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtkalan;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.TextBox txttutar;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.Windows.Forms.TextBox txtkur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label sterlinalis;
        private System.Windows.Forms.Label sterlinsatis;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label dinaralis;
        private System.Windows.Forms.Label dinarsatis;
    }
}