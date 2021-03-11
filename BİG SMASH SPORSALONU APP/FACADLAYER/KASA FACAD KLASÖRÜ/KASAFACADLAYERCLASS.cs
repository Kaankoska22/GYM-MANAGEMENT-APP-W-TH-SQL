using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENTİTYLAYER;

namespace FACADLAYER
{
    public class KASAFACADLAYERCLASS
    {
        public static int EKLE(SPORCUHARAKETENTİTYCLASS DEG)
        {
            SqlCommand KOMUT = new SqlCommand("KASASPORCUAİDATEKLEME", SQLBAGLANTI.BAGLANTI);
            KOMUT.CommandType = CommandType.StoredProcedure;
            if (KOMUT.Connection.State != ConnectionState.Open)
            {
                KOMUT.Connection.Open();
                
            }
            KOMUT.Parameters.AddWithValue("@ALINANÜCRET", DEG.ALINANÜCRET);
            KOMUT.Parameters.AddWithValue("@YAPILANİNDİRİM", DEG.YAPILANİNDİRİM);
            KOMUT.Parameters.AddWithValue("@İŞLEM", DEG.İŞLEM);
            KOMUT.Parameters.AddWithValue("@TARİH", DEG.TARİH);
            KOMUT.Parameters.AddWithValue("@SPORCUID", DEG.SPORCUID);
            return KOMUT.ExecuteNonQuery();
        }///KASA PARA EKLEME

    }
}
