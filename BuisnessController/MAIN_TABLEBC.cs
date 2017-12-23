using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class MAIN_TABLEBC
    {
        public static MAIN_TABLE_Base insertupdateData(MAIN_TABLE_Base obj)
        {
            MAIN_TABLEDL ed = new MAIN_TABLEDL();
            return ed.insertdata(obj);
        }

        public static List<MAIN_TABLE_Base> getdata()
        {
            MAIN_TABLEDL ed = new MAIN_TABLEDL();
            return ed.getdata();
        }
        public static MAIN_TABLE_Base getdata(int id)
        {
            MAIN_TABLEDL ed = new MAIN_TABLEDL();
            return ed.getdata(id);
        }
    }
}
