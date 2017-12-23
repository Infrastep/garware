using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class RULE2BC
    {
        public static RULE2_Base insertupdateData(RULE2_Base obj)
        {
            RULE2DL ed = new RULE2DL();
            return ed.insertdata(obj);
        }

        public static List<RULE2_Base> getdata()
        {
            RULE2DL ed = new RULE2DL();
            return ed.getdata();
        }
        public static RULE2_Base getdata(int id)
        {
            RULE2DL ed = new RULE2DL();
            return ed.getdata(id);
        }
    }
}
