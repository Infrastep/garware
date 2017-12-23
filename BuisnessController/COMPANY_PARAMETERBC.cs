using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class COMPANY_PARAMETERBC
    {
       public static COMPANY_PARAMETER_Base insertupdateData(COMPANY_PARAMETER_Base obj)
        {
            COMPANY_PARAMETERDL ed = new COMPANY_PARAMETERDL();
            return ed.insertdata(obj);
        }

       public static List<COMPANY_PARAMETER_Base> getdata()
        {
            COMPANY_PARAMETERDL ed = new COMPANY_PARAMETERDL();
            return ed.getdata();
        }
    }
}
