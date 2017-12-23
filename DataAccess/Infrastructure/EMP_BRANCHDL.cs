using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
   public class EMP_BRANCHDL :COreEI
    {
        public List<EMP_BRANCH_Base> getdata()
        {

            List<EMP_BRANCH> dr = db1.EMP_BRANCH.ToList();
            List<EMP_BRANCH_Base> drb = generate_Base(dr);
            return drb;

        }

        public EMP_BRANCH_Base getdata(int id)
        {

            EMP_BRANCH dr = db1.EMP_BRANCH.Where(q => q.EBID == id).Single();
            EMP_BRANCH_Base STM = generate_Base(dr);
            return STM;


        }

        public List<EMP_BRANCH_Base> getdatabyEmpId(int id)
        {
            List<EMP_BRANCH_Base> STM = new List<EMP_BRANCH_Base>();
            var lst=db1.EMP_BRANCH.Where(q => q.EMPID == id).ToList();
            if(lst.Count > 0)
            {
                List<EMP_BRANCH> dr = lst.ToList();
                STM = generate_Base(dr);
            }
            
            return STM;


        }

       
        public EMP_BRANCH_Base insertdata(EMP_BRANCH_Base dr)
        {
            int id = dr.EBID;
            if (id != 0)
            {
                EMP_BRANCH result = db1.EMP_BRANCH.Where(q => q.EBID == id).Single();
                if (result != null)
                {
                    
                    result.BRANCHID = dr.BRANCHID;
                    result.EMPID = dr.EMPID;
                    result.BANK_AC_NO_NRE = dr.BANK_AC_NO_NRE;
                    result.BANK_NAME_NRE = dr.BANK_NAME_NRE;
                    result.BANK_ADDRESS_NRE = dr.BANK_ADDRESS_NRE;
                    result.CHEQUE_NAME = dr.CHEQUE_NAME;
                    result.IFSC_CODE_NRE = dr.IFSC_CODE_NRE;
                    result.NOT_PF = dr.NOT_PF;

                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                EMP_BRANCH result = new EMP_BRANCH();
                
                result.BRANCHID = dr.BRANCHID;
                result.EMPID = dr.EMPID;
                result.BANK_AC_NO_NRE = dr.BANK_AC_NO_NRE;
                result.BANK_NAME_NRE = dr.BANK_NAME_NRE;
                result.BANK_ADDRESS_NRE = dr.BANK_ADDRESS_NRE;
                result.CHEQUE_NAME = dr.CHEQUE_NAME;
                result.IFSC_CODE_NRE = dr.IFSC_CODE_NRE;
                result.NOT_PF = dr.NOT_PF;
                db1.EMP_BRANCH.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static EMP_BRANCH_Base generate_Base(EMP_BRANCH dr)
        {

            EMP_BRANCH_Base drb = new EMP_BRANCH_Base();
            drb.EBID = dr.EBID;
            drb.BRANCHID = dr.BRANCHID;
            drb.EMPID = dr.EMPID;
            drb.BANK_AC_NO_NRE = dr.BANK_AC_NO_NRE;
            drb.BANK_NAME_NRE = dr.BANK_NAME_NRE;
            drb.BANK_ADDRESS_NRE = dr.BANK_ADDRESS_NRE;
            drb.CHEQUE_NAME = dr.CHEQUE_NAME;
            drb.IFSC_CODE_NRE = dr.IFSC_CODE_NRE;
            drb.NOT_PF = dr.NOT_PF;
            drb.EMP_FIXED = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED);
            drb.BRANCH_DETAILS = BRANCH_DETAILSDL.generate_Base(dr.BRANCH_DETAILS);

            return drb;
        }

        public static List<EMP_BRANCH_Base> generate_Base(ICollection<EMP_BRANCH> i)
        {
            List<EMP_BRANCH_Base> drbl = new List<EMP_BRANCH_Base>();
            int x = 0;
            foreach (EMP_BRANCH dr in i)
            {
                EMP_BRANCH_Base drb = new EMP_BRANCH_Base();
                drb.EBID = dr.EBID;
                drb.BRANCHID = dr.BRANCHID;
                drb.EMPID = dr.EMPID;
                drb.BANK_AC_NO_NRE = dr.BANK_AC_NO_NRE;
                drb.BANK_NAME_NRE = dr.BANK_NAME_NRE;
                drb.BANK_ADDRESS_NRE = dr.BANK_ADDRESS_NRE;
                drb.CHEQUE_NAME = dr.CHEQUE_NAME;
                drb.IFSC_CODE_NRE = dr.IFSC_CODE_NRE;
                drb.NOT_PF = dr.NOT_PF;
                drb.EMP_FIXED = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED);
                drb.BRANCH_DETAILS = BRANCH_DETAILSDL.generate_Base(dr.BRANCH_DETAILS);
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
