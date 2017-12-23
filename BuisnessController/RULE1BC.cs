using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;

namespace BuisnessController
{
   public class RULE1BC
    {
        public static RULE1_Base insertupdateData(RULE1_Base obj)
        {
            RULE1DL ed = new RULE1DL();
            return ed.insertdata(obj);
        }

        public static List<RULE1_Base> getdata()
        {
            RULE1DL ed = new RULE1DL();
            return ed.getdata();
        }
        public static RULE1_Base getdata(int id)
        {
            RULE1DL ed = new RULE1DL();
            return ed.getdata(id);
        }
    }
}
