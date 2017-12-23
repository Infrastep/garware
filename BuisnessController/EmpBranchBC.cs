using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class EmpBranchBC
    {

        public static EMP_BRANCH_Base insertupdateData(EMP_BRANCH_Base obj)
        {
            EMP_BRANCHDL ed = new EMP_BRANCHDL();
            return ed.insertdata(obj);
        }

        public static List<EMP_BRANCH_Base> getdata()
        {
            EMP_BRANCHDL ed = new EMP_BRANCHDL();
            return ed.getdata();
        }



        public static List<EMP_BRANCH_Base> getdatabyEmpId(EMP_BRANCH_Base eb)
        {
            EMP_BRANCHDL ed = new EMP_BRANCHDL();
            return ed.getdatabyEmpId(eb.EMPID ?? 00);
        }


    }
}
