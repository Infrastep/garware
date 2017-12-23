using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass.VM.ShipMovementRegister
{
   public class SHIP_MOVEMENT_REGISTER_Base_SMR
    {
        public int ID { get; set; }
        public int SHIPCODE { get; set; }
        public Nullable<System.DateTime> FROM_DATE { get; set; }
        public Nullable<System.DateTime> TO_DATE { get; set; }
        public string WATER { get; set; }

        public virtual SHIP_MASTER_Base_SMR SHIP_MASTER { get; set; }
    }
}
