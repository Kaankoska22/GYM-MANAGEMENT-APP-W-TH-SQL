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
    public class ANAKASAFACADLAYER
    {
        public static int EKLE(ANAKASAENTİTY DEG)
        {
            SqlCommand KOMUT = new SqlCommand("KASAEKLE",SQLBAGLANTI.BAGLANTI);
            KOMUT.CommandType = CommandType.StoredProcedure;
            if (KOMUT.Connection.State!=ConnectionState.Open)
            {
                KOMUT.Connection.Open();
            }
            KOMUT.Parameters.AddWithValue("@ÜCRET",DEG.TUTAR);
            KOMUT.Parameters.AddWithValue("@TARİH", DEG.TARİH);
            return KOMUT.ExecuteNonQuery();


        }


    }
}
