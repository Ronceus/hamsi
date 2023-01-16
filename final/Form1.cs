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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris f2 = new giris();
            this.Hide();
            f2.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            kayit f2 = new kayit();
            this.Hide();
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void bts_brs_Click(object sender, EventArgs e)
        {
            doviz d2 = new  doviz();
            this.Hide();
            d2.ShowDialog();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            saat.Text = DateTime.Now.ToLongTimeString();
            tarih.Text = DateTime.Now.ToLongDateString();
        }
    }
}
