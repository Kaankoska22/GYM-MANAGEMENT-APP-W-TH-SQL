using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTİTYLAYER;
using FACADLAYER;
using BUSİNESSLOGİCLAYER;

namespace BİGSMASHSPORSALONU
{
  public  class ÇALIŞANFONKSİYONLARI
    {
        /////////////////////////ÇALIŞAN GÜNCELLEME FONKSİYONU
        public void GÜNCELLE(Label ID, TextBox AD, MaskedTextBox ŞİFRE, TextBox SOYAD, MaskedTextBox TC, MaskedTextBox TELEFON, NumericUpDown YAŞ, RadioButton ERKEK, RadioButton KADIN, TextBox FOTO, RichTextBox KISANOT)
        {
            ÇALIŞANENTİTYCLASS CA = new ÇALIŞANENTİTYCLASS();
            CA.ID = Convert.ToInt32(ID.Text);
            CA.AD = AD.Text;
            CA.ŞİFRE = Convert.ToInt32(ŞİFRE.Text);
            CA.SOYAD = SOYAD.Text;
            CA.TC = TC.Text;
            CA.TELEFON = TELEFON.Text;
            CA.YAŞ = Convert.ToInt32(YAŞ.Value);
            if (ERKEK.Checked == true)
            {
                CA.CİNSİYET = "ERKEK";
            }
            if (KADIN.Checked == true)
            {
                CA.CİNSİYET = "KADIN";
            }
            if (ERKEK.Checked == false && KADIN.Checked == false)
            {
                MessageBox.Show("CİNSİYET BOŞ BIRAKILAMAZ!!!");
            }
            CA.FOTO = FOTO.Text;
            CA.KISANOT = KISANOT.Text;
            BUSİNESSLOGİCLAYER.BLLÇALIŞAN.GÜNCELLE(CA);
            MessageBox.Show("ÇALIŞAN BİLGİLERİ GÜNCELLENDİ!!!");

            AD.Text = "";
            FOTO.Text = "";
            SOYAD.Text = "";
            TC.Text = "";
            TELEFON.Text = "";
            ŞİFRE.Text = "";
            KISANOT.Text = "";
            ID.Text = "";
            YAŞ.Value = 0;
        }
        //////////////////////////DATAGRİD VERİLERİNİ TEXTBOXA AKTARMA
        public void DATAGRİDENVERİAL(PictureBox foto,Label ID,DataGridView DATAGRİD,TextBox AD,MaskedTextBox ŞİFRE,TextBox SOYAD,MaskedTextBox TC,MaskedTextBox TELEFON,RadioButton ERKEK,RadioButton KADIN,RichTextBox KISANOT,TextBox FOTO,NumericUpDown YAŞ)
        {
            ID.Text = DATAGRİD.CurrentRow.Cells[0].Value.ToString(); //[0] sütun numarası
            AD.Text = DATAGRİD.CurrentRow.Cells[1].Value.ToString(); //[1] sütun numarası
            ŞİFRE.Text = DATAGRİD.CurrentRow.Cells[2].Value.ToString(); //[2] sütun numarası
            SOYAD.Text = DATAGRİD.CurrentRow.Cells[3].Value.ToString(); //[3] sütun numarası
            TC.Text = DATAGRİD.CurrentRow.Cells[4].Value.ToString(); //[4] sütun numarası
            TELEFON.Text = DATAGRİD.CurrentRow.Cells[5].Value.ToString(); //[5] sütun numarası
            if (DATAGRİD.CurrentRow.Cells[6].Value.ToString() == "ERKEK")
            {
                ERKEK.Checked = true;
                KADIN.Checked = false;
            }
            if (DATAGRİD.CurrentRow.Cells[6].Value.ToString() == "KADIN")
            {
                ERKEK.Checked = false;
                KADIN.Checked = true;
            }
            KISANOT.Text = DATAGRİD.CurrentRow.Cells[7].Value.ToString(); //[7] sütun numarası
            FOTO.Text = DATAGRİD.CurrentRow.Cells[8].Value.ToString(); //[8] sütun numarası
            foto.ImageLocation= DATAGRİD.CurrentRow.Cells[8].Value.ToString(); //[8] sütun numarası
            YAŞ.Value = Convert.ToInt32(DATAGRİD.CurrentRow.Cells[9].Value); //[9] sütun numarası

        }
        ///// YENİ ÇALIŞAN EKLEME FONKSİYONU
        public void ÇALIŞANEKLE(TextBox AD, MaskedTextBox ŞİFRE,TextBox SOYAD,MaskedTextBox TC, RadioButton ERKEK,RadioButton KADIN,MaskedTextBox TELEFON,NumericUpDown YAŞ,RichTextBox KISANOT,TextBox FOTO)
        {
            ÇALIŞANENTİTYCLASS CA = new ÇALIŞANENTİTYCLASS();
            CA.AD = AD.Text;
            CA.ŞİFRE = Convert.ToInt32(ŞİFRE.Text);
            CA.SOYAD = SOYAD.Text;
            CA.TC = TC.Text;
            if (ERKEK.Checked == true)
            {
                CA.CİNSİYET = "ERKEK";
            }
            if (KADIN.Checked == true)
            {
                CA.CİNSİYET = "KADIN";
            }
            if (KADIN.Checked == false && ERKEK.Checked == false)
            {
                MessageBox.Show("LÜTFEN CİNSİYETİ BELİRTİNİZ!!!");
            }
            CA.TELEFON = TELEFON.Text;
            CA.YAŞ = Convert.ToInt32(YAŞ.Value);
            CA.KISANOT = KISANOT.Text;
            CA.FOTO = FOTO.Text;
            BLLÇALIŞAN.EKLE(CA);
            MessageBox.Show("ÇALIŞAN EKLENDİ!!!");
            AD.Text = "";
            FOTO.Text = "";
            SOYAD.Text = "";
            ŞİFRE.Text = "";
            TELEFON.Text = "";
            TC.Text = "";
            KISANOT.Text = "";
            YAŞ.Value = 0;


        }
    }
}
