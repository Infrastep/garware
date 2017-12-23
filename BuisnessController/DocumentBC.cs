using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class DocumentBC
    {
       public static DOCUMENTS_MASTER_Base insertupdateData(DOCUMENTS_MASTER_Base obj)
        {
            DOCUMENTS_MASTERDL ed = new DOCUMENTS_MASTERDL();
            return ed.insertdata(obj);
        }

       public static List<DOCUMENTS_MASTER_Base> getdata()
        {
            DOCUMENTS_MASTERDL ed = new DOCUMENTS_MASTERDL();
            return ed.getdata();
        }



       public static List<DOCUMENTS_MASTER_Base> getdatabyEmpId(DOCUMENTS_MASTER_Base eb)
        {
            DOCUMENTS_MASTERDL ed = new DOCUMENTS_MASTERDL();
            return ed.getdataByEmpId(eb);
        }

       public static int getdataByDocType(string code)
       {
           DOCUMENTS_MASTERDL ed = new DOCUMENTS_MASTERDL();
           return ed.getdataByDocType(code);
       }
    }
}
