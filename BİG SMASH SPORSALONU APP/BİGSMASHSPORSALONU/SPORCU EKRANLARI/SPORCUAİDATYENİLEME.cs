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
    public partial class SPORCUAİDATYENİLEME : Form
    {
        public SPORCUAİDATYENİLEME()
        {
            InitializeComponent();
        }
        //////////////////////////////////DEĞİŞKENLER VE SINIFTAN FONKSİYON ÇEKME
        private int kaçay;
        private int ID;
        public int ID1
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }
        VARİABLESFİYATHESAPLA vf = new VARİABLESFİYATHESAPLA();
        SPORCUFONKSİYONLARI SP = new SPORCUFONKSİYONLARI();
        KASAFONKSİYONLARI ks = new KASAFONKSİYONLARI();
        //*//////////////////////////////////////////
        private void SPORCUAİDATYENİLEME_Load(object sender, EventArgs e)
        {
            comboBoxindirim.Text = "0";
            labelID.Text = ID1.ToString();
            if (labelID.Text != "0")
            {
                SP.IDBELİRLİSPORCUBİLGİGETİR(pictureBox3,ID1, textBoxAD, textBoxSOYAD, maskedTextBoxTC, maskedTextBoxTELEFON, radioButtonERKEK, radioButtonKADIN, numericUpDownYAŞ, textBoxFOTO, richTextBoxKISANOT, labelÜYELİKDURUMU, radioButtonyetişkin, radioButtonöğrenci, dateTimePickerKAYITTARİHİ, dateTimePickerKAYITBİTİŞTARİHİ);
                SQLBAGLANTI.BAGLANTI.Close();
            }
            else
            {
                SP.HEPSİNİLİSTELE(dataGridView1);
            }
 }//SAYFA LOAD
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }//BTN GERİ GEL
        private void dateTimePickerKAYITTARİHİ_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerKAYITBİTİŞTARİHİ.Value = dateTimePickerKAYITTARİHİ.Value.AddMonths(1);
        }//ay sayısının hesaplanması
        private void numericUpDownÜYELİKAYSAYISI_ValueChanged(object sender, EventArgs e)
        {
            kaçay = Convert.ToInt32(numericUpDownÜYELİKAYSAYISI.Value);
            dateTimePickerKAYITBİTİŞTARİHİ.Value = dateTimePickerKAYITTARİHİ.Value.AddMonths(kaçay);
            vf.FİYATHESAPLA(numericUpDownÜYELİKAYSAYISI, radioButtonNAKİT, radioButtonKREDİKARTI, radioButtonöğrenci, radioButtonyetişkin, comboBoxindirim, textBoxtutar);
        }//ay sayısının hesaplanması
        private void comboBoxindirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            vf.FİYATHESAPLA(numericUpDownÜYELİKAYSAYISI, radioButtonNAKİT, radioButtonKREDİKARTI, radioButtonöğrenci, radioButtonyetişkin, comboBoxindirim, textBoxtutar);
        }//fiyatın hesaplanması
        private void radioButtonNAKİT_CheckedChanged(object sender, EventArgs e)
        {
            vf.FİYATHESAPLA(numericUpDownÜYELİKAYSAYISI, radioButtonNAKİT, radioButtonKREDİKARTI, radioButtonöğrenci, radioButtonyetişkin, comboBoxindirim, textBoxtutar);
        }//fiyatın hesaplanması
        private void radioButtonKREDİKARTI_CheckedChanged(object sender, EventArgs e)
        {
            vf.FİYATHESAPLA(numericUpDownÜYELİKAYSAYISI, radioButtonNAKİT, radioButtonKREDİKARTI, radioButtonöğrenci, radioButtonyetişkin, comboBoxindirim, textBoxtutar);
        }//fiyatın hesaplanması
        private void radioButtonyetişkin_CheckedChanged(object sender, EventArgs e)
        {
            vf.FİYATHESAPLA(numericUpDownÜYELİKAYSAYISI, radioButtonNAKİT, radioButtonKREDİKARTI, radioButtonöğrenci, radioButtonyetişkin, comboBoxindirim, textBoxtutar);
        }//fiyatın hesaplanması
        private void radioButtonöğrenci_CheckedChanged(object sender, EventArgs e)
        {
            vf.FİYATHESAPLA(numericUpDownÜYELİKAYSAYISI, radioButtonNAKİT, radioButtonKREDİKARTI, radioButtonöğrenci, radioButtonyetişkin, comboBoxindirim, textBoxtutar);
        }//fiyatın hesaplanması
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                labelID.Text = "";
                SP.ADAGÖRELİSTELE(textBox1, dataGridView1);
            }
            catch (Exception)
            {
                MessageBox.Show("BAĞLANTI HATASI LÜTFEN YENİDEN DENEYİN");
            }
            
        }//AD'A GÖRE ARANAN SPORCU BİLGİLERİ GÜNCELLEME
        private void button2_Click(object sender, EventArgs e)//GÜNCELLEME BUTONU
        {
            if ( textBoxAD.Text!="" &&textBoxFOTO.Text!=""&&textBoxSOYAD.Text!=""&&textBoxtutar.Text!=""&&numericUpDownÜYELİKAYSAYISI.Value!=0)
            {
                if (radioButtonKREDİKARTI.Checked == true || radioButtonNAKİT.Checked == true )
                {
                    SP.ÜYELİKYENİLEME(labelID, dateTimePickerKAYITTARİHİ, dateTimePickerKAYITBİTİŞTARİHİ, numericUpDownÜYELİKAYSAYISI, textBoxAD, textBoxSOYAD);
                    ks.ANAKASAEKLE(textBoxtutar, dateTimePickerKAYITTARİHİ);
                    ks.KASAYASPORCUAİDATEKLE(textBoxtutar, comboBoxindirim, dateTimePickerKAYITTARİHİ, labelID,numericUpDownÜYELİKAYSAYISI);
                    SP.HEPSİNİLİSTELE(dataGridView1);
                    textBoxAD.Text = "";
                    textBoxFOTO.Text = "";
                    maskedTextBoxTC.Text = "";
                    richTextBoxKISANOT.Text = "";
                    labelÜYELİKDURUMU.Text = "";
                    textBoxSOYAD.Text = "";
                    labelID.Text = "";
                    maskedTextBoxTELEFON.Text = "";
                    numericUpDownYAŞ.Value = 0;
                    numericUpDownÜYELİKAYSAYISI.Value = 0;
                    radioButtonNAKİT.Checked = false;
                    radioButtonKREDİKARTI.Checked = false;
                    textBoxtutar.Text = "";
                    dateTimePickerKAYITTARİHİ.Text = "";
                    dateTimePickerKAYITBİTİŞTARİHİ.Text = "";
                    comboBoxindirim.Text = "0";
                    radioButtonERKEK.Checked = false;
                    radioButtonKADIN.Checked = false;
                    radioButtonyetişkin.Checked = false;
                    radioButtonöğrenci.Checked = false;
                    labelID.Text = "";
                }
                else
                {
                    MessageBox.Show("lütfen ödeme türü seçiniz!!!");
                }
               
            }
            else
            {
                MessageBox.Show("BOŞ KAYIT GÜNCELLENEMEZ!!!");
                textBoxAD.Text = "";
                textBoxFOTO.Text = "";
                textBoxSOYAD.Text = "";
                richTextBoxKISANOT.Text = "";
                maskedTextBoxTC.Text = "";
                maskedTextBoxTELEFON.Text = "";
                radioButtonNAKİT.Checked = false;
                radioButtonKREDİKARTI.Checked = false;
                numericUpDownYAŞ.Value = 0;
                numericUpDownÜYELİKAYSAYISI.Value = 0;
                textBoxtutar.Text = "";
                dateTimePickerKAYITTARİHİ.Text = "";
                dateTimePickerKAYITBİTİŞTARİHİ.Text = "";
                comboBoxindirim.Text = "0";
                radioButtonERKEK.Checked = false;
                radioButtonKADIN.Checked = false;
                radioButtonyetişkin.Checked = false;
                radioButtonöğrenci.Checked = false;
                labelID.Text = "";
            }
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SP.DATAGRİDVİEWDENTEXTBOXLARAVERİAKTAR(pictureBox3,dataGridView1, labelID, textBoxAD, textBoxSOYAD, maskedTextBoxTC, numericUpDownYAŞ, radioButtonERKEK, radioButtonKADIN, radioButtonöğrenci, radioButtonyetişkin, richTextBoxKISANOT, dateTimePickerKAYITTARİHİ, dateTimePickerKAYITBİTİŞTARİHİ, maskedTextBoxTELEFON, labelÜYELİKDURUMU, textBoxFOTO);
        }//DATA GRİD İLE VERİ AKTAR
    }
}
