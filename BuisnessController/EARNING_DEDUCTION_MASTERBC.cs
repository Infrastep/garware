using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class EARNING_DEDUCTION_MASTERBC
    {
        public static EARNING_DEDUCTION_MASTER_Base insertupdateData(EARNING_DEDUCTION_MASTER_Base obj)
        {
            EARNING_DEDUCTION_MASTERDL ed = new EARNING_DEDUCTION_MASTERDL();
            return ed.insertdata(obj);
        }

        public static List<EARNING_DEDUCTION_MASTER_Base> getdata()
        {
            EARNING_DEDUCTION_MASTERDL ed = new EARNING_DEDUCTION_MASTERDL();
            return ed.getdata();
        }
        public static EARNING_DEDUCTION_MASTER_Base getdata(int id)
        {
            EARNING_DEDUCTION_MASTERDL ed = new EARNING_DEDUCTION_MASTERDL();
            return ed.getdata(id);
        }
    }
}
