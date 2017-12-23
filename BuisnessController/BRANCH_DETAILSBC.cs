using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class BRANCH_DETAILSBC
    {

        public static BRANCH_DETAILS_Base insertupdateData(BRANCH_DETAILS_Base obj)
        {
            BRANCH_DETAILSDL ed = new BRANCH_DETAILSDL();
            return ed.insertdata(obj);
        }

        public static List<BRANCH_DETAILS_Base> getdata()
        {
            BRANCH_DETAILSDL ed = new BRANCH_DETAILSDL();
            return ed.getdata();
        }


    }
}
