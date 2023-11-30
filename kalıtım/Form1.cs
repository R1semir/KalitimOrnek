using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalıtım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Insan ins = new Insan();
            ins.ad = "Emir";
            ins.soyad = " Ülker";
            ins.yaş = 23;
            ins.kilo = 75;

            Personel per = new Personel();
            per.departman = "Eğitim";
            per.yer = "Şube 1";
            per.boy = 180;

            label1.Text = ins.ad.ToString();
            label2.Text = ins.soyad.ToString();
            label3.Text = ins.yaş.ToString();
            label4.Text = ins.kilo.ToString();

            label5.Text = per.departman.ToString();
            label6.Text = per.yer.ToString();
            label7.Text = per.boy.ToString();

            per.ad = "Muratr";
            per.soyad = "Yücedağ";
            per.mevki = "Müdür Yardımcısı";

            label8.Text = per.ad.ToString();
            label9.Text = per.soyad.ToString();
            label10.Text = per.mevki.ToString();
        }
    }
}
