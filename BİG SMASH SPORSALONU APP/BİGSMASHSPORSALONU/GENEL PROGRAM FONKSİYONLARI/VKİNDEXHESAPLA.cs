using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace BİGSMASHSPORSALONU
{
   public class VKİNDEXHESAPLA
    {   
        ////////////////DEĞİŞKENLER PRİVATE
        double _BOY;
        double _KİLO;
        double _ÇIKAR;
        double _VKİNDEX;
        //////////////DEĞİŞKENLER PROPERTY GET SET
        public double BOY
        {
            get
            {
                return _BOY;
            }

            set
            {
                _BOY = value;
            }
        }

        public double KİLO
        {
            get
            {
                return _KİLO;
            }

            set
            {
                _KİLO = value;
            }
        }

        public double ÇIKAR
        {
            get
            {
                return _ÇIKAR;
            }

            set
            {
                _ÇIKAR = value;
            }
        }

        public double VKİNDEX
        {
            get
            {
                return _VKİNDEX;
            }

            set
            {
                _VKİNDEX = value;
            }
        }
       //VÜCUT KİTLE İNDEXİ HESAPLAMA FONKSİYON
       public void VKİHESAPLA(MaskedTextBox BOY1,MaskedTextBox KİLO1 ,Label DURUM,MaskedTextBox İNDEX)
        {

            try
            {
                if (BOY1.Text != "" && KİLO1.Text != "")
                {
                    KİLO = Convert.ToDouble(KİLO1.Text);
                    BOY = Convert.ToDouble(BOY1.Text);
                    ÇIKAR = BOY * BOY;


                    VKİNDEX = KİLO / ÇIKAR;
                }
                if (VKİNDEX >= 0 && VKİNDEX <= 18.4)
                {
                    DURUM.Text = "ZAYIF";
                    DURUM.BackColor = Color.Red;
                }
                if (VKİNDEX >= 18.5 && VKİNDEX <= 24.9)
                {
                    DURUM.Text = "NORMAL";
                    DURUM.BackColor = Color.GreenYellow;
                }
                if (VKİNDEX >= 25 && VKİNDEX <= 29.9)
                {
                    DURUM.Text = "FAZLA KİLOLU";
                    DURUM.BackColor = Color.Red;
                }
                if (VKİNDEX >= 30 && VKİNDEX <= 34.9)
                {
                    DURUM.Text = "ŞİŞMAN";
                    DURUM.BackColor = Color.Red;
                }
                if (VKİNDEX >= 35 && VKİNDEX <= 44.9)
                {
                    DURUM.Text = "OBEZ";
                    DURUM.BackColor = Color.Red;
                }
                if (VKİNDEX >= 45)
                {
                    DURUM.Text = "AŞIRI OBEZ";
                    DURUM.BackColor = Color.Red;
                    MessageBox.Show("DOKTOR YARDIMI ALMALI!!!");
                }
                İNDEX.Text = VKİNDEX.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("BOY YADA KİLO KISMI BOŞ BIRAKILDIĞI İÇİN VÜCUT KİTLE İNDEXİ HESAPLANAMADI!!!");
            }
           
        }
    }
}
