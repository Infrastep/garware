using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class ShipMasterBC
    {

        public static SHIP_MASTER_Base insertupdateData(SHIP_MASTER_Base obj)
        {
            SHIP_MASTERDL ed = new SHIP_MASTERDL();
            return ed.insertdata(obj);
        }

        public static List<SHIP_MASTER_Base> getdata()
        {
            SHIP_MASTERDL ed = new SHIP_MASTERDL();
            return ed.getdata();
        }
        public static SHIP_MASTER_Base getdata(int id)
        {
            SHIP_MASTERDL ed = new SHIP_MASTERDL();
            return ed.getdata(id);
        }
        public static List<SHIP_MASTER_Base> getdatabyclientid(int comid)
        {
            SHIP_MASTERDL ed = new SHIP_MASTERDL();
            return ed.getdatabyclientid(comid);
        }
    }
}
