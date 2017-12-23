using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class DG_CERTIFIED_DOCTORSBC
    {

        public static DG_CERTIFIED_DOCTORS_Base insertupdateData(DG_CERTIFIED_DOCTORS_Base obj)
        {
            DG_CERTIFIED_DOCTORSDL ed = new DG_CERTIFIED_DOCTORSDL();
            return ed.insertdata(obj);
        }

        public static List<DG_CERTIFIED_DOCTORS_Base> getdata()
        {
            DG_CERTIFIED_DOCTORSDL ed = new DG_CERTIFIED_DOCTORSDL();
            return ed.getdata();
        }


    }
}
