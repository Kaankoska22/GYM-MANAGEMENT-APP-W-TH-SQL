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
    public partial class HARAKETLERAYRINTI : Form
    {
        public HARAKETLERAYRINTI()
        {
            InitializeComponent();
        }
        KASAFONKSİYONLARI KS = new KASAFONKSİYONLARI();
        private void button3_Click(object sender, EventArgs e)
        {
            EKSTRAHARAKETLERAYRINTI EK = new EKSTRAHARAKETLERAYRINTI();
            EK.Show();
            this.Hide();
        }//EKSTRA EKRAN HARAKETLERİ SAYFASINA YÖNLENDİRME
        private void label14_Click(object sender, EventArgs e)//BTN GERİ DÖN
        {
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            KS.KASAEKSTRAGELİRLERİGÖSTERAYRINTI(dateTimePicker1,dataGridView1);
        }//BTN SORGULA
    }
}
