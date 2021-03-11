using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ENTİTYLAYER;


namespace FACADLAYER
{
    public class SPORCUFACADLAYER
    {
        public static int EKLE(SPORCUENTİTYCLASS deg)
        {
            SqlCommand komut = new SqlCommand("SPORCUEK", SQLBAGLANTI.BAGLANTI);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@AD", deg.AD);
            komut.Parameters.AddWithValue("@SOYAD", deg.SOYAD);
            komut.Parameters.AddWithValue("@YAS", deg.YAS);
            komut.Parameters.AddWithValue("@CİNSİYET", deg.CİNSİYET);
            komut.Parameters.AddWithValue("@ÖĞRENCİDURUMU",deg.ÖĞRENCİDURUMU);
            komut.Parameters.AddWithValue("@KAYITTARİHİ", deg.KAYITTARİHİ);
            komut.Parameters.AddWithValue("@KAYITBİTİŞTARİHİ", deg.KAYITBİTİŞTARİHİ);
            komut.Parameters.AddWithValue("@KISANOT", deg.KISANOT);
            komut.Parameters.AddWithValue("@FOTO", deg.FOTO);
            komut.Parameters.AddWithValue("@BOY", deg.BOY);
            komut.Parameters.AddWithValue("@KİLO", deg.KİLO);
            komut.Parameters.AddWithValue("@BEL", deg.BEL);
            komut.Parameters.AddWithValue("@GÖĞÜS", deg.GÖĞÜS);
            komut.Parameters.AddWithValue("@KOLSAĞ", deg.KOLSAĞ);
            komut.Parameters.AddWithValue("@KOLSOL", deg.KOLSOL);
            komut.Parameters.AddWithValue("@KALÇA", deg.KALÇA);
            komut.Parameters.AddWithValue("@VÜCUTKİTLEİNDEX", deg.VKİNDEX);
            komut.Parameters.AddWithValue("@DURUM", true);
            komut.Parameters.AddWithValue("@TELEFON", deg.TELEFON);
            komut.Parameters.AddWithValue("@TC", deg.TC);
            komut.Parameters.AddWithValue("@SONGÜNCELLEME", deg.SONGÜNCELLEME);
            return komut.ExecuteNonQuery();

        }////SPORCU EKLE FONKSİYONU
        public static bool SİL(SPORCUENTİTYCLASS deg)
        {
            SqlCommand komut = new SqlCommand("SPORCUSİL", SQLBAGLANTI.BAGLANTI);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("ID", deg.ID);
            komut.Parameters.AddWithValue("DURUM", deg.DURUM);
            return komut.ExecuteNonQuery() > 0;
        }////SPORCU SİL DURUMU PASİF YAP
        public static bool GUNCELLE(SPORCUENTİTYCLASS deg)
        {
            SqlCommand komut = new SqlCommand("SPORCUGUNCELLE", SQLBAGLANTI.BAGLANTI);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("AD", deg.AD);
            komut.Parameters.AddWithValue("SOYAD", deg.SOYAD);
            komut.Parameters.AddWithValue("YAŞ", deg.YAS);
            komut.Parameters.AddWithValue("CİNSİYET", deg.CİNSİYET);
            komut.Parameters.AddWithValue("ÖĞRENCİDURUMU", deg.ÖĞRENCİDURUMU);
            komut.Parameters.AddWithValue("KAYITTARİHİ", deg.KAYITTARİHİ);
            komut.Parameters.AddWithValue("KAYITBİTİŞTARİHİ", deg.KAYITBİTİŞTARİHİ);
            komut.Parameters.AddWithValue("FOTO", deg.FOTO);
            komut.Parameters.AddWithValue("BOY", deg.FOTO);
            komut.Parameters.AddWithValue("KİLO", deg.KİLO);
            komut.Parameters.AddWithValue("BEL", deg.BEL);
            komut.Parameters.AddWithValue("GÖĞÜS", deg.GÖĞÜS);
            komut.Parameters.AddWithValue("KOLSAĞ", deg.KOLSAĞ);
            komut.Parameters.AddWithValue("KOLSOL", deg.KOLSOL);
            komut.Parameters.AddWithValue("KALÇA", deg.KALÇA);
            komut.Parameters.AddWithValue("VÜCUTKİTLEİNDEX", deg.VKİNDEX);
            komut.Parameters.AddWithValue("DURUM", deg.DURUM);
            return komut.ExecuteNonQuery() > 0;
        }///SPORCU GÜNCELLE
        public static List<SPORCUENTİTYCLASS> LİSTELE()
        {
            List<SPORCUENTİTYCLASS> SPORCULAR = new List<SPORCUENTİTYCLASS>();
            SqlCommand KOMUT = new SqlCommand("TUMSPORCULARILİSTELE", SQLBAGLANTI.BAGLANTI);
            KOMUT.CommandType = CommandType.StoredProcedure;
            if (KOMUT.Connection.State != ConnectionState.Open)
            {
                KOMUT.Connection.Open();
            }
            SqlDataReader DR = KOMUT.ExecuteReader();
            while (DR.Read())
            {
                SPORCUENTİTYCLASS SP = new SPORCUENTİTYCLASS();
                SP.ID = Convert.ToInt32(DR["ID"]);
                SP.AD = DR["AD"].ToString();
                SP.SOYAD = DR["SOYAD"].ToString();
                SP.YAS = Convert.ToInt32(DR["YAS"]);
                SP.CİNSİYET = DR["CİNSİYET"].ToString();
                SP.ÖĞRENCİDURUMU = Convert.ToBoolean(DR["ÖĞRENCİDURUMU"]);
                SP.KAYITTARİHİ = Convert.ToDateTime(DR["KAYITTARİHİ"]);
                SP.KAYITBİTİŞTARİHİ = Convert.ToDateTime(DR["KAYITBİTİŞTARİHİ"]);
                SP.DURUM = Convert.ToBoolean(DR["DURUM"]);
                SPORCULAR.Add(SP);

            }
            DR.Close();
            return SPORCULAR;
        }///AKTİF DURUMDA OLAN TÜM SPORCULARI LİSTELEME    
        public static List<SPORCUENTİTYCLASS> IDİLİLİSTELE()
        {
            SPORCUENTİTYCLASS SP = new SPORCUENTİTYCLASS();
            List<SPORCUENTİTYCLASS> SPORCULAR = new List<SPORCUENTİTYCLASS>();
            SqlCommand KOMUT = new SqlCommand("SELECT * FROM TBLSPORCU WHERE ID=@ID", SQLBAGLANTI.BAGLANTI);
            KOMUT.CommandType = CommandType.Text;
            KOMUT.Parameters.AddWithValue("ID",SP.ID);
            if (KOMUT.Connection.State != ConnectionState.Open)
            {
                KOMUT.Connection.Open();
            }
            SqlDataReader DR = KOMUT.ExecuteReader();
            while (DR.Read())
            {
              
                SP.ID = Convert.ToInt32(DR["ID"]);
                SP.AD = DR["AD"].ToString();
                SP.SOYAD = DR["SOYAD"].ToString();
                SP.YAS = Convert.ToInt32(DR["YAŞ"]);
                SP.CİNSİYET = DR["CİNSİYET"].ToString();
                SP.ÖĞRENCİDURUMU = Convert.ToBoolean(DR["ÖĞRENCİDURUMU"]);
                SP.KAYITTARİHİ = Convert.ToDateTime(DR["KAYITTARİHİ"]);
                SP.KAYITBİTİŞTARİHİ = Convert.ToDateTime(DR["KAYITBİTİŞTARİHİ"]);
                SP.KISANOT = DR["KISAOT"].ToString();
                SP.FOTO = DR["FOTO"].ToString();
                SP.BOY = Convert.ToDecimal(DR["BOY"]);
                SP.KİLO = Convert.ToInt32(DR["KİLO"]);
                SP.BEL = Convert.ToDecimal(DR["BEL"]);
                SP.GÖĞÜS = Convert.ToDecimal(DR["GÖĞÜS"]);
                SP.KOLSAĞ = Convert.ToDecimal(DR["KOLSAĞ"]);
                SP.KOLSOL = Convert.ToDecimal(DR["KOLSOL"]);
                SP.KALÇA = Convert.ToDecimal(DR["KALÇA"]);
                SP.VKİNDEX = Convert.ToDecimal(DR["VÜCUTKİTLEİNDEX"]);
                SP.DURUM = Convert.ToBoolean(DR["DURUM"]);
                SP.TELEFON = DR["TELEFON"].ToString();

                SPORCULAR.Add(SP);
            }
            DR.Close();
            return SPORCULAR;
        }///GİRİLEN ID'YE GÖRE SPORCU BİLGİSİ GETİRME
        public static bool SPORCUFİZİKGÜNCELLE(SPORCUENTİTYCLASS deg)
        {
            SqlCommand komut = new SqlCommand("SPORCUFİZİKBİLGİGÜNCELLE", SQLBAGLANTI.BAGLANTI);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@ID", deg.ID);
            komut.Parameters.AddWithValue("@AD", deg.AD);
            komut.Parameters.AddWithValue("@SOYAD", deg.SOYAD);
            komut.Parameters.AddWithValue("@YAS", deg.YAS);
            komut.Parameters.AddWithValue("@KISANOT", deg.KISANOT);
            komut.Parameters.AddWithValue("@CİNSİYET", deg.CİNSİYET);
            komut.Parameters.AddWithValue("@ÖĞRENCİDURUMU", deg.ÖĞRENCİDURUMU);
            komut.Parameters.AddWithValue("@FOTO", deg.FOTO);
            komut.Parameters.AddWithValue("@BOY", deg.BOY);
            komut.Parameters.AddWithValue("@KİLO", deg.KİLO);
            komut.Parameters.AddWithValue("@BEL", deg.BEL);
            komut.Parameters.AddWithValue("@GÖĞÜS", deg.GÖĞÜS);
            komut.Parameters.AddWithValue("@KOLSAĞ", deg.KOLSAĞ);
            komut.Parameters.AddWithValue("@KOLSOL", deg.KOLSOL);
            komut.Parameters.AddWithValue("@KALÇA", deg.KALÇA);
            komut.Parameters.AddWithValue("@VÜCUTKİTLEİNDEXİ", deg.VKİNDEX);
            komut.Parameters.AddWithValue("@TC", deg.TC);
            komut.Parameters.AddWithValue("@TELEFON", deg.TELEFON);
            komut.Parameters.AddWithValue("@SONGÜNCELLEME", deg.SONGÜNCELLEME);
            return komut.ExecuteNonQuery() > 0;

        }
 
    }
}
