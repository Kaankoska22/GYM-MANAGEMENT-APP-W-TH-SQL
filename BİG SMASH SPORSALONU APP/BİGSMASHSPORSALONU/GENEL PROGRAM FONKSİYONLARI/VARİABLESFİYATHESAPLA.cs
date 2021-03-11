using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BİGSMASHSPORSALONU
{
   public  class VARİABLESFİYATHESAPLA
    {
        /// <summary>
        /// ////////////////
        /// </summary>DEĞİŞKENLER PRİVET
         double _tutar;
         double _indirimlitutar;
         double _indirim = 0;
         int _aysayısı;
         int _KARTEKSTRAÜCRET = 0;
        /////////////////////////////DEĞİŞKENLER İMPLANT GET SET
        public double Tutar
        {
            get
            {
                return _tutar;
            }

            set
            {
                _tutar = value;
            }
        }
        public double Indirimlitutar
        {
            get
            {
                return _indirimlitutar;
            }

            set
            {
                _indirimlitutar = value;
            }
        }
        public double Indirim
        {
            get
            {
                return _indirim;
            }

            set
            {
                _indirim = value;
            }
        }
        public int Aysayısı
        {
            get
            {
                return _aysayısı;
            }

            set
            {
                _aysayısı = value;
            }
        }
        public int KARTEKSTRAÜCRET
        {
            get
            {
                return _KARTEKSTRAÜCRET;
            }

            set
            {
                _KARTEKSTRAÜCRET = value;
            }

        }
        /// <summary>
        /// ////////////////////
        /// </summary>FİYAT HESAPLA FONKSİYONU
        public void FİYATHESAPLA(NumericUpDown üyelikaysayısı, RadioButton nakit, RadioButton kredi, RadioButton öğrenci, RadioButton yetişkin, ComboBox indirim, TextBox tutar)
        {
            VARİABLESFİYATHESAPLA VR = new VARİABLESFİYATHESAPLA();
            VR.Aysayısı = Convert.ToInt16(üyelikaysayısı.Value);

            if (yetişkin.Checked == true && öğrenci.Checked == false)
            {

                if (kredi.Checked == true && nakit.Checked == false)
                {
                    VR.KARTEKSTRAÜCRET += 10;
                }
                else
                {
                    VR.KARTEKSTRAÜCRET = 0;
                }
               
                    VR.Indirim = Convert.ToInt16(indirim.Text);
                    VR.Tutar = 0;
                    VR.Tutar = VR.Aysayısı * 200;
                    VR.Indirimlitutar = VR.Tutar * VR.Indirim / 100;
                    VR.Tutar = VR.Tutar - VR.Indirimlitutar;
                    VR.Tutar += VR.KARTEKSTRAÜCRET;
                    tutar.Text = VR.Tutar.ToString();
                
               
            }

            if (öğrenci.Checked == true || yetişkin.Checked == false)
            {
                if (kredi.Checked == true || nakit.Checked == false)
                {
                    VR.KARTEKSTRAÜCRET += 10;
                }
                if (kredi.Checked == false || nakit.Checked == true)
                {
                    VR.KARTEKSTRAÜCRET = 0;
                }

                VR.Indirim = Convert.ToInt16(indirim.Text);
                VR.Tutar = 0;
                VR.Tutar = VR.Aysayısı * 150;
                VR.Indirimlitutar = VR.Tutar * VR.Indirim / 100;
                VR.Tutar = VR.Tutar - VR.Indirimlitutar;
                VR.Tutar += VR.KARTEKSTRAÜCRET;
                tutar.Text = VR.Tutar.ToString();


            }
        }
    }
    
}