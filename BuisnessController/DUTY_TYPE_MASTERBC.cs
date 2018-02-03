using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class DUTY_TYPE_MASTERBC
    {
       public static DUTY_TYPE_MASTER_Base insertupdateData(DUTY_TYPE_MASTER_Base obj)
        {
            DUTY_TYPE_MASTERDL ed = new DUTY_TYPE_MASTERDL();
            return ed.insertdata(obj);
        }

       public static List<DUTY_TYPE_MASTER_Base> getdata()
        {
            DUTY_TYPE_MASTERDL ed = new DUTY_TYPE_MASTERDL();
            return ed.getdata();
        }
       public static DUTY_TYPE_MASTER_Base getdata(int id)
        {
            DUTY_TYPE_MASTERDL ed = new DUTY_TYPE_MASTERDL();
            return ed.getdata(id);
        }
    }
}
