using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class GRATUITY_REMITBC
    {
        public static GRATUITY_REMIT_Base insertupdateData(GRATUITY_REMIT_Base obj)
        {
            GRATUITY_REMITDL ed = new GRATUITY_REMITDL();
            return ed.insertdata(obj);
        }

        public static List<GRATUITY_REMIT_Base> getdata()
        {
            GRATUITY_REMITDL ed = new GRATUITY_REMITDL();
            return ed.getdata();
        }
        public static GRATUITY_REMIT_Base getdata(int id)
        {
            GRATUITY_REMITDL ed = new GRATUITY_REMITDL();
            return ed.getdata(id);
        }
    }
}
