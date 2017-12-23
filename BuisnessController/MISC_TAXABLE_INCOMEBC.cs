using BaseClass;
using DataAccess.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessController
{
   public class MISC_TAXABLE_INCOMEBC
    {
        public static MISC_TAXABLE_INCOME_Base insertupdateData(MISC_TAXABLE_INCOME_Base obj)
        {
            MISC_TAXABLE_INCOMEDL ed = new MISC_TAXABLE_INCOMEDL();
            return ed.insertdata(obj);
        }

        public static List<MISC_TAXABLE_INCOME_Base> getdata()
        {
            MISC_TAXABLE_INCOMEDL ed = new MISC_TAXABLE_INCOMEDL();
            return ed.getdata();
        }
        public static MISC_TAXABLE_INCOME_Base getdata(int id)
        {
            MISC_TAXABLE_INCOMEDL ed = new MISC_TAXABLE_INCOMEDL();
            return ed.getdata(id);
        }
    }
}
