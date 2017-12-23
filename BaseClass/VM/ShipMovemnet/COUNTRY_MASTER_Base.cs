using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass.VM.ShipMovement
{
   public class COUNTRY_MASTER_Base_SM
    {
           
        public int CID { get; set; }
        public string C_Name { get; set; }
        public string CCODE { get; set; }
        public string add_by { get; set; }
        public Nullable<System.DateTime> add_time { get; set; }
        public string Edit_by { get; set; }
        public Nullable<System.DateTime> Edit_time { get; set; }
        public Nullable<bool> status { get; set; }
    
    }
}
