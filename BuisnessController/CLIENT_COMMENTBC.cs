using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class CLIENT_COMMENTBC
   {
       public static CLIENT_COMMENT_Base insertupdateData(CLIENT_COMMENT_Base obj)
       {
           CLIENT_COMMENTDL ed = new CLIENT_COMMENTDL();
           return ed.insertdata(obj);
       }

       public static List<CLIENT_COMMENT_Base> getdata()
       {
           CLIENT_COMMENTDL ed = new CLIENT_COMMENTDL();
           return ed.getdata();
       }



       public static List<CLIENT_COMMENT_Base> getdatabyEmpId(CLIENT_COMMENT_Base eb)
       {
           CLIENT_COMMENTDL ed = new CLIENT_COMMENTDL();
           return ed.getdatabyEmpId(eb.EMPID ?? 00);
       }
    }
}
