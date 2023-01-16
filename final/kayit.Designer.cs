
namespace final
{
    partial class kayit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kayitol = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.textBoxsoyad = new System.Windows.Forms.TextBox();
            this.textBoxeposta = new System.Windows.Forms.TextBox();
            this.textBoxkullaniciadi = new System.Windows.Forms.TextBox();
            this.textBoxsifre = new System.Windows.Forms.TextBox();
            this.textBoxsifreonay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(124, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(98, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // btn_kayitol
            // 
            this.btn_kayitol.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_kayitol.FlatAppearance.BorderSize = 0;
            this.btn_kayitol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kayitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitol.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_kayitol.Location = new System.Drawing.Point(293, 349);
            this.btn_kayitol.Name = "btn_kayitol";
            this.btn_kayitol.Size = new System.Drawing.Size(218, 93);
            this.btn_kayitol.TabIndex = 5;
            this.btn_kayitol.Text = "Kayıt Ol";
            this.btn_kayitol.UseVisualStyleBackColor = false;
            this.btn_kayitol.Click += new System.EventHandler(this.btn_kayitol_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(137, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(118, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(118, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "e-posta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(98, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Şifre Tekrar";
            // 
            // textBoxad
            // 
            this.textBoxad.ForeColor = System.Drawing.Color.Gray;
            this.textBoxad.Location = new System.Drawing.Point(293, 60);
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(286, 22);
            this.textBoxad.TabIndex = 9;
            this.textBoxad.Text = "Adınız...";
            this.textBoxad.Enter += new System.EventHandler(this.textBoxad_Enter);
            this.textBoxad.Leave += new System.EventHandler(this.textBoxad_Leave);
            // 
            // textBoxsoyad
            // 
            this.textBoxsoyad.ForeColor = System.Drawing.Color.Gray;
            this.textBoxsoyad.Location = new System.Drawing.Point(293, 104);
            this.textBoxsoyad.Name = "textBoxsoyad";
            this.textBoxsoyad.Size = new System.Drawing.Size(286, 22);
            this.textBoxsoyad.TabIndex = 10;
            this.textBoxsoyad.Text = "Soyadınız...";
            this.textBoxsoyad.Enter += new System.EventHandler(this.textBoxsoyad_Enter);
            this.textBoxsoyad.Leave += new System.EventHandler(this.textBoxsoyad_Leave);
            // 
            // textBoxeposta
            // 
            this.textBoxeposta.ForeColor = System.Drawing.Color.Gray;
            this.textBoxeposta.Location = new System.Drawing.Point(293, 143);
            this.textBoxeposta.Name = "textBoxeposta";
            this.textBoxeposta.Size = new System.Drawing.Size(286, 22);
            this.textBoxeposta.TabIndex = 11;
            this.textBoxeposta.Text = "E posta adresiniz...";
            this.textBoxeposta.Enter += new System.EventHandler(this.textBoxeposta_Enter);
            this.textBoxeposta.Leave += new System.EventHandler(this.textBoxeposta_Leave);
            // 
            // textBoxkullaniciadi
            // 
            this.textBoxkullaniciadi.ForeColor = System.Drawing.Color.Gray;
            this.textBoxkullaniciadi.Location = new System.Drawing.Point(293, 182);
            this.textBoxkullaniciadi.Name = "textBoxkullaniciadi";
            this.textBoxkullaniciadi.Size = new System.Drawing.Size(286, 22);
            this.textBoxkullaniciadi.TabIndex = 12;
            this.textBoxkullaniciadi.Text = "Kullanıcı Adınız...";
            this.textBoxkullaniciadi.Enter += new System.EventHandler(this.textBoxkullaniciadi_Enter);
            this.textBoxkullaniciadi.Leave += new System.EventHandler(this.textBoxkullaniciadi_Leave);
            // 
            // textBoxsifre
            // 
            this.textBoxsifre.ForeColor = System.Drawing.Color.Gray;
            this.textBoxsifre.Location = new System.Drawing.Point(293, 230);
            this.textBoxsifre.Name = "textBoxsifre";
            this.textBoxsifre.Size = new System.Drawing.Size(286, 22);
            this.textBoxsifre.TabIndex = 13;
            this.textBoxsifre.Text = "Şifreniz...";
            this.textBoxsifre.Enter += new System.EventHandler(this.textBoxsifre_Enter);
            this.textBoxsifre.Leave += new System.EventHandler(this.textBoxsifre_Leave);
            // 
            // textBoxsifreonay
            // 
            this.textBoxsifreonay.ForeColor = System.Drawing.Color.Gray;
            this.textBoxsifreonay.Location = new System.Drawing.Point(293, 274);
            this.textBoxsifreonay.Name = "textBoxsifreonay";
            this.textBoxsifreonay.Size = new System.Drawing.Size(286, 22);
            this.textBoxsifreonay.TabIndex = 14;
            this.textBoxsifreonay.Text = "Şifreyi Tekrar Giriniz...";
            this.textBoxsifreonay.Enter += new System.EventHandler(this.textBoxsifreonay_Enter);
            this.textBoxsifreonay.Leave += new System.EventHandler(this.textBoxsifreonay_Leave);
            // 
            // kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(796, 471);
            this.Controls.Add(this.textBoxsifreonay);
            this.Controls.Add(this.textBoxsifre);
            this.Controls.Add(this.textBoxkullaniciadi);
            this.Controls.Add(this.textBoxeposta);
            this.Controls.Add(this.textBoxsoyad);
            this.Controls.Add(this.textBoxad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kayitol);
            this.Name = "kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kayit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kayit_FormClosing_1);
            this.Load += new System.EventHandler(this.kayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kayitol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.TextBox textBoxsoyad;
        private System.Windows.Forms.TextBox textBoxeposta;
        private System.Windows.Forms.TextBox textBoxkullaniciadi;
        private System.Windows.Forms.TextBox textBoxsifre;
        private System.Windows.Forms.TextBox textBoxsifreonay;
    }
}