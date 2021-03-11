using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace FACADLAYER
{
   public class SQLBAGLANTI
    {
       public static SqlConnection BAGLANTI = new SqlConnection("Data Source=DESKTOP-HD5P9VL;Initial Catalog=DBSPORSALONU;Integrated Security=True");
    }///VERİ TABANI BAĞLANTI AÇMA
}
