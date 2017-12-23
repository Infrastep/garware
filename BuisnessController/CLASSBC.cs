using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class CLASSBC
    {

       public static CLASS_Base insertupdateData(CLASS_Base obj)
        {
            CLASSDL ed = new CLASSDL();
            return ed.insertdata(obj);
        }

       public static List<CLASS_Base> getdata()
        {
            CLASSDL ed = new CLASSDL();
            return ed.getdata();
        }

       public static ADDRESSEE_MASTER_Base getdataMap(int id)
       {
           CLASSDL ed = new CLASSDL();
           return ed.getdataMap(id);
       }


    }
}
