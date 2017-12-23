using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class CLIENT_MASTERBC
    {

        public static CLIENT_MASTER_Base insertupdateData(CLIENT_MASTER_Base obj)
        {
            CLIENT_MASTERDL ed = new CLIENT_MASTERDL();
            return ed.insertdata(obj);
        }

        public static List<CLIENT_MASTER_Base> getdata()
        {
            CLIENT_MASTERDL ed = new CLIENT_MASTERDL();
            return ed.getdata();
        }
    }
}
