using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class ACCOUNT_MASTERBC
    {
       public static ACCOUNT_MASTER_Base insertupdateData(ACCOUNT_MASTER_Base obj)
        {
            ACCOUNT_MASTERDL ed = new ACCOUNT_MASTERDL();
            return ed.insertdata(obj);
        }

       public static List<ACCOUNT_MASTER_Base> getdata()
        {
            ACCOUNT_MASTERDL ed = new ACCOUNT_MASTERDL();
            return ed.getdata();
        }
       public static ACCOUNT_MASTER_Base getdata(int id)
        {
            ACCOUNT_MASTERDL ed = new ACCOUNT_MASTERDL();
            return ed.getdata(id);
        }
    }
}
