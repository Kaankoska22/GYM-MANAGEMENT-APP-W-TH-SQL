using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTİTYLAYER;
using FACADLAYER;

namespace BUSİNESSLOGİCLAYER
{
   public class BLLANAKASA
    {
        public static int EKLE(ANAKASAENTİTY DEG)
        {
            if (DEG.TUTAR!=0 && DEG.TUTAR!=null && DEG.TARİH!=null)
            {
                return ANAKASAFACADLAYER.EKLE(DEG);
            }
            else
            {
                return -1;
            }

           
        }//BLL EKLE FONKSİYONU



    }
}
