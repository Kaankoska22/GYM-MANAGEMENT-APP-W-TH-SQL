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
using BUSİNESSLOGİCLAYER;
using System.Data.SqlClient;

namespace BİGSMASHSPORSALONU
{
    public partial class SPORCUBİLGİGÜNCELLE : Form
    {
        public SPORCUBİLGİGÜNCELLE()
        {
            InitializeComponent();
        }
        //////////////////////////////DEĞİŞKENLER VE FONKSİYONLAR
        public int ID;
        VKİNDEXHESAPLA VK = new VKİNDEXHESAPLA();
        SPORCUFONKSİYONLARI SP = new SPORCUFONKSİYONLARI();
        ///////////////////////////////////////////////////////////////////////////////
        private void button3_Click(object sender, EventArgs e)//sorgula butonu
        {
           SP.ADAGÖRESIRALA(textBox1,dataGridView8);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }//BTN GERİ GEL
        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SP.VERİAKTAR(pictureBox3, labelID, dataGridView8, textBoxAD, richTextBoxKISANOT, textBoxSOYAD, numericUpDownYAŞ, radioButtonERKEK, radioButtonKADIN, radioButtonöğrenci, radioButtonyetişkin, textBoxFOTO, maskedTextBoxBOY, maskedTextBoxKİLO, maskedTextBoxBEL, maskedTextBoxGÖĞÜS, maskedTextBoxKALÇA, maskedTextBoxSAĞKOL, maskedTextBoxSOLKOL, maskedTextBoxVKİNDEX, maskedTextBoxTELEFON, maskedTextBoxTC, dateTimePicker1);
            }
            catch (Exception)
            {

                MessageBox.Show("VERİ AKTARIMINDA Bİ PROBLEM OLDU!!!");
            }
           
        }//DATA GRİD İLE TEXTBOXA VERİ AKTARMA
        private void SPORCUBİLGİGÜNCELLE_Load(object sender, EventArgs e)
        {
            SP.hepsinilistele(dataGridView8);
            maskedTextBoxBEL.Enabled = false;
            maskedTextBoxGÖĞÜS.Enabled = false;
            maskedTextBoxKALÇA.Enabled = false;
            maskedTextBoxKİLO.Enabled = false;
            maskedTextBoxSAĞKOL.Enabled = false;
            maskedTextBoxSOLKOL.Enabled = false;
            
        }//LOAD EKRAN
        private void maskedTextBoxBOY_Click(object sender, EventArgs e)
        {
                maskedTextBoxKİLO.Enabled = true;
        
            
        }//VERİ GİRİŞ KONTROLÜ
        private void maskedTextBoxKİLO_Click(object sender, EventArgs e)
        {
            maskedTextBoxKALÇA.Enabled = true;
        }//VERİ GİRİŞ KONTROLÜ
        private void maskedTextBoxKALÇA_Click(object sender, EventArgs e)//VERİ GİRİŞ KONTROLÜ
        {
            maskedTextBoxSAĞKOL.Enabled = true;
        }
        private void maskedTextBoxSAĞKOL_Click(object sender, EventArgs e)
        {
            maskedTextBoxSOLKOL.Enabled = true;
        }//VERİ GİRİŞ KONTROLÜ
        private void maskedTextBoxSOLKOL_Click(object sender, EventArgs e)
        {
            maskedTextBoxBEL.Enabled = true;
        }//VERİ GİRİŞ KONTROLÜ
        private void maskedTextBoxBEL_Click(object sender, EventArgs e)
        {
            maskedTextBoxGÖĞÜS.Enabled = true;
        }//VERİ GİRİŞ KONTROLÜ
        private void maskedTextBoxKİLO_Leave(object sender, EventArgs e)
        {
            
            VK.VKİHESAPLA(maskedTextBoxBOY,maskedTextBoxKİLO,labelVKDURUM,maskedTextBoxVKİNDEX);
        }//VÜCUT KİTLE İNDEXİ HESAPLAMA
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxAD.Text != "" && textBoxFOTO.Text != "" && textBoxSOYAD.Text != "" && numericUpDownYAŞ.Value != null || numericUpDownYAŞ.Value != 0 && richTextBoxKISANOT.Text != "" && maskedTextBoxBEL.Text != "" && maskedTextBoxBOY.Text != ""&&maskedTextBoxGÖĞÜS.Text!=""&&maskedTextBoxKİLO.Text!="" )
            {
            SP.GÜNCELLE(labelID,textBoxAD,textBoxSOYAD,maskedTextBoxTC,maskedTextBoxTELEFON,maskedTextBoxVKİNDEX,numericUpDownYAŞ,dateTimePicker1,maskedTextBoxSOLKOL,maskedTextBoxSAĞKOL,maskedTextBoxBEL,maskedTextBoxBOY,maskedTextBoxKİLO,textBoxFOTO,maskedTextBoxKALÇA,richTextBoxKISANOT,maskedTextBoxGÖĞÜS,radioButtonöğrenci,radioButtonyetişkin,radioButtonERKEK,radioButtonKADIN);
            SP.ADAGÖRESIRALA(textBox1, dataGridView8);
            textBoxAD.Text = "";
                textBoxFOTO.Text = "";
                textBoxSOYAD.Text = "";
                numericUpDownYAŞ.Value = 0;
                maskedTextBoxBEL.Text = "";
                maskedTextBoxBOY.Text = "";
                maskedTextBoxGÖĞÜS.Text = "";
                pictureBox3.ImageLocation = "";
                labelVKDURUM.Text = "";
                maskedTextBoxKALÇA.Text = "";
                maskedTextBoxKİLO.Text = "";
                maskedTextBoxSAĞKOL.Text = "";
                labelID.Text = "";
                maskedTextBoxSOLKOL.Text = "";
                dateTimePicker1.Text = "";
                maskedTextBoxTC.Text = "";
                maskedTextBoxTELEFON.Text = "";
                maskedTextBoxVKİNDEX.Text = "";
                richTextBoxKISANOT.Text = "";
                radioButtonERKEK.Checked = false;
                radioButtonKADIN.Checked = false;
                radioButtonyetişkin.Checked = false;
                radioButtonöğrenci.Checked = false;
                SP.hepsinilistele(dataGridView8);   
            }
            else
            {
                MessageBox.Show("BOŞ ALAN BIRAKILAMAZ!!!");
            }
        }//GÜNCELLE BUTONU

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBoxFOTO.Text = openFileDialog1.FileName;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
