using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class MARITIME_HOLIDAYBC
    {
       public static MARITIME_HOLIDAY_Base insertupdateData(MARITIME_HOLIDAY_Base obj)
        {
            MARITIME_HOLIDAYDL ed = new MARITIME_HOLIDAYDL();
            return ed.insertdata(obj);
        }

       public static List<MARITIME_HOLIDAY_Base> getdata()
        {
            MARITIME_HOLIDAYDL ed = new MARITIME_HOLIDAYDL();
            return ed.getdata();
        }
       public static MARITIME_HOLIDAY_Base getdata(int id)
        {
            MARITIME_HOLIDAYDL ed = new MARITIME_HOLIDAYDL();
            return ed.getdata(id);
        }
    }
}
