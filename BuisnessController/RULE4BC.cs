using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;

namespace BuisnessController
{
   public class RULE4BC
    {
        public static RULE4_Base insertupdateData(RULE4_Base obj)
        {
            RULE4DL ed = new RULE4DL();
            return ed.insertdata(obj);
        }

        public static List<RULE4_Base> getdata()
        {
            RULE4DL ed = new RULE4DL();
            return ed.getdata();
        }
        public static RULE4_Base getdata(int id)
        {
            RULE4DL ed = new RULE4DL();
            return ed.getdata(id);
        }
    }
}
