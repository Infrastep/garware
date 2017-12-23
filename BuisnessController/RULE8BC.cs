using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
  public  class RULE8BC
    {
        public static RULE8_Base insertupdateData(RULE8_Base obj)
        {
            RULE8DL ed = new RULE8DL();
            return ed.insertdata(obj);
        }

        public static List<RULE8_Base> getdata()
        {
            RULE8DL ed = new RULE8DL();
            return ed.getdata();
        }
        public static RULE8_Base getdata(int id)
        {
            RULE8DL ed = new RULE8DL();
            return ed.getdata(id);
        }
    }
}
