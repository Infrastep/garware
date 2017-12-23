using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
  public class PF_REMITBC
    {
        public static PF_REMIT_Base insertupdateData(PF_REMIT_Base obj)
        {
            PF_REMITDL ed = new PF_REMITDL();
            return ed.insertdata(obj);
        }

        public static List<PF_REMIT_Base> getdata()
        {
            PF_REMITDL ed = new PF_REMITDL();
            return ed.getdata();
        }
        public static PF_REMIT_Base getdata(int id)
        {
            PF_REMITDL ed = new PF_REMITDL();
            return ed.getdata(id);
        }
    }
}
