using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTİTYLAYER
{
   public  class EKSTRAHARAKETENTİTYCLASS
    {
        int _ID;
        double _ALINANÜCRET;
        String _NOT;
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

        public double ALINANÜCRET
        {
            get
            {
                return _ALINANÜCRET;
            }

            set
            {
                _ALINANÜCRET = value;
            }
        }

        public string NOT
        {
            get
            {
                return _NOT;
            }

            set
            {
                _NOT = value;
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
    }
}
