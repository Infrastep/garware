using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class COUNTRY_MASTER_Base
    {
       public COUNTRY_MASTER_Base()
        {
            this.BRANCH_DETAILS = new HashSet<BRANCH_DETAILS_Base>();
            this.DG_CERTIFIED_DOCTORS = new HashSet<DG_CERTIFIED_DOCTORS_Base>();
            this.KIN_DETAILS = new HashSet<KIN_DETAILS_Base>();
            this.PORT_MASTER = new HashSet<PORT_MASTER_Base>();
            this.SHIP_MASTER = new HashSet<SHIP_MASTER_Base>();
        }
    
        public int CID { get; set; }
        public string C_Name { get; set; }
        public string CCODE { get; set; }
        public string add_by { get; set; }
        public Nullable<System.DateTime> add_time { get; set; }
        public string Edit_by { get; set; }
        public Nullable<System.DateTime> Edit_time { get; set; }
        public Nullable<bool> status { get; set; }
        public virtual ICollection<BRANCH_DETAILS_Base> BRANCH_DETAILS { get; set; }
        public virtual ICollection<DG_CERTIFIED_DOCTORS_Base> DG_CERTIFIED_DOCTORS { get; set; }
        public virtual ICollection<KIN_DETAILS_Base> KIN_DETAILS { get; set; }
        public virtual ICollection<PORT_MASTER_Base> PORT_MASTER { get; set; }
        public virtual ICollection<SHIP_MASTER_Base> SHIP_MASTER { get; set; }
    }
}
