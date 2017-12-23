using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class PersonnelMasterBC
    {
       public static PERSONNEL_MASTER_Base insertupdateData(PERSONNEL_MASTER_Base obj)
        {
            PERSONNEL_MASTERDL ed = new PERSONNEL_MASTERDL();
            return ed.insertdata(obj);
        }

       public static List<PERSONNEL_MASTER_Base> getdata()
        {
            PERSONNEL_MASTERDL ed = new PERSONNEL_MASTERDL();
            return ed.getdata();
        }
       public static PERSONNEL_MASTER_Base getdataByUserID(Guid id)
       {
           PERSONNEL_MASTERDL ed = new PERSONNEL_MASTERDL();
           return ed.getdataByUserID(id);
       }

    }
}
