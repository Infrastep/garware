using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class CERTIFICATE_TYPE_MASTERBC
    {
        public static CERTIFICATE_TYPE_MASTER_Base insertupdateData(CERTIFICATE_TYPE_MASTER_Base obj)
        {
            CERTIFICATE_TYPE_MASTERDL ed = new CERTIFICATE_TYPE_MASTERDL();
            return ed.insertdata(obj);
        }

        public static List<CERTIFICATE_TYPE_MASTER_Base> getdata()
        {
            CERTIFICATE_TYPE_MASTERDL ed = new CERTIFICATE_TYPE_MASTERDL();
            return ed.getdata();
        }
        public static CERTIFICATE_TYPE_MASTER_Base getdata(int id)
        {
            CERTIFICATE_TYPE_MASTERDL ed = new CERTIFICATE_TYPE_MASTERDL();

            return ed.getdata(id);
        }
      
    }
}
