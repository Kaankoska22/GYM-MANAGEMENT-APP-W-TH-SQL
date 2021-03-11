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
    public partial class ÜYELİĞİDOLANSPORCULAR : Form
    {
        public ÜYELİĞİDOLANSPORCULAR()
        {
            InitializeComponent();
        }
        ////////////////////////////////DEĞİŞKENLER VE FONKSİYONLAR
        SPORCUFONKSİYONLARI SP = new SPORCUFONKSİYONLARI();
        ///////////////////////////////////////////// 
        private void button3_Click(object sender, EventArgs e)
        {
            SPORCUBİLGİGÜNCELLE SC = new SPORCUBİLGİGÜNCELLE();
            SC.Show();
            ///BURAYA GÜNCELLENİCEK SPORCU BİLGİLERİ ATILACAK
            this.Hide();
        }//GÜNCELLENİCEK SPORCU BİLGİLERİ GÜNCELLEME SAYFASINA GÖNDERİLİYOR
        private void button2_Click(object sender, EventArgs e)//BTN GERİ DÖN
        {
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            SPORCUFONKSİYONLARI SP = new SPORCUFONKSİYONLARI();
            SPORCUAİDATYENİLEME UY = new SPORCUAİDATYENİLEME();
            if (labelID.Text=="")
            {
                UY.Show();
                this.Hide();
            }
            else
            {
                UY.ID1 = Convert.ToInt32(labelID.Text);
                UY.Show();
                this.Hide();
            }
        }//ÜYELİK YENİLEME EKRANINA YÖNLENDİRME
        private void button4_Click(object sender, EventArgs e)
        {
            MESAJGÖNDERİLECEKTELEFONLAR MS = new MESAJGÖNDERİLECEKTELEFONLAR();
            MS.Show();
            this.Hide();
        }//MESAJ EKRANINA YÖNLENDİRME
        private void ÜYELİĞİDOLANSPORCULAR_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'üYELİĞİDOLANSPORCULARDATA.ÜYELİĞİDOLANSPORCULAR' table. You can move, or remove it, as needed.
            this.üYELİĞİDOLANSPORCULARTableAdapter.Fill(this.üYELİĞİDOLANSPORCULARDATA.ÜYELİĞİDOLANSPORCULAR);
            // TODO: This line of code loads data into the 'üYELİĞİDEVAMEDENSPORCULAR._ÜYELİĞİDEVAMEDENSPORCULAR' table. You can move, or remove it, as needed.
            this.üYELİĞİDEVAMEDENSPORCULARTableAdapter.Fill(this.üYELİĞİDEVAMEDENSPORCULAR._ÜYELİĞİDEVAMEDENSPORCULAR);


        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SP.ÜYELİĞİBİTENSPORCUBİLGİSİGETİR(labelID,dataGridView2,textBoxAD,textBoxSOYAD,numericUpDownYAŞ,textBox1,maskedTextBoxTELEFON);
        }//DATA GRİD İLE TEXTBOXA BİLGİ ÇEK

        private void button1_Click(object sender, EventArgs e)
        {
            SP.ÜYELİĞİBİTENSPORCULAR(dateTimePicker1,dataGridView2);
            SP.ÜYELİĞİDOLANSPORCUDURUMPASİFYAP(dateTimePicker1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
