using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;


namespace BuisnessController
{
  public class PAGE_MASTERBC
    {
        //public static PAGE_MASTER_Base insertupdateData(PAGE_MASTER_Base obj)
        //{
        //    PAGE_MASTERDL ed = new PAGE_MASTERDL();
        //    return ed.insertdata(obj);
        //}

        public static List<PAGE_MASTER_Base> getdata()
        {
            PAGE_MASTERDL ed = new PAGE_MASTERDL();
            return ed.getdata();
        }
        public static PAGE_MASTER_Base getdata(int id)
        {
            PAGE_MASTERDL ed = new PAGE_MASTERDL();
            return ed.getdata(id);
        }
    }
}
