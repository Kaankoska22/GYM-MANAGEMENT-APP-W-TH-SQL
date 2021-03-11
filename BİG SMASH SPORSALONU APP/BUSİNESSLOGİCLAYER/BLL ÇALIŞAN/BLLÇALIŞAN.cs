using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTİTYLAYER;
using FACADLAYER;

namespace BUSİNESSLOGİCLAYER
{
  public  class BLLÇALIŞAN
    {
        public static int EKLE(ÇALIŞANENTİTYCLASS DEG)
        {
            return ÇALIŞANFACADLAYER.EKLE(DEG);
        }
        public static bool GÜNCELLE(ÇALIŞANENTİTYCLASS DEG)
        {
            return ÇALIŞANFACADLAYER.GÜNCELLE(DEG);

        }

    }
}
