using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;

namespace BuisnessController
{
   public class Ship_Type_MasterBC
    {
       public static SHIP_TYPE_MASTER_Base insertupdateData(SHIP_TYPE_MASTER_Base obj)
       {
           SHIP_TYPE_MASTERDL ed = new SHIP_TYPE_MASTERDL();
           return ed.insertdata(obj);
       }

       public static List<SHIP_TYPE_MASTER_Base> getdata()
       {
           SHIP_TYPE_MASTERDL ed = new SHIP_TYPE_MASTERDL();
           return ed.getdata();
       }
    }
}
