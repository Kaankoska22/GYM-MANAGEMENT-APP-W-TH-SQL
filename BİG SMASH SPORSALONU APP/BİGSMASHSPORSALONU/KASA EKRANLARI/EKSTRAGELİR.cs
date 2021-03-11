using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTİTYLAYER;
using FACADLAYER;

namespace BİGSMASHSPORSALONU
{
    public partial class EKSTRAGELİR : Form
    {
        public EKSTRAGELİR()
        {
            InitializeComponent();
        }
        KASAFONKSİYONLARI KS = new KASAFONKSİYONLARI();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }//GERİ GEL BUTONU
        private void button1_Click(object sender, EventArgs e)
        {
            KS.ANAKASAEKLE(textBox1,dateTimePicker1);
            KS.EKSTRAGELİREEKLE(textBox1,richTextBox1,dateTimePicker1);
        }//BTN EKSTRA GELİR EKLEME
    }
}
