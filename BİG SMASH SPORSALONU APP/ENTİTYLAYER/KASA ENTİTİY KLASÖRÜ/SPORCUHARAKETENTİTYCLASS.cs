using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTİTYLAYER
{
   public class SPORCUHARAKETENTİTYCLASS
    {
        int _ID;
        int _ALINANÜCRET;
        int _YAPILANİNDİRİM;
        string _İŞLEM;
        DateTime _TARİH;
        int _SPORCUID;

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
        
        public int ALINANÜCRET
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

        public int YAPILANİNDİRİM
        {
            get
            {
                return _YAPILANİNDİRİM;
            }

            set
            {
                _YAPILANİNDİRİM = value;
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

        public int SPORCUID
        {
            get
            {
                return _SPORCUID;
            }

            set
            {
                _SPORCUID = value;
            }
        }

    
    }
}
