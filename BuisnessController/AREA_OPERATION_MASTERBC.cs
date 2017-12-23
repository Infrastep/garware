using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class AREA_OPERATION_MASTERBC
    {
       public static AREA_OPERATION_MASTER_Base insertupdateData(AREA_OPERATION_MASTER_Base obj)
        {
            AREA_OPERATION_MASTERDL ed = new AREA_OPERATION_MASTERDL();
            return ed.insertdata(obj);
        }

       public static List<AREA_OPERATION_MASTER_Base> getdata()
        {
            AREA_OPERATION_MASTERDL ed = new AREA_OPERATION_MASTERDL();
            return ed.getdata();
        }
       public static AREA_OPERATION_MASTER_Base getdata(int id)
        {
            AREA_OPERATION_MASTERDL ed = new AREA_OPERATION_MASTERDL();
            return ed.getdata(id);
        }
    }
}
