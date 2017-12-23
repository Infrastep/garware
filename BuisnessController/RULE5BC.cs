using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class RULE5BC
    {
        public static RULE5_Base insertupdateData(RULE5_Base obj)
        {
            RULE5DL ed = new RULE5DL();
            return ed.insertdata(obj);
        }

        public static List<RULE5_Base> getdata()
        {
            RULE5DL ed = new RULE5DL();
            return ed.getdata();
        }
        public static RULE5_Base getdata(int id)
        {
            RULE5DL ed = new RULE5DL();
            return ed.getdata(id);
        }
    }
}
