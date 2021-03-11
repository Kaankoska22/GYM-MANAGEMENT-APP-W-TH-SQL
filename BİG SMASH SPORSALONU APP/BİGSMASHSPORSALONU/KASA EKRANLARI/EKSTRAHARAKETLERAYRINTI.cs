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
    public partial class EKSTRAHARAKETLERAYRINTI : Form
    {
        public EKSTRAHARAKETLERAYRINTI()
        {
            InitializeComponent();
        }
        KASAFONKSİYONLARI KS = new KASAFONKSİYONLARI();
        private void button2_Click(object sender, EventArgs e)//BTN GERİ DÖN
        {
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            KS.EKSTRAGELİRLERAYRINTI(dateTimePicker1,dataGridView1);
        }//BİLGİ GETİR
    }
}
