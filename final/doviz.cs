using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace final
{
    public partial class doviz : Form
    {
        public doviz()
        {
            InitializeComponent();
        }

        private void doviz_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 geri = new Form1();
            geri.Show();
        }

        private void doviz_Load(object sender, EventArgs e)
        {
            String bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            string DolarAlis = xmldosya.SelectSingleNode("Tarih_Date /Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            dolaralis.Text = DolarAlis;

            string DolarSatis = xmldosya.SelectSingleNode("Tarih_Date /Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            dolarsatis.Text = DolarSatis;

            string EuroAlis = xmldosya.SelectSingleNode("Tarih_Date /Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            euroalis.Text = EuroAlis;

            string EuroSatis = xmldosya.SelectSingleNode("Tarih_Date /Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            eurosatis.Text = EuroSatis;

            string SterlinAlis = xmldosya.SelectSingleNode("Tarih_Date /Currency[@Kod='GBP']/BanknoteBuying").InnerXml;
            sterlinalis.Text = SterlinAlis;

            string SterlinSatis = xmldosya.SelectSingleNode("Tarih_Date /Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
            sterlinsatis.Text = SterlinSatis;

            string KDinarAlis = xmldosya.SelectSingleNode("Tarih_Date /Currency[@Kod='KWD']/BanknoteBuying").InnerXml;
            dinaralis.Text = KDinarAlis;

            string KDinarSatis = xmldosya.SelectSingleNode("Tarih_Date /Currency[@Kod='KWD']/BanknoteSelling").InnerXml;
            dinarsatis.Text = KDinarSatis;

            timer1.Start();
        }

        private void dolaralis_Click(object sender, EventArgs e)
        {
            txtkur.Text = dolaralis.Text;
        }

        private void dolarsatis_Click(object sender, EventArgs e)
        {
            txtkur.Text = dolarsatis.Text;
        }

        private void euroalis_Click(object sender, EventArgs e)
        {
            txtkur.Text = euroalis.Text;
        }

        private void eurosatis_Click(object sender, EventArgs e)
        {
            txtkur.Text = eurosatis.Text;
        }
        
        private void sterlinalis_Click(object sender, EventArgs e)
        {
            txtkur.Text = sterlinalis.Text;
        }
       
        private void sterlinsatis_Click(object sender, EventArgs e)
        {
            txtkur.Text = sterlinsatis.Text;
        }

        private void dinaralis_Click(object sender, EventArgs e)
        {
            txtkur.Text = dinaralis.Text;
        }
        private void dinarsatis_Click(object sender, EventArgs e)
        {
            txtkur.Text = dinarsatis.Text;
        }
        double kur, miktar, tutar;

        private void btnbozdur_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtkur.Text))
            {
                MessageBox.Show("Bir Kur Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtmiktar.Text))
                {
                    MessageBox.Show("Miktar Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    kur = Convert.ToDouble(txtkur.Text);
                    int miktar = Convert.ToInt32(txtmiktar.Text);
                    int tutar = Convert.ToInt32(miktar / kur);
                    txttutar.Text = tutar.ToString();
                    double kalan;
                    kalan = miktar % kur;
                    txtkalan.Text = kalan.ToString();
                }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saat.Text = DateTime.Now.ToLongTimeString();
            tarih.Text = DateTime.Now.ToLongDateString();
        }

        private void txtkur_TextChanged(object sender, EventArgs e)
        {
            txtkur.Text = txtkur.Text.Replace(".",",");
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtkur.Text))
            {
                MessageBox.Show("Bir Kur Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtmiktar.Text))
                {
                    MessageBox.Show("Miktar Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    kur = Convert.ToDouble(txtkur.Text);
                    miktar = Convert.ToDouble(txtmiktar.Text);
                    tutar = miktar * kur;
                    txttutar.Text = tutar.ToString();
                    txtkalan.Clear();
                }
            }
            
        }
    }
}
