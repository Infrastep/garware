using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
  public  class COMPANY_BRANCHBC
    {
      public static COMPANY_BRANCH_Base insertupdateData(COMPANY_BRANCH_Base obj)
        {
            COMPANY_BRANCHDL ed = new COMPANY_BRANCHDL();
            return ed.insertdata(obj);
        }

      public static List<COMPANY_BRANCH_Base> getdata()
        {
            COMPANY_BRANCHDL ed = new COMPANY_BRANCHDL();
            return ed.getdata();
        }



      public static List<COMPANY_BRANCH_Base> getdatabyComId(COMPANY_BRANCH_Base eb)
        {
            COMPANY_BRANCHDL ed = new COMPANY_BRANCHDL();
            return ed.getdatabyComId(eb.COMPANYID ?? 00);
        }
    }
}
