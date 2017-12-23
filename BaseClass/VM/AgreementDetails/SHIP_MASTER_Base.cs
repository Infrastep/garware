using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass.VM.AgreementDetails
{
   public class SHIP_MASTER_Base_AD
    {
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
    }
}
