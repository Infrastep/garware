using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class RULE6BC
    {
        public static RULE6_Base insertupdateData(RULE6_Base obj)
        {
            RULE6DL ed = new RULE6DL();
            return ed.insertdata(obj);
        }

        public static List<RULE6_Base> getdata()
        {
            RULE6DL ed = new RULE6DL();
            return ed.getdata();
        }
        public static RULE6_Base getdata(int id)
        {
            RULE6DL ed = new RULE6DL();
            return ed.getdata(id);
        }
    }
}
