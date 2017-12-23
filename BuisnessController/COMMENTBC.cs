using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class COMMENTBC
    {
       public static COMMENT_Base insertupdateData(COMMENT_Base obj)
        {
            COMMENTDL ed = new COMMENTDL();
            return ed.insertdata(obj);
        }

       public static List<COMMENT_Base> getdata()
        {
            COMMENTDL ed = new COMMENTDL();
            return ed.getdata();
        }



       public static List<COMMENT_Base> getdatabyEmpId(COMMENT_Base eb)
        {
            COMMENTDL ed = new COMMENTDL();
            return ed.getdatabyEmpId(eb.EMPID ?? 00);
        }
      
    }
}
