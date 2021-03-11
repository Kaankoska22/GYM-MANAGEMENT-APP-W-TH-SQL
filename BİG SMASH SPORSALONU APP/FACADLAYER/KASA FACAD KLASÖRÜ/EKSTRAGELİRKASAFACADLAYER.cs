using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTİTYLAYER;
using System.Data.SqlClient;
using System.Data;

namespace FACADLAYER
{
  public  class EKSTRAGELİKASAFACADLAYER
    {
        public static int EKLE(EKSTRAHARAKETENTİTYCLASS DEG)
        {
            SqlCommand KOMUT = new SqlCommand("EKSTRAGELİREKLE", SQLBAGLANTI.BAGLANTI);
            KOMUT.CommandType = CommandType.StoredProcedure;
            if (KOMUT.Connection.State != ConnectionState.Open)
            {
                KOMUT.Connection.Open();

            }
            KOMUT.Parameters.AddWithValue("@ÜCRET", DEG.ALINANÜCRET);
            KOMUT.Parameters.AddWithValue("@İŞLEM", DEG.NOT);
            KOMUT.Parameters.AddWithValue("@TARİH", DEG.TARİH);          
            return KOMUT.ExecuteNonQuery();

        }//EKLE FONKSİYONU



        public static List<KASAENTİTYCLASS> LİSTELE()
        {
            List<KASAENTİTYCLASS> YENİKASA = new List<KASAENTİTYCLASS>();
            SqlCommand KOMUT = new SqlCommand("KASALİSTELE", SQLBAGLANTI.BAGLANTI);
            KOMUT.CommandType = CommandType.StoredProcedure;
            if (KOMUT.Connection.State != ConnectionState.Open)
            {
                KOMUT.Connection.Open();
            }
            SqlDataReader DR = KOMUT.ExecuteReader();
            while (DR.Read())
            {
                KASAENTİTYCLASS KAS = new KASAENTİTYCLASS();
                KAS.TARİH = Convert.ToDateTime(DR["TARİH"]);
                KAS.KASA = Convert.ToInt32(DR["KASA"]);
                YENİKASA.Add(KAS);
            }
            DR.Close();
            return YENİKASA;


        }///KASA LİSTELEME ŞU AN KULLANILMIYOR
    }
}
