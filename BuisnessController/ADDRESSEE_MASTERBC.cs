using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class ADDRESSEE_MASTERBC
    {
        public static ADDRESSEE_MASTER_Base insertupdateData(ADDRESSEE_MASTER_Base obj)
        {
            ADDRESSEE_MASTERDL ed = new ADDRESSEE_MASTERDL();
            return ed.insertdata(obj);
        }

        public static List<ADDRESSEE_MASTER_Base> getdata()
        {
            ADDRESSEE_MASTERDL ed = new ADDRESSEE_MASTERDL();
            return ed.getdata();
        }
        public static List<ADDRESSEE_MASTER_Base> getdatabyCompanyId(int id)
        {
            ADDRESSEE_MASTERDL ed = new ADDRESSEE_MASTERDL();
            return ed.getdataByCompanyId(id);
        }
    }
}
