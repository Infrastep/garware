using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class EmployeeClientBC
    {

       public static EMPLOYEE_CLIENT_Base insertupdateData(EMPLOYEE_CLIENT_Base obj)
        {
            EMPLOYEE_CLIENTDL ed = new EMPLOYEE_CLIENTDL();
            return ed.insertdata(obj);
        }

       public static List<EMPLOYEE_CLIENT_Base> getdata()
        {
            EMPLOYEE_CLIENTDL ed = new EMPLOYEE_CLIENTDL();
            return ed.getdata();
        }
       public static List<EMPLOYEE_CLIENT_Base> getdatabyClientId(int clientId)
       {
           EMPLOYEE_CLIENTDL ed = new EMPLOYEE_CLIENTDL();
           return ed.getdatabyClientId(clientId);
       }
       public static List<EMPLOYEE_CLIENT_Base> getdatabyEmpId(int Id)
       {
           EMPLOYEE_CLIENTDL ed = new EMPLOYEE_CLIENTDL();
           return ed.getdatabyEmpID(Id);
       }
       public static int UpdateEMPStatus(int Id, int status)
       {
           EMPLOYEE_CLIENTDL ed = new EMPLOYEE_CLIENTDL();
           return ed.UpdateEMPStatus(Id,status);
       }
    }
}
