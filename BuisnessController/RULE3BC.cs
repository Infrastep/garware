using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class RULE3BC
    {
        public static RULE3_Base insertupdateData(RULE3_Base obj)
        {
            RULE3DL ed = new RULE3DL();
            return ed.insertdata(obj);
        }

        public static List<RULE3_Base> getdata()
        {
            RULE3DL ed = new RULE3DL();
            return ed.getdata();
        }
        public static RULE3_Base getdata(int id)
        {
            RULE3DL ed = new RULE3DL();
            return ed.getdata(id);
        }
    }
}
