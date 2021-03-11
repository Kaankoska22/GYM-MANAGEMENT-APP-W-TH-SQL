using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTİTYLAYER
{
   public class KASAENTİTYCLASS
    {
        int _ID;
        double _KASA;
        string _İŞLEM;
        DateTime _TARİH;

        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
            }
        }

        public double KASA
        {
            get
            {
                return _KASA;
            }

            set
            {
                _KASA = value;
            }
        }

        public DateTime TARİH
        {
            get
            {
                return _TARİH;
            }

            set
            {
                _TARİH = value;
            }
        }

        public string İŞLEM
        {
            get
            {
                return _İŞLEM;
            }

            set
            {
                _İŞLEM = value;
            }
        }
    }
}
