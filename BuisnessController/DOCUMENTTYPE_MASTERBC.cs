using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class DOCUMENTTYPE_MASTERBC
    {
       public static DOCUMENTS_TYPE_Base insertupdateData(DOCUMENTS_TYPE_Base obj)
        {
            DOCUMENTS_TYPEDL ed = new DOCUMENTS_TYPEDL();
            return ed.insertdata(obj);
        }

       public static List<DOCUMENTS_TYPE_Base> getdata()
        {
            DOCUMENTS_TYPEDL ed = new DOCUMENTS_TYPEDL();
            return ed.getdata();
        }
    }
}
