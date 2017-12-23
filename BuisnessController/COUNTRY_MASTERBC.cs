using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
  public class COUNTRY_MASTERBC
    {
      public static COUNTRY_MASTER_Base insertupdateData(COUNTRY_MASTER_Base obj)
        {
            COUNTRY_MASTERDL ed = new COUNTRY_MASTERDL();
            return ed.insertdata(obj);
        }

      public static List<COUNTRY_MASTER_Base> getdata()
        {
            COUNTRY_MASTERDL ed = new COUNTRY_MASTERDL();
            return ed.getdata();
        }
    }
}
