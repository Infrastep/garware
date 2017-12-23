using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class RULE7BC
    {
        public static RULE7_Base insertupdateData(RULE7_Base obj)
        {
            RULE7DL ed = new RULE7DL();
            return ed.insertdata(obj);
        }

        public static List<RULE7_Base> getdata()
        {
            RULE7DL ed = new RULE7DL();
            return ed.getdata();
        }
        public static RULE7_Base getdata(int id)
        {
            RULE7DL ed = new RULE7DL();
            return ed.getdata(id);
        }
    }
}
