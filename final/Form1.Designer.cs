
namespace final
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_giris = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bts_brs = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tarih = new System.Windows.Forms.Label();
            this.saat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_giris.FlatAppearance.BorderSize = 0;
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giris.Location = new System.Drawing.Point(421, 178);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(134, 82);
            this.btn_giris.TabIndex = 0;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.AccessibleName = "btn_kayit";
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(568, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 82);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kayıt ol";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bts_brs
            // 
            this.bts_brs.BackColor = System.Drawing.SystemColors.Highlight;
            this.bts_brs.FlatAppearance.BorderSize = 0;
            this.bts_brs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bts_brs.Location = new System.Drawing.Point(226, 178);
            this.bts_brs.Name = "bts_brs";
            this.bts_brs.Size = new System.Drawing.Size(143, 78);
            this.bts_brs.TabIndex = 2;
            this.bts_brs.Text = "Döviz Kurları";
            this.bts_brs.UseVisualStyleBackColor = false;
            this.bts_brs.Click += new System.EventHandler(this.bts_brs_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // tarih
            // 
            this.tarih.BackColor = System.Drawing.Color.Transparent;
            this.tarih.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tarih.Location = new System.Drawing.Point(204, 23);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(201, 46);
            this.tarih.TabIndex = 3;
            this.tarih.Text = "tarih";
            // 
            // saat
            // 
            this.saat.BackColor = System.Drawing.Color.Transparent;
            this.saat.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saat.Location = new System.Drawing.Point(501, 23);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(201, 46);
            this.saat.TabIndex = 4;
            this.saat.Text = "saat";
            // 
            // Form1
            // 
            this.AccessibleName = "btn_kayit";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(945, 512);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.bts_brs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_giris);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bts_brs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Label saat;
    }
}

