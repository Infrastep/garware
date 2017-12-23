using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class CATEGORYBC
    {

        public static CATEGORY_Base insertupdateData(CATEGORY_Base obj)
        {
            CATEGORYDL ed = new CATEGORYDL();
            return ed.insertdata(obj);
        }

        public static List<CATEGORY_Base> getdata()
        {
            CATEGORYDL ed = new CATEGORYDL();
            return ed.getdata();
        }



    }
}
