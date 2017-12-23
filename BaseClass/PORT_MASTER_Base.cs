using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class PORT_MASTER_Base
    {
        public int PID { get; set; }
        public string PortName { get; set; }
        public string CCODE { get; set; }
        public Nullable<int> Country { get; set; }
        public string addby { get; set; }
        public string editby { get; set; }
        public Nullable<System.DateTime> addtime { get; set; }
        public Nullable<System.DateTime> editime { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public Nullable<bool> status { get; set; }
        public virtual COUNTRY_MASTER_Base COUNTRY_MASTER { get; set; }

    }
}
