using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class EmployeeStatusBC
    {
       public static EMPLOYEE_STATUS_Base insertupdateData(EMPLOYEE_STATUS_Base obj)
        {
            EMPLOYEE_STATUSDL ed = new EMPLOYEE_STATUSDL();
            return ed.insertdata(obj);
        }

       public static List<EMPLOYEE_STATUS_Base> getdata()
        {
            EMPLOYEE_STATUSDL ed = new EMPLOYEE_STATUSDL();
            return ed.getdata();
        }

    }
}
