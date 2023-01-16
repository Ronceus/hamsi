using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();

            this.textBoxsifre.AutoSize = false;
            this.textBoxsifre.Size = new Size(this.textBoxsifre.Size.Width, 50);
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {

            DB db = new DB();    

            String kullaniciadi = textBoxkullaniciadi.Text;
            String sifre = textBoxsifre.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `kullanici` WHERE `kullaniciadi` = @kullad and `sifre` = @pass", db.getConnection());

            command.Parameters.Add("@kullad", MySqlDbType.VarChar).Value = kullaniciadi;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = sifre;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Oturum Açma Başarılı");
                this.Hide();
                Form1 main = new Form1();
                main.Show();
            }
            else 
            {
                if (kullaniciadi.Equals(""))
                {
                    MessageBox.Show("Kullanıcı Adı Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (sifre.Equals(""))
                {
                    MessageBox.Show("Şifre Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } 
        private void giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 geri = new Form1();
            geri.Show();
        }
    }
}
