using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BİGSMASHSPORSALONU
{
    public partial class KASAHARAKETLER : Form
    {
        public KASAHARAKETLER()
        {
            InitializeComponent();
        }
        KASAFONKSİYONLARI KS = new KASAFONKSİYONLARI();
        private void button4_Click(object sender, EventArgs e)
        {
            HARAKETLERAYRINTI HR = new HARAKETLERAYRINTI();
            HR.Show();
            this.Hide();

        }//BTN HARAKETLER AYRINTI SAYFASINA YÖNLENDİRME
        private void button1_Click(object sender, EventArgs e)
        {
            KS.SEÇİLENTARİHEGÖREAİDATÖDEMELERİ(dateTimePicker1,dataGridView1);
        }//SPORCU AİDATI GÖSTERME
        private void button2_Click(object sender, EventArgs e)
        {
            KS.KASATOPLAM(dateTimePicker2,dataGridView2);
        }//TOPLAM KASA GÖSTER
        private void button5_Click(object sender, EventArgs e)
        {
            KS.KASAEKSTRAGELİRLERİGÖSTER(dateTimePicker3,dataGridView3);
        }//KASA EKSTRA GELİRLERİ GÖSTER
    }
}
