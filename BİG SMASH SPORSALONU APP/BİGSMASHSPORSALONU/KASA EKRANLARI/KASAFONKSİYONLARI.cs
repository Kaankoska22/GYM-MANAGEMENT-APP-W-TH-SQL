using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENTİTYLAYER;
using FACADLAYER;
using BUSİNESSLOGİCLAYER;
using System.Windows.Forms;
using System.Drawing;

namespace BİGSMASHSPORSALONU
{
   public class KASAFONKSİYONLARI
    {
        SPORCUFONKSİYONLARI SP = new SPORCUFONKSİYONLARI();
        public void KASAYASPORCUAİDATEKLE(TextBox TUTAR,ComboBox İNDİRİM,DateTimePicker KAYIT,Label ID,NumericUpDown AY)
        {
            SPORCUHARAKETENTİTYCLASS KA = new SPORCUHARAKETENTİTYCLASS();
            KA.ALINANÜCRET = Convert.ToInt32(TUTAR.Text);
            KA.YAPILANİNDİRİM = Convert.ToInt32(İNDİRİM.Text);
            KA.İŞLEM = "YENİ ÜYE KAYIT GELİRİ";
            KA.TARİH = Convert.ToDateTime(KAYIT.Text);
            KA.SPORCUID = Convert.ToInt32(ID.Text);///last ıd +1 yapılacak
            BUSİNESSLOGİCLAYER.BLLKASASPORCU.EKLE(KA);
            SP.LASTID += 1;
            İNDİRİM.Text = "0";
            AY.Value = 0;
            KAYIT.Text = "";
            ID.Text = "";
            TUTAR.Text = "0";
        } //KASAYA SPORCU AİDAT ÜCRETİ EKLEME
        public void ANAKASAEKLE(TextBox TUTAR,DateTimePicker KAYIT)
        {
            ANAKASAENTİTY KN = new ANAKASAENTİTY();
            if (TUTAR.Text!=""&&KAYIT.Text!="")
            {
                KN.TUTAR = Convert.ToInt32(TUTAR.Text);
                KN.TARİH = Convert.ToDateTime(KAYIT.Text);
                BUSİNESSLOGİCLAYER.BLLANAKASA.EKLE(KN);
            }
            else
            {
                MessageBox.Show("BOŞ ALAN BIRAKILAMAZ!!!");
            }
           
        }//ANA KASAYA GELİRİ EKLEME
        public void EKSTRAGELİREEKLE(TextBox TUTAR,RichTextBox NOT,DateTimePicker TARİH)
        {
            EKSTRAHARAKETENTİTYCLASS KN = new EKSTRAHARAKETENTİTYCLASS();
            if (TUTAR.Text!="" && TUTAR.Text!="0" && TARİH.Text!="")
            {

                KN.ALINANÜCRET = Convert.ToInt32(TUTAR.Text);
                KN.NOT = NOT.Text;
                KN.TARİH = Convert.ToDateTime(TARİH.Text);
                BUSİNESSLOGİCLAYER.BLLKASAEKSTRAGELİR.EKLE(KN);
                MessageBox.Show(TUTAR.Text + " " + "TL" + " " + "MİKTARINDA TUTAR" + " " + NOT.Text + " " + "SEBEBİ İLE ANA KASAYA EKLENDİ !!!");
                TUTAR.Text = "";
                NOT.Text = "";
                TARİH.Text = "";
            }
            else
            {
                MessageBox.Show("BOŞ ALAN BIRAKILAMAZ!!");
            }
           
        }
        public void SEÇİLENTARİHEGÖREAİDATÖDEMELERİ(DateTimePicker DATE,DataGridView DATA)
        {
            SqlCommand KOMUT = new SqlCommand("SELECT * FROM TBLSPORCUHARAKET WHERE TARİH=@P1",SQLBAGLANTI.BAGLANTI);
            KOMUT.CommandType = CommandType.Text;
            if (KOMUT.Connection.State!=ConnectionState.Open)
            {
                KOMUT.Connection.Open();
            }
            KOMUT.Parameters.AddWithValue("@P1",Convert.ToDateTime(DATE.Text));
            SqlDataAdapter da = new SqlDataAdapter(KOMUT);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DATA.DataSource = dt;

        }
        public void KASATOPLAM(DateTimePicker DATE, DataGridView DATA)
        {
            SqlCommand KOMUT = new SqlCommand("SELECT * FROM TBLKASA WHERE TARİH=@P1", SQLBAGLANTI.BAGLANTI);
            KOMUT.CommandType = CommandType.Text;
            if (KOMUT.Connection.State != ConnectionState.Open)
            {
                KOMUT.Connection.Open();
            }
            KOMUT.Parameters.AddWithValue("@P1", Convert.ToDateTime(DATE.Text));
            SqlDataAdapter da = new SqlDataAdapter(KOMUT);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DATA.DataSource = dt;

        }
        public void KASAEKSTRAGELİRLERİGÖSTER(DateTimePicker DATE, DataGridView DATA)
        {
            SqlCommand KOMUT = new SqlCommand("SELECT ALINANÜCRET,İŞLEM,TARİH FROM TBLEKSTRAHARAKET WHERE TARİH=@P1", SQLBAGLANTI.BAGLANTI);
            KOMUT.CommandType = CommandType.Text;
            if (KOMUT.Connection.State != ConnectionState.Open)
            {
                KOMUT.Connection.Open();
            }
            KOMUT.Parameters.AddWithValue("@P1", Convert.ToDateTime(DATE.Text));
            SqlDataAdapter da = new SqlDataAdapter(KOMUT);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DATA.DataSource = dt;

        }
        public void KASAEKSTRAGELİRLERİGÖSTERAYRINTI(DateTimePicker DATE, DataGridView DATA)
        {
            SqlCommand KOMUT = new SqlCommand("SELECT  AD,SOYAD,ALINANÜCRET,YAPILANİNDİRİM,İŞLEM,TARİH FROM TBLSPORCUHARAKET inner join TBLSPORCU on TBLSPORCUHARAKET.SPORCUID=TBLSPORCU.ID WHERE TARİH=@P1", SQLBAGLANTI.BAGLANTI);
            KOMUT.CommandType = CommandType.Text;
            if (KOMUT.Connection.State != ConnectionState.Open)
            {
                KOMUT.Connection.Open();
            }
            KOMUT.Parameters.AddWithValue("@P1", Convert.ToDateTime(DATE.Text));
            SqlDataAdapter da = new SqlDataAdapter(KOMUT);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DATA.DataSource = dt;

        }
        public void EKSTRAGELİRLERAYRINTI(DateTimePicker DATE, DataGridView DATA)
        {
            SqlCommand KOMUT = new SqlCommand("SELECT ALINANÜCRET,İŞLEM,TARİH FROM TBLEKSTRAHARAKET WHERE TARİH=@P1", SQLBAGLANTI.BAGLANTI);
            KOMUT.CommandType = CommandType.Text;
            if (KOMUT.Connection.State != ConnectionState.Open)
            {
                KOMUT.Connection.Open();
            }
            KOMUT.Parameters.AddWithValue("@P1", Convert.ToDateTime(DATE.Text));
            SqlDataAdapter da = new SqlDataAdapter(KOMUT);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DATA.DataSource = dt;

        }
    }
}
