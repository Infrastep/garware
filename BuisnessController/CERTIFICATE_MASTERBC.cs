using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class CERTIFICATE_MASTERBC
    {

       public static CERTIFICATE_MASTER_Base insertupdateData(CERTIFICATE_MASTER_Base obj)
        {
            CERTIFICATE_MASTERDL ed = new CERTIFICATE_MASTERDL();
            return ed.insertdata(obj);
        }

       public static List<CERTIFICATE_MASTER_Base> getdata()
        {
            CERTIFICATE_MASTERDL ed = new CERTIFICATE_MASTERDL();
            return ed.getdata();
        }
       public static CERTIFICATE_MASTER_Base getdata(int id)
       {
           CERTIFICATE_MASTERDL ed = new CERTIFICATE_MASTERDL();
           return ed.getdata(id);
       }
       public static List<CERTIFICATE_MASTER_Base> getdatabyEmpId(CERTIFICATE_MASTER_Base eb)
       {
           CERTIFICATE_MASTERDL ed = new CERTIFICATE_MASTERDL();
           return ed.getdatabyEmpId(Convert.ToInt32(eb.EMP_ID));
       }
    }
}
