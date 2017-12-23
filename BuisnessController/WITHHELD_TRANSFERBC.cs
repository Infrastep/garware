using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class WITHHELD_TRANSFERBC
   {
       public static WITHHELD_TRANSFER_Base insertupdateData(WITHHELD_TRANSFER_Base obj)
       {
           WITHHELD_TRANSFERDL ed = new WITHHELD_TRANSFERDL();
           return ed.insertdata(obj);
       }

       public static List<WITHHELD_TRANSFER_Base> getdata()
       {
           WITHHELD_TRANSFERDL ed = new WITHHELD_TRANSFERDL();
           return ed.getdata();
       }
       public static WITHHELD_TRANSFER_Base getdata(int id)
       {
           WITHHELD_TRANSFERDL ed = new WITHHELD_TRANSFERDL();
           return ed.getdata(id);
       }
    }
}
