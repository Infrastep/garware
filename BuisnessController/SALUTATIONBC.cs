using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class SALUTATIONBC
    {
       public static SALUTATION_Base insertupdateData(SALUTATION_Base obj)
        {
            SALUTATIONDL ed = new SALUTATIONDL();
            return ed.insertdata(obj);
        }

       public static List<SALUTATION_Base> getdata()
        {
            SALUTATIONDL ed = new SALUTATIONDL();
            return ed.getdata();
        }
       public static SALUTATION_Base getdata(int id)
        {
            SALUTATIONDL ed = new SALUTATIONDL();
            return ed.getdata(id);
        }
    }
}
