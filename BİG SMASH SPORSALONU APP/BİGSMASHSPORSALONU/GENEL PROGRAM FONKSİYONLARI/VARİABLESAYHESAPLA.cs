using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BİGSMASHSPORSALONU
{
   public class VARİABLESAYHESAPLA
    {
        /// <summary>
        /// ////////////////////////
        /// </summary>DEĞİŞKENLER PRİVET
        int _eklenicekay;
        DateTime _kayıttarihi;
        DateTime _kayıtbitiştarihi;
        /// <summary>
        /// ////////////////////////
        /// </summary>DEĞİŞKENLERİN PUBLİC EDİLMESİ İMPLANT GET SET
        public int Eklenicekay
        {
            get
            {
                return _eklenicekay;
            }

            set
            {
                _eklenicekay = value;
            }
        }
        public DateTime Kayıttarihi
        {
            get
            {
                return _kayıttarihi;
            }

            set
            {
                _kayıttarihi = value;
            }
        }
        public DateTime Kayıtbitiştarihi
        {
            get
            {
                return _kayıtbitiştarihi;
            }

            set
            {
                _kayıtbitiştarihi = value;
            }
        }
        /// <summary>
        /// ////////////////////////
        /// </summary>AY HESAPLAMA FONKSİYONU
        public void ayhesapla(NumericUpDown AYSAYISI, DateTimePicker KAYITTARİHİ, DateTimePicker KAYITBİTİŞTARİHİ)
        {
            VARİABLESAYHESAPLA VR = new VARİABLESAYHESAPLA();
            VR.Eklenicekay = Convert.ToInt16(AYSAYISI.Value);
            VR.Kayıttarihi = KAYITTARİHİ.Value;
            VR.Kayıtbitiştarihi = KAYITBİTİŞTARİHİ.Value;
            VR.Kayıtbitiştarihi = VR.Kayıttarihi.AddMonths(VR.Eklenicekay);
            KAYITBİTİŞTARİHİ.Value = VR.Kayıtbitiştarihi;

        }
    }
}
