using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class SHORE_PASS_MASTERBC
    {
       public static SHORE_PASS_MASTER_Base insertupdateData(SHORE_PASS_MASTER_Base obj)
        {
            SHORE_PASS_MASTERDL ed = new SHORE_PASS_MASTERDL();
            return ed.insertdata(obj);
        }

       public static List<SHORE_PASS_MASTER_Base> getdata()
        {
            SHORE_PASS_MASTERDL ed = new SHORE_PASS_MASTERDL();
            return ed.getdata();
        }
       public static SHORE_PASS_MASTER_Base getdata(int id)
        {
            SHORE_PASS_MASTERDL ed = new SHORE_PASS_MASTERDL();
            return ed.getdata(id);
        }
    }
}
