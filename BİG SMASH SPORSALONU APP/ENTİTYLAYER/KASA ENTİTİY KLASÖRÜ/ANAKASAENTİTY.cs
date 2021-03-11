using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTİTYLAYER
{
  public  class ANAKASAENTİTY
    {
        int _ID;
        int _TUTAR;
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

        public int TUTAR
        {
            get
            {
                return _TUTAR;
            }

            set
            {
                _TUTAR = value;
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
