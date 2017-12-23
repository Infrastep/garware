using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass.VM.ShipMovementRegister;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class SHIP_MOVEMENT_REGISTERBC
    {
       public static SHIP_MOVEMENT_REGISTER_Base_SMR insertupdateData(SHIP_MOVEMENT_REGISTER_Base_SMR obj)
        {
            SHIP_MOVEMENT_REGISTERDL ed = new SHIP_MOVEMENT_REGISTERDL();
            return ed.insertdata(obj);
        }

       public static List<SHIP_MOVEMENT_REGISTER_Base_SMR> getdata()
        {
            SHIP_MOVEMENT_REGISTERDL ed = new SHIP_MOVEMENT_REGISTERDL();
            return ed.getdata();
        }
       public static SHIP_MOVEMENT_REGISTER_Base_SMR getdata(int id)
        {
            SHIP_MOVEMENT_REGISTERDL ed = new SHIP_MOVEMENT_REGISTERDL();
            return ed.getdata(id);
        }
    }
}
