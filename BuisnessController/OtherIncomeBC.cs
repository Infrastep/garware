using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class OtherIncomeBC
    {
        public static OTHER_INCOME_Base insertupdateData(OTHER_INCOME_Base obj)
        {
            OTHER_INCOMEDL ed = new OTHER_INCOMEDL();
            return ed.insertdata(obj);
        }

        public static List<OTHER_INCOME_Base> getdata()
        {
            OTHER_INCOMEDL ed = new OTHER_INCOMEDL();
            return ed.getdata();
        }

    }
}
