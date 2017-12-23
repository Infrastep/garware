using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass.VM.ShipAgreement
{
    public class SHIP_AGREEMENT_Base_SA
    {
        public int Id { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Nullable<int> AgreementType { get; set; }
        public Nullable<System.DateTime> Startdate { get; set; }
        public Nullable<System.DateTime> Enddate { get; set; }
        public Nullable<int> ShipId { get; set; }
        public string Msg { get; set; }
        public string Event { get; set; }

        public virtual CLIENT_MASTER_Base_SA CLIENT_MASTER { get; set; }
        public virtual SHIP_MASTER_Base_SA SHIP_MASTER { get; set; }
    }
}
