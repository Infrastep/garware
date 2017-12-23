using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using BaseClass.VM.ShipMovement;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class SHIP_MOVEMENTBC
    {
       public static SHIP_MOVEMENT_Base_SM insertupdateData(SHIP_MOVEMENT_Base_SM obj)
        {
            SHIP_MOVEMENTDL ed = new SHIP_MOVEMENTDL();
            return ed.insertdata(obj);
        }

       public static List<SHIP_MOVEMENT_Base_SM> getdata()
        {
            SHIP_MOVEMENTDL ed = new SHIP_MOVEMENTDL();
            return ed.getdata();
        }
       public static SHIP_MOVEMENT_Base_SM getdata(int id)
        {
            SHIP_MOVEMENTDL ed = new SHIP_MOVEMENTDL();
            return ed.getdata(id);
        }
    }
}
