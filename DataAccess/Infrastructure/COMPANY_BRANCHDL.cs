using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
   public class COMPANY_BRANCHDL : COreEI
    {
        public List<COMPANY_BRANCH_Base> getdata()
        {

            List<COMPANY_BRANCH> dr = db1.COMPANY_BRANCH.ToList();
            List<COMPANY_BRANCH_Base> drb = generate_Base(dr);
            return drb;

        }

        public COMPANY_BRANCH_Base getdata(int id)
        {

            COMPANY_BRANCH dr = db1.COMPANY_BRANCH.Where(q => q.CBID == id).Single();
            COMPANY_BRANCH_Base STM = generate_Base(dr);
            return STM;


        }
        public List<COMPANY_BRANCH_Base> getdatabyComId(int id)
        {
            List<COMPANY_BRANCH_Base> STM = new List<COMPANY_BRANCH_Base>();
            var lst = db1.COMPANY_BRANCH.Where(q => q.COMPANYID == id).ToList();
            if (lst.Count > 0)
            {
                List<COMPANY_BRANCH> dr = lst.ToList();
                STM = generate_Base(dr);
            }

            return STM;


        }

        public COMPANY_BRANCH_Base insertdata(COMPANY_BRANCH_Base dr)
        {
            int id = dr.CBID;
            if (id != 0)
            {
                COMPANY_BRANCH result = db1.COMPANY_BRANCH.Where(q => q.CBID == id).Single();
                if (result != null)
                {
                    result.CBID = dr.CBID;
                    result.BRANCHID = dr.BRANCHID;
                    result.COMPANYID = dr.COMPANYID;
                    result.CHEQUE_NAME = dr.CHEQUE_NAME;
                   
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                COMPANY_BRANCH result = new COMPANY_BRANCH();
                result.BRANCHID = dr.BRANCHID;
                result.COMPANYID = dr.COMPANYID;
                result.CHEQUE_NAME = dr.CHEQUE_NAME;
                db1.COMPANY_BRANCH.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static COMPANY_BRANCH_Base generate_Base(COMPANY_BRANCH dr)
        {

            COMPANY_BRANCH_Base drb = new COMPANY_BRANCH_Base();
            drb.CBID = dr.CBID;
            drb.BRANCHID = dr.BRANCHID;
            drb.COMPANYID = dr.COMPANYID;
            drb.CHEQUE_NAME = dr.CHEQUE_NAME;
            drb.BRANCH_DETAILS = BRANCH_DETAILSDL.generate_Base(dr.BRANCH_DETAILS);
            drb.COMPANY_PARAMETER = COMPANY_PARAMETERDL.generate_Base(dr.COMPANY_PARAMETER);
            return drb;
        }

        public static List<COMPANY_BRANCH_Base> generate_Base(ICollection<COMPANY_BRANCH> i)
        {
            List<COMPANY_BRANCH_Base> drbl = new List<COMPANY_BRANCH_Base>();
            int x = 0;
            foreach (COMPANY_BRANCH dr in i)
            {
                COMPANY_BRANCH_Base drb = new COMPANY_BRANCH_Base();
                drb.CBID = dr.CBID;
                drb.BRANCHID = dr.BRANCHID;
                drb.COMPANYID = dr.COMPANYID;
                drb.CHEQUE_NAME = dr.CHEQUE_NAME;
                drb.BRANCH_DETAILS = BRANCH_DETAILSDL.generate_Base(dr.BRANCH_DETAILS);
                drb.COMPANY_PARAMETER = COMPANY_PARAMETERDL.generate_Base(dr.COMPANY_PARAMETER);

                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }

}
