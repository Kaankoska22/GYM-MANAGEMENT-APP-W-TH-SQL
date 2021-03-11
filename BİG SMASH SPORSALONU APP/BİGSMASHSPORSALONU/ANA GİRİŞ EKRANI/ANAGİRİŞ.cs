using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ENTİTYLAYER;
using FACADLAYER;

namespace BİGSMASHSPORSALONU
{
    public partial class ANAGİRİŞ : Form
    {
        public ANAGİRİŞ()
        {
            InitializeComponent();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bigsmashgym.com/");
        }//LİNK LABEL SİTE LİNKİ
        private void ANAGİRİŞ_Load(object sender, EventArgs e)
        {
            DateTime tarihgün = new DateTime();
            tarihgün = DateTime.Now;
            labelTARİH.Text = tarihgün.ToString();
        }//EKRAN YÜKLENİNCE ÇALIŞICAK FONKSİYON
        private void textBoxAD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = maskedTextBoxŞİFRE;
            }
        }//ENTER KEYDOWN İLE TEXTBOX GEÇİŞLERİ
        private void maskedTextBoxŞİFRE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = button1;
            }
        }//ENTER KEYDOWN İLE TEXTBOX GEÇİŞLERİ
        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = linkLabel1;
            }
        }//ENTER KEYDOWN İLE TEXTBOX GEÇİŞLERİ
        private void button1_Click(object sender, EventArgs e)
        {

            SQLBAGLANTI.BAGLANTI.Close();

            SqlCommand KOMUT = new SqlCommand("SELECT AD,ŞİFRE FROM TBLÇALIŞAN  WHERE AD=@P1 AND ŞİFRE=@P2", SQLBAGLANTI.BAGLANTI);
            KOMUT.CommandType = CommandType.Text;
            if (KOMUT.Connection.State != ConnectionState.Open)
            {
                KOMUT.Connection.Open();
            }
            KOMUT.Parameters.AddWithValue("@P1",textBoxAD.Text);
            KOMUT.Parameters.AddWithValue("@P2", maskedTextBoxŞİFRE.Text);
            SqlDataReader DR = KOMUT.ExecuteReader();
            if (DR.Read())
            {
                ANAEKRAN AN = new ANAEKRAN();
                AN.Show();
                this.Hide();
                SQLBAGLANTI.BAGLANTI.Close();

            }
            else
            {
                MessageBox.Show("KULLANICINIZ YADA ŞİFRE YANLIŞ!!");
                textBoxAD.Text = "";
                maskedTextBoxŞİFRE.Text = "";

            }
            SQLBAGLANTI.BAGLANTI.Close();

        }
       
      
        }//BTN ANA EKRANA YÖNLENDİRME
    }

