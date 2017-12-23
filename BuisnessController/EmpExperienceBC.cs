using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class EmpExperienceBC
    {

        public static EMP_EXPERIENCE_Base insertupdateData(EMP_EXPERIENCE_Base obj)
        {
            EMP_EXPERIENCEDL ed = new EMP_EXPERIENCEDL();
            return ed.insertdata(obj);
        }

        public static List<EMP_EXPERIENCE_Base> getdata()
        {
            EMP_EXPERIENCEDL ed = new EMP_EXPERIENCEDL();
            return ed.getdata();
        }


        public static List<EMP_EXPERIENCE_Base> getdatabyEmpId(EMP_EXPERIENCE_Base eb)
        {
            EMP_EXPERIENCEDL ed = new EMP_EXPERIENCEDL();
            return ed.getdataByEmpId(eb.EMP_id);
        }


    }
}
