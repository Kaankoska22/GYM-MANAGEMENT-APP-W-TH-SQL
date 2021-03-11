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
   public class ÇALIŞANFACADLAYER
    {
        public static int EKLE(ÇALIŞANENTİTYCLASS DEG)
        {
            SqlCommand KOMUT = new SqlCommand("ÇALIŞANKAYIT",SQLBAGLANTI.BAGLANTI);
            KOMUT.CommandType = CommandType.StoredProcedure;
            if (KOMUT.Connection.State!=ConnectionState.Open)
            {
                KOMUT.Connection.Open();
            }
            KOMUT.Parameters.AddWithValue("@AD",DEG.AD);
            KOMUT.Parameters.AddWithValue("@ŞİFRE", DEG.ŞİFRE);
            KOMUT.Parameters.AddWithValue("@SOYAD", DEG.SOYAD);
            KOMUT.Parameters.AddWithValue("@TC", DEG.TC);
            KOMUT.Parameters.AddWithValue("@TELEFON", DEG.TELEFON);
            KOMUT.Parameters.AddWithValue("@CİNSİYET", DEG.CİNSİYET);
            KOMUT.Parameters.AddWithValue("@KISANOT", DEG.KISANOT);
            KOMUT.Parameters.AddWithValue("@FOTO", DEG.FOTO);
            KOMUT.Parameters.AddWithValue("@YAŞ", DEG.YAŞ);
            return KOMUT.ExecuteNonQuery();

        }
        public static bool GÜNCELLE(ÇALIŞANENTİTYCLASS DEG)
        {
            SqlCommand KOMUT = new SqlCommand("ÇALIŞANGÜNCELLE", SQLBAGLANTI.BAGLANTI);
            KOMUT.CommandType = CommandType.StoredProcedure;
            if (KOMUT.Connection.State==ConnectionState.Closed)
            {
                KOMUT.Connection.Open();
            }
            KOMUT.Parameters.AddWithValue("@ID", DEG.ID);
            KOMUT.Parameters.AddWithValue("@AD",DEG.AD);
            KOMUT.Parameters.AddWithValue("@ŞİFRE", DEG.ŞİFRE);
            KOMUT.Parameters.AddWithValue("@SOYAD", DEG.SOYAD);
            KOMUT.Parameters.AddWithValue("@TC", DEG.TC);
            KOMUT.Parameters.AddWithValue("@TELEFON", DEG.TELEFON);
            KOMUT.Parameters.AddWithValue("@CİNSİYET", DEG.CİNSİYET);
            KOMUT.Parameters.AddWithValue("@KISANOT", DEG.KISANOT);
            KOMUT.Parameters.AddWithValue("@FOTO", DEG.FOTO);
            KOMUT.Parameters.AddWithValue("@YAŞ", DEG.YAŞ);
            return KOMUT.ExecuteNonQuery() > 0;
        }
    }
}
