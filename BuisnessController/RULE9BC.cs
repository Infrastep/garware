using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class RULE9BC
    {
        public static RULE9_Base insertupdateData(RULE9_Base obj)
        {
            RULE9DL ed = new RULE9DL();
            return ed.insertdata(obj);
        }

        public static List<RULE9_Base> getdata()
        {
            RULE9DL ed = new RULE9DL();
            return ed.getdata();
        }
        public static RULE9_Base getdata(int id)
        {
            RULE9DL ed = new RULE9DL();
            return ed.getdata(id);
        }
    }
}
