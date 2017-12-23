using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
  public  class SHIP_MASTER_Base
    {
      public SHIP_MASTER_Base()
        {
            this.EMPLOYEE_CLIENT = new HashSet<EMPLOYEE_CLIENT_Base>();
        }
    
        public int SMID { get; set; }
        public string VNAME { get; set; }
        public string PORT_REG_TRADE { get; set; }
        public string OFF_IMO_NO { get; set; }
        public string GT_POWER { get; set; }
        public Nullable<decimal> NO_OF_CREW { get; set; }
        public Nullable<int> TYPEID { get; set; }
        public string ADD_BY { get; set; }
        public string EDIT_BY { get; set; }
        public Nullable<System.DateTime> ADD_TIME { get; set; }
        public Nullable<System.DateTime> EDIT_TIME { get; set; }
        public Nullable<decimal> NRT { get; set; }
        
        
        public string AREA_OF_OPERATION { get; set; }
        public string OFFICIAL_NO { get; set; }
        public string POWER_KW_BHP { get; set; }
        public Nullable<int> COUNTRY_FLAG { get; set; }
        public Nullable<int> CLIENT_ID { get; set; }
        public string PHOTO { get; set; }
        public Nullable<bool> STATUS { get; set; }

        public string CALL_SIGN { get; set; }
        public string DWT { get; set; }
        public string ABS_NO { get; set; }
        public string MMSI_NO { get; set; }
        public string SAT_C_ID { get; set; }
        public string MOBILE_NO { get; set; }
        public string EMAIL { get; set; }
        public string VSAT_NO { get; set; }

        public virtual COUNTRY_MASTER_Base COUNTRY_MASTER { get; set; }
        public virtual ICollection<EMPLOYEE_CLIENT_Base> EMPLOYEE_CLIENT { get; set; }
        public virtual SHIP_TYPE_MASTER_Base SHIP_TYPE_MASTER { get; set; }

    }
}
