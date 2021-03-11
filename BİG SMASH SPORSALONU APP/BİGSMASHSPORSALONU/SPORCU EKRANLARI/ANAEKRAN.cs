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
using System.Data.SqlClient;

namespace BİGSMASHSPORSALONU
{
    public partial class ANAEKRAN : Form
    {
        public ANAEKRAN()
        {
            InitializeComponent();
        }
        //////////////////////////////////////////////FONKSİYON CLASSLARINI GETİRME
        SPORCUFONKSİYONLARI SP = new SPORCUFONKSİYONLARI();
        VARİABLESAYHESAPLA vr = new VARİABLESAYHESAPLA();
        VARİABLESFİYATHESAPLA VF = new VARİABLESFİYATHESAPLA();
        VKİNDEXHESAPLA VK = new VKİNDEXHESAPLA();
        KASAFONKSİYONLARI KS = new KASAFONKSİYONLARI();
        //*///////////////////////////////////////////////////////   
        private void ANAEKRAN_Load(object sender, EventArgs e)
        {
            SQLBAGLANTI.BAGLANTI.Close();
            maskedTextBoxKALÇA.Enabled = false;
            maskedTextBoxGÖĞÜS.Enabled = false;
            maskedTextBoxSAĞKOL.Enabled = false;
            maskedTextBoxSOLKOL.Enabled = false;
            maskedTextBoxBEL.Enabled = false;
            maskedTextBoxKİLO.Enabled = false;
            comboBoxindirim.SelectedIndex = 0;
            comboBoxindirim.Text = "0";
            radioButtonNAKİT.Checked = true;
            radioButtonyetişkin.Checked = true;           
            DateTime TARİH = new DateTime();
            TARİH = DateTime.Now;
            labelTARİH.Text = TARİH.ToString();
            SP.SONSPORCUIDBUL(label31); 
        }//LOAD DA ÇALIŞICAK FONKSİYONLAR
        private void button1_Click(object sender, EventArgs e)//ÇIKIŞ BUTONU
        {
            Application.Exit();
        }
        private void numericUpDownÜYELİKAYSAYISI_ValueChanged(object sender, EventArgs e)
        {
            
           vr.ayhesapla(numericUpDownÜYELİKAYSAYISI,dateTimePickerKAYITTARİHİ,dateTimePickerKAYITBİTİŞTARİHİ);
           VF.FİYATHESAPLA(numericUpDownÜYELİKAYSAYISI,radioButtonNAKİT,radioButtonKREDİKARTI,radioButtonöğrenci,radioButtonyetişkin,comboBoxindirim,textBoxtutar);
        }//AY SAYISI BELİRTME
        private void comboBoxindirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            VF.FİYATHESAPLA(numericUpDownÜYELİKAYSAYISI, radioButtonNAKİT, radioButtonKREDİKARTI, radioButtonöğrenci, radioButtonyetişkin, comboBoxindirim, textBoxtutar);
        }//İNDİRİM MİKTARININ DEĞİŞMESİ
        private void radioButtonyetişkin_CheckedChanged(object sender, EventArgs e)
        {
           VF.FİYATHESAPLA(numericUpDownÜYELİKAYSAYISI, radioButtonNAKİT, radioButtonKREDİKARTI, radioButtonöğrenci, radioButtonyetişkin, comboBoxindirim, textBoxtutar);
        }//ÖĞRENİM DURUMU BELİRTİLMESİ
        private void radioButtonöğrenci_CheckedChanged(object sender, EventArgs e)
        {
           VF.FİYATHESAPLA(numericUpDownÜYELİKAYSAYISI, radioButtonNAKİT, radioButtonKREDİKARTI, radioButtonöğrenci, radioButtonyetişkin, comboBoxindirim, textBoxtutar);
        }//ÖĞRENİM DURUMU BELİRTİLMESİ
        private void radioButtonKREDİKARTI_CheckedChanged(object sender, EventArgs e)
        {
           VF.FİYATHESAPLA(numericUpDownÜYELİKAYSAYISI, radioButtonNAKİT, radioButtonKREDİKARTI, radioButtonöğrenci, radioButtonyetişkin, comboBoxindirim, textBoxtutar);
        }//ÖDEME ŞEKLİ BELİRTİLMESİ
        private void maskedTextBoxKİLO_Leave(object sender, EventArgs e)
        {
            VK.VKİHESAPLA(maskedTextBoxBOY,maskedTextBoxKİLO,labelVKDURUM,maskedTextBoxVKİNDEX);
        }//KİLO VE BOY BELİRTİLİP TEXTBOXDAN AYRILINCA VÜCUT KİTLE İNDEXİ HESAPLANIR
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            YENİÇALIŞANKAYIT YN = new YENİÇALIŞANKAYIT();
            YN.Show();
        }//STRİP MENU CLİCK İLE İLGİLİ SAYFAYA YÖNLENDİRME
        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            SPORCUAİDATYENİLEME AD = new SPORCUAİDATYENİLEME();
            AD.Show();
        }//STRİP MENU CLİCK İLE İLGİLİ SAYFAYA YÖNLENDİRME
        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            ÇALIŞANGÜNCELLE CN = new ÇALIŞANGÜNCELLE();
            CN.Show();
        }//STRİP MENU CLİCK İLE İLGİLİ SAYFAYA YÖNLENDİRME
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            ÜYELİĞİDOLANSPORCULAR UY = new ÜYELİĞİDOLANSPORCULAR();
            UY.Show();
        }//STRİP MENU CLİCK İLE İLGİLİ SAYFAYA YÖNLENDİRME
        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            SPORCUBİLGİGÜNCELLE SC = new SPORCUBİLGİGÜNCELLE();
            SC.Show();

        }//STRİP MENU CLİCK İLE İLGİLİ SAYFAYA YÖNLENDİRME
        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            KASAHARAKETLER KS = new KASAHARAKETLER();
            KS.Show();
        }//STRİP MENU CLİCK İLE İLGİLİ SAYFAYA YÖNLENDİRME
        private void button2_Click(object sender, EventArgs e)
        {
            KS.ANAKASAEKLE(textBoxtutar, dateTimePickerKAYITTARİHİ);
            SP.SPORCUEKLE(textBoxAD, textBoxSOYAD, textBox1, radioButtonERKEK, radioButtonKADIN, radioButtonöğrenci, radioButtonyetişkin, dateTimePickerKAYITTARİHİ, dateTimePickerKAYITBİTİŞTARİHİ, richTextBoxKISANOT, textBoxFOTO, maskedTextBoxBOY, maskedTextBoxKİLO, maskedTextBoxBEL, maskedTextBoxGÖĞÜS, maskedTextBoxSAĞKOL, maskedTextBoxSOLKOL, maskedTextBoxKALÇA, maskedTextBoxVKİNDEX, maskedTextBoxTELEFON, maskedTextBoxTC, labelVKDURUM);
            KS.KASAYASPORCUAİDATEKLE(textBoxtutar,comboBoxindirim,dateTimePickerKAYITTARİHİ,label31,numericUpDownÜYELİKAYSAYISI);
           
        }//KAYIT BUTONU
        private void button3_Click(object sender, EventArgs e)
        {
            EKSTRAGELİR EK = new EKSTRAGELİR();
            EK.Show();
        }//İLGİLİ SAYFAYA YÖNLENDİRME
        private void maskedTextBoxBOY_TextChanged(object sender, EventArgs e)
        {
            maskedTextBoxKİLO.Enabled = true;
        }//VERİ GİRİŞİ YAPILMADAN BİR SONRAKİ GİRİŞİ ENGELLER
        private void maskedTextBoxKİLO_MouseHover(object sender, EventArgs e)
        {
            if (maskedTextBoxKİLO.Enabled == false)
            {
                MessageBox.Show("LÜTFEN ÖNCE BOY BİLGİSİNİ DOLDURUN");
                maskedTextBoxBOY.Focus();
            }
        }//VERİ GİRİŞİ YAPILMADAN BİR SONRAKİ GİRİŞİ ENGELLER
        private void maskedTextBoxKİLO_TextChanged(object sender, EventArgs e)
        {
            maskedTextBoxBEL.Enabled = true;
        }//VERİ GİRİŞİ YAPILMADAN BİR SONRAKİ GİRİŞİ ENGELLER
        private void maskedTextBoxBEL_TextChanged(object sender, EventArgs e)
        {
            maskedTextBoxGÖĞÜS.Enabled = true;
        }//VERİ GİRİŞİ YAPILMADAN BİR SONRAKİ GİRİŞİ ENGELLER
        private void maskedTextBoxGÖĞÜS_TextChanged(object sender, EventArgs e)
        {
            maskedTextBoxSAĞKOL.Enabled = true;
        }//VERİ GİRİŞİ YAPILMADAN BİR SONRAKİ GİRİŞİ ENGELLER
        private void maskedTextBoxSAĞKOL_TextChanged(object sender, EventArgs e)
        {
            maskedTextBoxSOLKOL.Enabled = true;
        }//VERİ GİRİŞİ YAPILMADAN BİR SONRAKİ GİRİŞİ ENGELLER
        private void maskedTextBoxSOLKOL_TextChanged(object sender, EventArgs e)
        {
            maskedTextBoxKALÇA.Enabled = true;
        }//VERİ GİRİŞİ YAPILMADAN BİR SONRAKİ GİRİŞİ ENGELLER
        private void comboBoxindirim_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            VF.FİYATHESAPLA(numericUpDownÜYELİKAYSAYISI, radioButtonNAKİT, radioButtonKREDİKARTI, radioButtonöğrenci, radioButtonyetişkin, comboBoxindirim, textBoxtutar);
        }//VERİ GİRİŞİ YAPILMADAN BİR SONRAKİ GİRİŞİ ENGELLER
        private void dateTimePickerKAYITTARİHİ_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerKAYITBİTİŞTARİHİ.Value = dateTimePickerKAYITTARİHİ.Value.AddDays(30);
        }//VERİ GİRİŞİ YAPILMADAN BİR SONRAKİ GİRİŞİ ENGELLER

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBoxFOTO.Text = openFileDialog1.FileName;
        }
    }
}

