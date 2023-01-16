using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace final
{
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        } 
        private void textBoxad_Enter(object sender, EventArgs e)
        {
            String ad = textBoxad.Text;
            if (ad.Equals("Adınız..."))
            {
                textBoxad.Text = "";
                textBoxad.ForeColor = Color.Black;

            }
        }

        private void textBoxad_Leave(object sender, EventArgs e)
        {
            String ad = textBoxad.Text;
            if (ad.Equals("Adınız..."))
            {
                textBoxad.Text = "Adınız...";
                textBoxad.ForeColor = Color.Gray;
            }
        }


        private void textBoxsoyad_Enter(object sender, EventArgs e)
        {
            String soyad = textBoxsoyad.Text;
            if (soyad.Equals("Soyadınız..."))
            {
                textBoxsoyad.Text = "";
                textBoxsoyad.ForeColor = Color.Black;

            }
        }

        private void textBoxsoyad_Leave(object sender, EventArgs e)
        {
            String soyad = textBoxeposta.Text;
            if (soyad.Equals("Soyadınız..."))
            {
                textBoxsoyad.Text = "Soyadınız...";
                textBoxsoyad.ForeColor = Color.Gray;

            }
        }

        private void textBoxeposta_Enter(object sender, EventArgs e)
        {
            String eposta = textBoxeposta.Text;
            if (eposta.Equals("E posta adresiniz..."))
            {
                textBoxeposta.Text = "";
                textBoxeposta.ForeColor = Color.Black;

            }
        }

        private void textBoxeposta_Leave(object sender, EventArgs e)
        {
            String eposta = textBoxeposta.Text;
            if (eposta.Equals("E posta adresiniz..."))
            {
                textBoxeposta.Text = "E posta adresiniz...";
                textBoxeposta.ForeColor = Color.Gray;

            }
        }

        private void textBoxkullaniciadi_Enter(object sender, EventArgs e)
        {
            String kullaniciadi = textBoxkullaniciadi.Text;
            if (kullaniciadi.Equals("Kullanıcı Adınız..."))
            {
                textBoxkullaniciadi.Text = "";
                textBoxkullaniciadi.ForeColor = Color.Black;

            }
        }

        private void textBoxkullaniciadi_Leave(object sender, EventArgs e)
        {
            String kullaniciadi = textBoxkullaniciadi.Text;
            if (kullaniciadi.Equals("Kullanıcı Adınız..."))
            {
                textBoxkullaniciadi.Text = "Kullanıcı Adınız...";
                textBoxkullaniciadi.ForeColor = Color.Gray;

            }
        }

        private void textBoxsifre_Enter(object sender, EventArgs e)
        {
            String sifre = textBoxsifre.Text;
            if (sifre.Equals("Şifreniz..."))
            {
                textBoxsifre.Text = "";
                textBoxsifre.UseSystemPasswordChar = true;
                textBoxsifre.ForeColor = Color.Black;

            }
        }

        private void textBoxsifre_Leave(object sender, EventArgs e)
        {
            String sifre = textBoxsifre.Text;
            if (sifre.Equals("Şifreniz..."))
            {
                textBoxsifre.Text = "Şifreniz...";
                textBoxsifre.UseSystemPasswordChar = false;
                textBoxsifre.ForeColor = Color.Gray;

            }
        }

        private void textBoxsifreonay_Enter(object sender, EventArgs e)
        {
            String sifreonay = textBoxsifreonay.Text;
            if (sifreonay.Equals("Şifreyi Tekrar Giriniz..."))
            {
                textBoxsifreonay.Text = "";
                textBoxsifreonay.UseSystemPasswordChar = true;
                textBoxsifreonay.ForeColor = Color.Black;

            }
        }

        private void textBoxsifreonay_Leave(object sender, EventArgs e)
        {
            String sifreonay = textBoxsifreonay.Text;
            if (sifreonay.Equals("Şifreyi Tekrar Giriniz..."))
            {
                textBoxsifreonay.Text = "Şifreyi Tekrar Giriniz...";
                textBoxsifreonay.UseSystemPasswordChar = false;
                textBoxsifreonay.ForeColor = Color.Gray;

            }
        }

        private void btn_kayitol_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `kullanici`( `ad`, `soyad`, `eposta`, `kullaniciadi`, `sifre`) VALUES (@ad,@soyad,@email,@kullad,@pass)", db.getConnection());

            command.Parameters.Add("@ad", MySqlDbType.VarChar).Value = textBoxad.Text;
            command.Parameters.Add("@soyad", MySqlDbType.VarChar).Value = textBoxsoyad.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxeposta.Text;
            command.Parameters.Add("@kullad", MySqlDbType.VarChar).Value = textBoxkullaniciadi.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxsifre.Text;

            db.openConnection();

            if (!checkTextBoxesValues())
            {
                if (textBoxsifre.Text.Equals(textBoxsifreonay.Text))
                {
                    if (checkkullaniciadi())
                    {
                        MessageBox.Show("Bu Kullanıcı Adı Kullanılmaktadır", "Başka Bir Kullanıcı Adı Giriniz", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Hesap Oluşturuldu", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            giris k1 = new giris();
                            k1.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Hata Oluştu");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler Uyuşmuyor", "Hatalı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Boş Alanları Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            db.closeConnection();

        }

        public Boolean checkkullaniciadi()
        {
            DB db = new DB();

            String kullaniciadi = textBoxkullaniciadi.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `kullanici` WHERE `kullaniciadi` = @kullad ", db.getConnection());

            command.Parameters.Add("@kullad", MySqlDbType.VarChar).Value = kullaniciadi;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public Boolean checkTextBoxesValues()
        {
            String ad = textBoxad.Text;
            String soyad = textBoxsoyad.Text;
            String eposta = textBoxeposta.Text;
            String kullaniciadi = textBoxkullaniciadi.Text;
            String sifre = textBoxsifre.Text;
            if (ad.Equals("Adınız...") || soyad.Equals("Soyadınız...") || eposta.Equals("E posta adresiniz...") || kullaniciadi.Equals("Kullanıcı Adınız...") || sifre.Equals("Şifreniz..."))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void kayit_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Form1 geri = new Form1();
            geri.Show();
        }

        private void kayit_Load(object sender, EventArgs e)
        {

        }
    }
}
