using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class NON_RECOVERYBC
   {
       public static NON_RECOVERY_Base insertupdateData(NON_RECOVERY_Base obj)
       {
           NON_RECOVERYDL ed = new NON_RECOVERYDL();
           return ed.insertdata(obj);
       }

       public static List<NON_RECOVERY_Base> getdata()
       {
           NON_RECOVERYDL ed = new NON_RECOVERYDL();
           return ed.getdata();
       }
       public static NON_RECOVERY_Base getdata(int id)
       {
           NON_RECOVERYDL ed = new NON_RECOVERYDL();
           return ed.getdata(id);
       }
    }
}
