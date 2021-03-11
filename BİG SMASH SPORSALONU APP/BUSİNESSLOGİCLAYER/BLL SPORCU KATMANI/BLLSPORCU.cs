using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FACADLAYER;
using ENTİTYLAYER;


namespace BUSİNESSLOGİCLAYER
{
    public class BLLSPORCU
    {
        public static int EKLE(SPORCUENTİTYCLASS deg)
        {
            
            if (deg.AD != null && deg.SOYAD != null && deg.GÖĞÜS != 0 && deg.KALÇA != 0 && deg.KAYITBİTİŞTARİHİ != null && deg.KAYITTARİHİ != null && deg.KOLSAĞ != 0 && deg.KOLSAĞ != 0 && deg.KİLO != 0 && deg.VKİNDEX != 0 && deg.YAS!=0 && deg.FOTO!=null && deg.CİNSİYET!=null && deg.BOY!=0 && deg.BEL!=0)
            {
                return SPORCUFACADLAYER.EKLE(deg);
            }
            else
            {
                return -1;
            }
        }///SPORCU BLL EKLE FONKSİYONU
        public static bool GÜNCELLE(SPORCUENTİTYCLASS deg)
        {
            if (deg.AD != null && deg.SOYAD != null && deg.GÖĞÜS != 0 && deg.KALÇA != 0 && deg.KAYITBİTİŞTARİHİ != null && deg.KAYITTARİHİ != null && deg.KOLSAĞ != 0 && deg.KOLSAĞ != 0 && deg.KİLO != 0 && deg.VKİNDEX != 0 && deg.YAS != 0 && deg.FOTO != null && deg.CİNSİYET != null && deg.BOY != 0 && deg.BEL != 0)
            {
                return SPORCUFACADLAYER.GUNCELLE(deg);
            }
            else
            {
                return false;
            }

        }///SPORCU BLL GÜNCELLE FONKSİYONU
        public static bool SİL(SPORCUENTİTYCLASS deg)
        {
              return SPORCUFACADLAYER.SİL(deg);
        }///SPORCU BLL SİL (DURUMU PASİF YAP)
        public static List<SPORCUENTİTYCLASS>LİSTELE()
        {
            return SPORCUFACADLAYER.LİSTELE();
        }///SPORCU BLL LİSTELE
        

        public static bool SPORCUFİZİKYENİLE(SPORCUENTİTYCLASS DEG)//SPORCU FİZİK GÜNCELLEME
        {
            return SPORCUFACADLAYER.SPORCUFİZİKGÜNCELLE(DEG);
        }
    }
}
