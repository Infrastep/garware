using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class BANK_MASTERBC
    {


        public static BANK_MASTER_Base insertupdateData(BANK_MASTER_Base obj)
        {
            BANK_MASTERDL ed = new BANK_MASTERDL();
            return ed.insertdata(obj);
        }

        public static List<BANK_MASTER_Base> getdata()
        {
            BANK_MASTERDL ed = new BANK_MASTERDL();
            return ed.getdata();
        }

    }
}
