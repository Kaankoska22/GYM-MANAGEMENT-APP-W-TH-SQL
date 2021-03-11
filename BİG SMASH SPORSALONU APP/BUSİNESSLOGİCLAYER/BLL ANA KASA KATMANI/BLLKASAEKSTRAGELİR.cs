using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTİTYLAYER;
using FACADLAYER;


namespace BUSİNESSLOGİCLAYER
{
   public class BLLKASAEKSTRAGELİR
    {
        public static int EKLE(EKSTRAHARAKETENTİTYCLASS DEG)
        {
            if (DEG.ALINANÜCRET!= null && DEG.NOT!="")
            {
                return EKSTRAGELİKASAFACADLAYER.EKLE(DEG);
            }
            else
            {
                return -1;
                
                
            }
           
        }

    }
}
