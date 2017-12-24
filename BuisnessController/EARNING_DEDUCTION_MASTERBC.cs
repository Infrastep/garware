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
        public static AEDCODE_Base insertupdateData(AEDCODE_Base obj)
        {
            EARNING_DEDUCTION_MASTERDL ed = new EARNING_DEDUCTION_MASTERDL();
            return ed.insertdata(obj);
        }

        public static List<AEDCODE_Base> getdata()
        {
            EARNING_DEDUCTION_MASTERDL ed = new EARNING_DEDUCTION_MASTERDL();
            return ed.getdata();
        }
        public static AEDCODE_Base getdata(int id)
        {
            EARNING_DEDUCTION_MASTERDL ed = new EARNING_DEDUCTION_MASTERDL();
            return ed.getdata(id);
        }
    }
}
