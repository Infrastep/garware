using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class CURRENCY_MASTERBC
    {

       public static CURRENCY_MASTER_Base insertupdateData(CURRENCY_MASTER_Base obj)
        {
            CURRENCY_MASTERDL ed = new CURRENCY_MASTERDL();
            return ed.insertdata(obj);
        }

       public static List<CURRENCY_MASTER_Base> getdata()
        {
            CURRENCY_MASTERDL ed = new CURRENCY_MASTERDL();
            return ed.getdata();
        }

    }
}
