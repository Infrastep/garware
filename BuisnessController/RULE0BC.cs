using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class RULE0BC
    {
        public static RULE0_Base insertupdateData(RULE0_Base obj)
        {
            RULE0DL ed = new RULE0DL();
            return ed.insertdata(obj);
        }

        public static List<RULE0_Base> getdata()
        {
            RULE0DL ed = new RULE0DL();
            return ed.getdata();
        }
        public static RULE0_Base getdata(int id)
        {
            RULE0DL ed = new RULE0DL();
            return ed.getdata(id);
        }
    }
}
