using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass.VM.ShipMovement
{
  public  class SHIP_MOVEMENT_Base_SM
  {

      public SHIP_MOVEMENT_Base_SM()
        {
            this.EXP = new ExceptionMsg();
      }
        public int ID { get; set; }
        public Nullable<int> SHIP_ID { get; set; }
        public Nullable<int> COUNTRY_ID { get; set; }
        public Nullable<System.DateTime> START_DATE { get; set; }
        public Nullable<System.DateTime> END_DATE { get; set; }

        public virtual COUNTRY_MASTER_Base_SM COUNTRY_MASTER { get; set; }
        public virtual SHIP_MASTER_Base_SM SHIP_MASTER { get; set; }

        public virtual ExceptionMsg  EXP { get; set; }

    }
}
