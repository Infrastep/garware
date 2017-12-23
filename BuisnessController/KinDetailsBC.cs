using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class KinDetailsBC
    {

        public static KIN_DETAILS_Base insertupdateData(KIN_DETAILS_Base obj)
        {
            KIN_DETAILSDL ed = new KIN_DETAILSDL();
            return ed.insertdata(obj);
        }

        public static List<KIN_DETAILS_Base> getdata()
        {
            KIN_DETAILSDL ed = new KIN_DETAILSDL();
            return ed.getdata();
        }


        public static List<KIN_DETAILS_Base> getdatabyEmpId(KIN_DETAILS_Base eb)
        {
            KIN_DETAILSDL ed = new KIN_DETAILSDL();
            return ed.getdatabyEmpId(Convert.ToInt32(eb.EMPID));
        }


    }
}
