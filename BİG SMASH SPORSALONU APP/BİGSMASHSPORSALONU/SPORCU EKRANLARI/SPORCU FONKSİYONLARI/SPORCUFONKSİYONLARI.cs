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

   
   public  class SPORCUFONKSİYONLARI
    {
        //*//////////////////////////////////////////////SPORCU ENTİTY CLASSINDAN OBJE 
        SPORCUENTİTYCLASS SP = new SPORCUENTİTYCLASS();
        SPORCUENTİTYCLASS deg = new SPORCUENTİTYCLASS();
        //*/////////////////////////////////////////////DEĞİŞKENLER
        private int _LASTID;
        private int _ID;
        //*////////////////////////////////////////////DEĞİŞKEN PROPERTY
        public int LASTID
        {
            get
            {
                return _LASTID;
            }

            set
            {
                _LASTID = value;
            }
        }
        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
            }
        }
        //*/////////////////////////////////////////////
        //*/////////////////////////////////////////////SPORCU EKLEME FONKSİYONU
        public void hepsinilistele(DataGridView DATA)
        {
            SqlCommand KOMUT = new SqlCommand("select ID,AD,SOYAD,YAŞ,CİNSİYET,ÖĞRENCİDURUMU,KISANOT,FOTO,BOY,KİLO,BEL,GÖĞÜS,KOLSAĞ,KOLSOL,KALÇA,VÜCUTKİTLEİNDEX,DURUM,TELEFON,TC,SONGÜNCELLEME   FROM TBLSPORCU WHERE DURUM=1", SQLBAGLANTI.BAGLANTI);
            KOMUT.CommandType = CommandType.Text;
            if (KOMUT.Connection.State != ConnectionState.Open)
            {
                KOMUT.Connection.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(KOMUT);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DATA.DataSource = dt;


        }
        public void SPORCUEKLE(TextBox AD,TextBox SOYAD,MaskedTextBox YAŞ,RadioButton ERKEK,RadioButton KADIN,RadioButton ÖĞRENCİ,RadioButton YETİŞKİN,DateTimePicker KAYIT,DateTimePicker KAYITBİTİŞ,RichTextBox KISANOT,TextBox FOTO,MaskedTextBox BOY,MaskedTextBox KİLO, MaskedTextBox BEL,MaskedTextBox GÖĞÜS,MaskedTextBox SAĞKOL,MaskedTextBox SOLKOL,MaskedTextBox KALÇA,MaskedTextBox VKİNDEX,MaskedTextBox TELEFON,MaskedTextBox TC,Label VKDURUM)
        {

            try
            {
                SP.AD = AD.Text;
                SP.SOYAD = SOYAD.Text;
                if (YAŞ.Text != "")
                {
                    SP.YAS = Convert.ToInt32(YAŞ.Text);
                }

                if (ERKEK.Checked == true)
                {
                    SP.CİNSİYET = "ERKEK";
                }
                if (KADIN.Checked == true)
                {
                    SP.CİNSİYET = "KADIN";
                }
                if (KADIN.Checked == false && ERKEK.Checked == false)
                {
                    MessageBox.Show("LÜTFEN SPORCUNUN CİNSİYETİNİ BELİRTİNİZ!!!");
                }

                if (ÖĞRENCİ.Checked == true)
                {
                    SP.ÖĞRENCİDURUMU = true;
                }
                if (YETİŞKİN.Checked == true)
                {
                    SP.ÖĞRENCİDURUMU = false;
                }
                if (ÖĞRENCİ.Checked == false && YETİŞKİN.Checked == false)
                {
                    MessageBox.Show("LÜTFEN SPORCUNUN ÖĞRENCİ DURUMUNU BELİRTİN!!!");
                }
                SP.KAYITTARİHİ = Convert.ToDateTime(KAYIT.Text);
                SP.KAYITBİTİŞTARİHİ = Convert.ToDateTime(KAYITBİTİŞ.Text);
                string NOT = KISANOT.Text;
                byte[] NOSİFRE = ASCIIEncoding.ASCII.GetBytes(NOT);
                string SİFRELİNOT = Convert.ToBase64String(NOSİFRE);
                SP.KISANOT = SİFRELİNOT;

                SP.FOTO = FOTO.Text;
                SP.BOY = Convert.ToDecimal(BOY.Text);
                SP.KİLO = Convert.ToDecimal(KİLO.Text);
                SP.BEL = Convert.ToDecimal(BEL.Text);
                SP.GÖĞÜS = Convert.ToDecimal(GÖĞÜS.Text);
                SP.KOLSAĞ = Convert.ToDecimal(SAĞKOL.Text);
                SP.KOLSOL = Convert.ToDecimal(SOLKOL.Text);
                SP.KALÇA = Convert.ToDecimal(KALÇA.Text);
                SP.VKİNDEX = Convert.ToDecimal(VKİNDEX.Text);
                SP.TELEFON = TELEFON.Text;

                /////////////////////////////TC ŞİFRELEME
                String TCSİ = TC.Text;
                Byte[] VERİ = ASCIIEncoding.ASCII.GetBytes(TCSİ);
                String ŞİFRELİVERİ = Convert.ToBase64String(VERİ);
                SP.TC =ŞİFRELİVERİ;
                //////////////////////////////////////////////
                SP.SONGÜNCELLEME = Convert.ToDateTime(KAYIT.Text);
                MessageBox.Show("YENİ SPORCU KAYDI YAPILDI!!!");
                BUSİNESSLOGİCLAYER.BLLSPORCU.EKLE(SP);
            }
            catch (Exception)
            {

                MessageBox.Show("LÜTFEN BİLGİLERİ DOĞRU GİRİBNİZ!!");
            }


          
            AD.Text = "";
            SOYAD.Text = "";
            YAŞ.Text = "";//YAŞ TEXTBOX I
            FOTO.Text = "";
            KISANOT.Text = "";
            SAĞKOL.Text = "";
            SOLKOL.Text = "";
            KİLO.Text = "";
            GÖĞÜS.Text = "";
            TC.Text = "";
            VKİNDEX.Text = "";
            TELEFON.Text = "";
            BOY.Text = "";
            KALÇA.Text = "";
            VKDURUM.Text = "";
            KAYITBİTİŞ.Text = KAYIT.Text;
            BEL.Text = "";
        }//SPORCU EKLEME FONKSİYONU 
        public void SONSPORCUIDBUL(Label ID)
        {
            SqlCommand KOMUT = new SqlCommand("SELECT ID FROM TBLSPORCU ", SQLBAGLANTI.BAGLANTI);
            if (KOMUT.Connection.State != ConnectionState.Open)
            {
                KOMUT.Connection.Open();

            }
            SqlDataReader DR = KOMUT.ExecuteReader();
            while (DR.Read())
            {
                LASTID = Convert.ToInt16(DR[0]);
            }
            SQLBAGLANTI.BAGLANTI.Close();
            LASTID += 1;
            ID.Text = LASTID.ToString();
            ID.ForeColor = Color.Gold;
            SQLBAGLANTI.BAGLANTI.Close();
        }//SON SPORCU ID Sİ BULMA FONKSİYONU
        public void ÜYELİĞİBİTENSPORCUBİLGİSİGETİR(Label ID,DataGridView DATA,TextBox AD,TextBox SOYAD,NumericUpDown YAŞ,TextBox CİNSİYET,MaskedTextBox TELEFON)
        {
            ID.Text = DATA.CurrentRow.Cells[0].Value.ToString();
            AD.Text = DATA.CurrentRow.Cells[1].Value.ToString();
            SOYAD.Text = DATA.CurrentRow.Cells[2].Value.ToString();
            YAŞ.Value = Convert.ToInt32(DATA.CurrentRow.Cells[3].Value.ToString());
            CİNSİYET.Text = DATA.CurrentRow.Cells[4].Value.ToString();
            TELEFON.Text = DATA.CurrentRow.Cells[5].Value.ToString();
       

        }//DATA GRİD İLE TEXTBOXA BİLGİ ÇEK
        public void ÜYELİKYENİLEME(Label ID,DateTimePicker TARİH,DateTimePicker BİTİŞTARİH,NumericUpDown AY,TextBox AD,TextBox SOYAD)
        {
            
            SqlCommand komut = new SqlCommand("SPORCUAİDATGÜNCELLE", SQLBAGLANTI.BAGLANTI);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@ID",Convert.ToInt32(ID.Text));
            komut.Parameters.AddWithValue("@KAYITTARİHİ",Convert.ToDateTime(TARİH.Text));
            komut.Parameters.AddWithValue("@KAYITBİTİŞTARİHİ", Convert.ToDateTime(BİTİŞTARİH.Text));
            komut.Parameters.AddWithValue("@DURUM", true);
            komut.ExecuteNonQuery();
            MessageBox.Show(AD.Text + " " + SOYAD.Text + " " + "ADLI SPORCUNUN ÜYELİĞİ" + " " + AY.Value + " " + "AY UZATILDI");
            AY.Value = 0;
            AD.Text = "";
            SOYAD.Text = "";
        }//SPORCU ÜYELİK YENİLEME 
        public void DATAGRİDVİEWDENTEXTBOXLARAVERİAKTAR(PictureBox foto1,DataGridView DATA,Label ID,TextBox AD,TextBox SOYAD,MaskedTextBox TC, NumericUpDown YAŞ,RadioButton ERKEK,RadioButton KADIN,RadioButton ÖĞRENCİ,RadioButton YETİŞKİN,RichTextBox KISANOT,DateTimePicker TARİH,DateTimePicker TARİHBİTİŞ,MaskedTextBox TELEFON,Label DURUM,TextBox FOTO)
        {
            ID.Text = DATA.CurrentRow.Cells[0].Value.ToString(); //[0] sütun numarası
            AD.Text = DATA.CurrentRow.Cells[1].Value.ToString(); //[1] sütun numarası
            SOYAD.Text = DATA.CurrentRow.Cells[2].Value.ToString(); //[2] sütun numarası

           
            TC.Text = DATA.CurrentRow.Cells[3].Value.ToString(); //[3] sütun numarası




            YAŞ.Value = Convert.ToInt32(DATA.CurrentRow.Cells[4].Value); //[4] sütun numarası
            if (DATA.CurrentRow.Cells[5].Value.ToString() == "ERKEK")
            {
                ERKEK.Checked = true;
            }
            if (DATA.CurrentRow.Cells[5].Value.ToString() == "KADIN")
            {
                KADIN.Checked = true;
            }
            if (Convert.ToBoolean(DATA.CurrentRow.Cells[6].Value) == true)
            {
                ÖĞRENCİ.Checked = true;
            }
            else
            {
                YETİŞKİN.Checked = true; 
            }
            TARİH.Text = DATA.CurrentRow.Cells[7].Value.ToString();
            TARİHBİTİŞ.Text = DATA.CurrentRow.Cells[8].Value.ToString();
            TELEFON.Text = DATA.CurrentRow.Cells[9].Value.ToString();

            KISANOT.Text = DATA.CurrentRow.Cells[10].Value.ToString();
          
            string NOTCOZ = KISANOT.Text;
            byte[] NOCOZUM = Convert.FromBase64String(NOTCOZ);
            string COZULMUSNOT = ASCIIEncoding.ASCII.GetString(NOCOZUM);
            KISANOT.Text = COZULMUSNOT;

            if (Convert.ToBoolean(DATA.CurrentRow.Cells[11].Value) == true)
            {
                DURUM.Text = "DEVAM EDİYOR";
            }
            else
            {
                DURUM.Text = "DEVAM ETMİYOR";
            }
            FOTO.Text = DATA.CurrentRow.Cells[12].Value.ToString();
            foto1.ImageLocation=DATA.CurrentRow.Cells[12].Value.ToString();


        }//DATAGRİD VERİLERİNİ TEXTBOXLARA AKTARMA
        public void HEPSİNİLİSTELE(DataGridView DATA)
        {
            SqlCommand KOMUT = new SqlCommand("select ID,AD,SOYAD,TC,YAŞ,CİNSİYET,ÖĞRENCİDURUMU,KAYITTARİHİ,KAYITBİTİŞTARİHİ,TELEFON,KISANOT,DURUM,FOTO FROM TBLSPORCU ", SQLBAGLANTI.BAGLANTI);
            KOMUT.CommandType = CommandType.Text;
            if (KOMUT.Connection.State != ConnectionState.Open)
            {
                KOMUT.Connection.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(KOMUT);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DATA.DataSource = dt;
        }//TÜM SPORCULARI LİSTELEME
        public void ADAGÖRELİSTELE(TextBox AD,DataGridView DATA)
        {
            SqlCommand KOMUT = new SqlCommand("SELECT ID,AD,SOYAD,TC,YAŞ,CİNSİYET,ÖĞRENCİDURUMU,KAYITTARİHİ,KAYITBİTİŞTARİHİ,TELEFON,KISANOT,DURUM,FOTO FROM TBLSPORCU WHERE AD=@AD", SQLBAGLANTI.BAGLANTI);
            KOMUT.CommandType = CommandType.Text;
            if (KOMUT.Connection.State != ConnectionState.Open)
            {
                KOMUT.Connection.Open();
            }
            KOMUT.Parameters.AddWithValue("@AD", AD.Text);
            SqlDataAdapter da = new SqlDataAdapter(KOMUT);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DATA.DataSource = dt;

        }//AD'A GÖRE SEÇİLEN SPORCUYU LİSTELEME 
        public void IDBELİRLİSPORCUBİLGİGETİR(PictureBox FOTO1,int ID,TextBox AD,TextBox SOYAD,MaskedTextBox TC,MaskedTextBox TELEFON,RadioButton ERKEK,RadioButton KADIN,NumericUpDown YAŞ,TextBox FOTO,RichTextBox KISANOT,Label ÜYELİKDURUMU,RadioButton YETİŞKİN,RadioButton ÖĞRENCİ,DateTimePicker KAYIT,DateTimePicker KAYITBİTİŞ)
        {
            SqlCommand KOMUT = new SqlCommand("IDBELİRLİSPORCUBİLGİGETİR", SQLBAGLANTI.BAGLANTI);
            KOMUT.CommandType = CommandType.StoredProcedure;
            if (KOMUT.Connection.State != ConnectionState.Open)
            {
                KOMUT.Connection.Open();
            }
            KOMUT.Parameters.Add("@ID",ID);
            SqlDataReader DR = KOMUT.ExecuteReader();
            while (DR.Read())
            {

                AD.Text = Convert.ToString(DR[1]);
                SOYAD.Text = Convert.ToString(DR[2]);
                TC.Text = DR[3].ToString();
                TELEFON.Text = DR[4].ToString();
                if (DR[5].ToString() == "ERKEK")
                {
                    ERKEK.Checked = true;
                }
                if (DR[5].ToString() == "KADIN")
                {
                    KADIN.Checked = true;
                }
                if (Convert.ToInt16(DR[6]) == 0)
                {
                    YETİŞKİN.Checked = true;
                }
                if (Convert.ToInt16(DR[6]) == 1)
                {
                    ÖĞRENCİ.Checked = true;
                }
                YAŞ.Value = Convert.ToInt32(DR[7]);
                FOTO.Text = DR[8].ToString();
                FOTO1.ImageLocation = DR[8].ToString();
                KISANOT.Text = DR[9].ToString();
                string NOTCOZ = KISANOT.Text;
                byte[] NOCOZUM = Convert.FromBase64String(NOTCOZ);
                string COZULMUSNOT = ASCIIEncoding.ASCII.GetString(NOCOZUM);
                KISANOT.Text = COZULMUSNOT;

                int durum = Convert.ToInt16(DR[10]);
                if (durum == 0)
                {
                    ÜYELİKDURUMU.Text = "DEVAM ETMİYOR!!";
                }
                if (durum == 1)
                {
                    ÜYELİKDURUMU.Text = "DEVAM EDİYOR";
                }
                KAYIT.Value = Convert.ToDateTime(DR[11]);
                KAYITBİTİŞ.Value = Convert.ToDateTime(DR[12]);
            }



        }
        public void GÜNCELLE(Label ID,TextBox AD,TextBox SOYAD,MaskedTextBox TC,MaskedTextBox TELEFON,MaskedTextBox VKİNDEX,NumericUpDown YAŞ,DateTimePicker KAYIT,MaskedTextBox SOLKOL,MaskedTextBox SAĞKOL,MaskedTextBox BEL,MaskedTextBox BOY,MaskedTextBox KİLO,TextBox FOTO,MaskedTextBox KALÇA, RichTextBox KISANOT, MaskedTextBox GÖĞÜS,RadioButton ÖĞRENCİ,RadioButton YETİŞKİN,RadioButton ERKEK,RadioButton KADIN)
        {
            SPORCUENTİTYCLASS SP = new SPORCUENTİTYCLASS();
            SP.ID = Convert.ToInt32(ID.Text);
            SP.AD = AD.Text;
            SP.SOYAD = SOYAD.Text;
            SP.TC = TC.Text;
            SP.TELEFON = TELEFON.Text;
            SP.VKİNDEX = Convert.ToDecimal(VKİNDEX.Text);
            SP.YAS = Convert.ToInt32(YAŞ.Value);
            SP.SONGÜNCELLEME = Convert.ToDateTime(KAYIT.Text);
            SP.KOLSAĞ = Convert.ToDecimal(SAĞKOL.Text);
            SP.KOLSOL = Convert.ToDecimal(SOLKOL.Text);
            string NOT = KISANOT.Text;
            byte[] NOSİFRE = ASCIIEncoding.ASCII.GetBytes(NOT);
            string SİFRELİNOT = Convert.ToBase64String(NOSİFRE);
            SP.KISANOT = SİFRELİNOT;
            SP.GÖĞÜS = Convert.ToDecimal(GÖĞÜS.Text);
            SP.KALÇA = Convert.ToDecimal(KALÇA.Text);
            SP.KİLO = Convert.ToDecimal(KİLO.Text);
            SP.BEL = Convert.ToDecimal(BEL.Text);
            SP.BOY = Convert.ToDecimal(BOY.Text);
            SP.FOTO = FOTO.Text;
            if (ÖĞRENCİ.Checked == true)
            {
                SP.ÖĞRENCİDURUMU = true;
            }
            if (YETİŞKİN.Checked==true)
            {
                SP.ÖĞRENCİDURUMU = false;
            }
            if(ÖĞRENCİ.Checked == false && YETİŞKİN.Checked == false)
            {
                MessageBox.Show("SPORCUNU ÖĞRENCİLİK DURUMUNU BELİRTİNİZ!!");
            }

            if (ERKEK.Checked == true)
            {
                SP.CİNSİYET = "ERKEK";
            }
            if (KADIN.Checked==true)
            {
                SP.CİNSİYET = "KADIN";
            }
            if (KADIN.Checked == false && ERKEK.Checked == false)
            {
                MessageBox.Show("SPORCUNU CİNSİYETİNİ BELİRTİNİZ!!");
            }
            
                BUSİNESSLOGİCLAYER.BLLSPORCU.SPORCUFİZİKYENİLE(SP);
                MessageBox.Show(AD.Text + " " + "ADLI KULLANICININ BİLGİLERİ GÜNCELLENDİ");
            
          

        }//SPORCU BİLGİ GÜNCELLE
        public void ADAGÖRESIRALA(TextBox AD,DataGridView DATA)
        {
            SqlCommand KOMUT = new SqlCommand("select ID,AD,SOYAD,YAŞ,CİNSİYET,ÖĞRENCİDURUMU,KISANOT,FOTO,BOY,KİLO,BEL,GÖĞÜS,KOLSAĞ,KOLSOL,KALÇA,VÜCUTKİTLEİNDEX,DURUM,TELEFON,TC,SONGÜNCELLEME   FROM TBLSPORCU WHERE AD=@AD AND DURUM=1", SQLBAGLANTI.BAGLANTI);
            KOMUT.CommandType = CommandType.Text;
            if (KOMUT.Connection.State != ConnectionState.Open)
            {
                KOMUT.Connection.Open();
            }
            KOMUT.Parameters.AddWithValue("@AD", AD.Text);
            SqlDataAdapter da = new SqlDataAdapter(KOMUT);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DATA.DataSource = dt;

        }//AD'A GÖRE SEÇİLEN SPORCUYU LİSTELEME 
        public void VERİAKTAR(PictureBox foto1,Label ID,DataGridView DATA,TextBox AD,RichTextBox KISANOT,TextBox SOYAD,NumericUpDown YAŞ,RadioButton ERKEK,RadioButton KADIN,RadioButton ÖĞRENCİ,RadioButton YETİŞKİN,TextBox FOTO,MaskedTextBox BOY,MaskedTextBox KİLO,MaskedTextBox BEL,MaskedTextBox GÖĞÜS,MaskedTextBox KALÇA,MaskedTextBox SAĞLKOL,MaskedTextBox SOLKOL,MaskedTextBox VKİNDEX,MaskedTextBox TELEFON,MaskedTextBox TC,DateTimePicker GÜNCEL)
        {
            ID.Text = DATA.CurrentRow.Cells[0].Value.ToString(); //[0] sütun numarası



            AD.Text = DATA.CurrentRow.Cells[1].Value.ToString(); //[1] sütun numarası


            SOYAD.Text = DATA.CurrentRow.Cells[2].Value.ToString(); //[2] sütun numarası
            YAŞ.Value = Convert.ToInt32(DATA.CurrentRow.Cells[3].Value); //[3] sütun numarası;
            if (DATA.CurrentRow.Cells[4].Value.ToString() == "ERKEK")
            {
                ERKEK.Checked = true;
            }
            if (DATA.CurrentRow.Cells[4].Value.ToString() == "KADIN")
            {
                KADIN.Checked = true;
            }
            if (DATA.CurrentRow.Cells[5].Selected)
            {
                ÖĞRENCİ.Checked = true;
            }
            else
            {
                YETİŞKİN.Checked = true;
            }

            KISANOT.Text = DATA.CurrentRow.Cells[6].Value.ToString();
            string NOTCOZ = KISANOT.Text;
            byte[] NOCOZUM = Convert.FromBase64String(NOTCOZ);
            string COZULMUSNOT = ASCIIEncoding.ASCII.GetString(NOCOZUM);
            KISANOT.Text = COZULMUSNOT;
            



            FOTO.Text = DATA.CurrentRow.Cells[7].Value.ToString();
            foto1.ImageLocation= DATA.CurrentRow.Cells[7].Value.ToString();
            BOY.Text = DATA.CurrentRow.Cells[8].Value.ToString();
            KİLO.Text = DATA.CurrentRow.Cells[9].Value.ToString();
            BEL.Text = DATA.CurrentRow.Cells[10].Value.ToString();
            GÖĞÜS.Text = DATA.CurrentRow.Cells[11].Value.ToString();
            SAĞLKOL.Text = DATA.CurrentRow.Cells[12].Value.ToString();
            SOLKOL.Text = DATA.CurrentRow.Cells[13].Value.ToString();
            KALÇA.Text = DATA.CurrentRow.Cells[14].Value.ToString();
            VKİNDEX.Text = DATA.CurrentRow.Cells[15].Value.ToString();
            TELEFON.Text = DATA.CurrentRow.Cells[17].Value.ToString();

            TC.Text = DATA.CurrentRow.Cells[18].Value.ToString();
           
            GÜNCEL.Text = DATA.CurrentRow.Cells[19].Value.ToString();



        }//DATA GRİD İL VERİ ÇEKME
        public void ÜYELİĞİBİTENSPORCULAR(DateTimePicker TODAY, DataGridView DATA)
        {
            SqlCommand KOMUT = new SqlCommand("SELECT ID,AD,SOYAD,YAŞ,CİNSİYET,TELEFON FROM TBLSPORCU WHERE KAYITBİTİŞTARİHİ<@P1", SQLBAGLANTI.BAGLANTI);
            KOMUT.CommandType = CommandType.Text;
            if (KOMUT.Connection.State != ConnectionState.Open)
            {
                KOMUT.Connection.Open();
            }
            KOMUT.Parameters.AddWithValue("@P1", Convert.ToDateTime(TODAY.Text));
            SqlDataAdapter da = new SqlDataAdapter(KOMUT);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DATA.DataSource = dt;

        }//AD'A GÖRE SEÇİLEN SPORCUYU LİSTELEME 
        public void ÜYELİĞİDOLANSPORCUDURUMPASİFYAP(DateTimePicker TODAY)
        {
            SqlCommand KOMUT = new SqlCommand("UPDATE TBLSPORCU SET DURUM=0 WHERE KAYITBİTİŞTARİHİ<@P1", SQLBAGLANTI.BAGLANTI);
            KOMUT.CommandType = CommandType.Text;
            if (KOMUT.Connection.State != ConnectionState.Open)
            {
                KOMUT.Connection.Open();
            }
            KOMUT.Parameters.AddWithValue("@P1", Convert.ToDateTime(TODAY.Text));
            KOMUT.ExecuteNonQuery();

        }//AD'A GÖRE SEÇİLEN SPORCUYU LİSTELEME 
       
    }
}
