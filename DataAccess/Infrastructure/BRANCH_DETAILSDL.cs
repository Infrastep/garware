using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure 
{
   public class BRANCH_DETAILSDL :COreEI
    {
        /// <summery>
        /// get all data from Address
        ///  returns List<Address>
        /// </summery>
        public List<BRANCH_DETAILS_Base> getdata()
        {

            List<BRANCH_DETAILS> dr = db1.BRANCH_DETAILS.ToList();
            List<BRANCH_DETAILS_Base> drb = generate_Base(dr);
            return drb;

        }

        public BRANCH_DETAILS_Base getdata(int id)
        {

            BRANCH_DETAILS dr = db1.BRANCH_DETAILS.Where(q => q.BRANCHID == id).Single();
            BRANCH_DETAILS_Base STM = generate_Base(dr);
            return STM;


        }

        public BRANCH_DETAILS_Base insertdata(BRANCH_DETAILS_Base dr)
        {
            int id = dr.BRANCHID;
            if (id != 0)
            {
                BRANCH_DETAILS result = db1.BRANCH_DETAILS.Where(q => q.BRANCHID == id).Single();
                if (result != null)
                {
                    result.IFSCCODE = dr.IFSCCODE;
                    result.MICRCODE = dr.MICRCODE;
                    result.SWIFTCODE = dr.SWIFTCODE;
                    result.ADDRESS1 = dr.ADDRESS1;
                    result.ADDRESS2 = dr.ADDRESS2;
                    result.CITY = dr.CITY;
                    result.STATE = dr.STATE;
                    result.PIN = dr.PIN;
                    result.COUNTRYID = dr.COUNTRYID;
                    result.BANKID = dr.BANKID;
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                BRANCH_DETAILS result = new BRANCH_DETAILS();
                result.BRANCHID = dr.BRANCHID;
                result.IFSCCODE = dr.IFSCCODE;
                result.MICRCODE = dr.MICRCODE;
                result.SWIFTCODE = dr.SWIFTCODE;
                result.ADDRESS1 = dr.ADDRESS1;
                result.ADDRESS2 = dr.ADDRESS2;
                result.CITY = dr.CITY;
                result.STATE = dr.STATE;
                result.PIN = dr.PIN;
                result.COUNTRYID = dr.COUNTRYID;
                result.BANKID = dr.BANKID;
                db1.BRANCH_DETAILS.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static BRANCH_DETAILS_Base generate_Base(BRANCH_DETAILS dr)
        {

            BRANCH_DETAILS_Base drb = new BRANCH_DETAILS_Base();
            if (dr != null)
            {
                drb.BRANCHID = dr.BRANCHID;
                drb.IFSCCODE = dr.IFSCCODE;
                drb.MICRCODE = dr.MICRCODE;
                drb.SWIFTCODE = dr.SWIFTCODE;
                drb.ADDRESS1 = dr.ADDRESS1;
                drb.ADDRESS2 = dr.ADDRESS2;
                drb.CITY = dr.CITY;
                drb.STATE = dr.STATE;
                drb.PIN = dr.PIN;
                drb.COUNTRYID = dr.COUNTRYID;
                drb.BANKID = dr.BANKID;
                drb.COUNTRY_MASTER = COUNTRY_MASTERDL.generate_Base(dr.COUNTRY_MASTER);
                drb.BANK_MASTER = BANK_MASTERDL.generate_Base(dr.BANK_MASTER);
            }
            return drb;
        }

        public static List<BRANCH_DETAILS_Base> generate_Base(ICollection<BRANCH_DETAILS> i)
        {
            List<BRANCH_DETAILS_Base> drbl = new List<BRANCH_DETAILS_Base>();
            int x = 0;
            foreach (BRANCH_DETAILS dr in i)
            {
                BRANCH_DETAILS_Base drb = new BRANCH_DETAILS_Base();
                drb.BRANCHID = dr.BRANCHID;
                drb.IFSCCODE = dr.IFSCCODE;
                drb.MICRCODE = dr.MICRCODE;
                drb.SWIFTCODE = dr.SWIFTCODE;
                drb.ADDRESS1 = dr.ADDRESS1;
                drb.ADDRESS2 = dr.ADDRESS2;
                drb.CITY = dr.CITY;
                drb.STATE = dr.STATE;
                drb.PIN = dr.PIN;
                drb.COUNTRYID = dr.COUNTRYID;
                drb.BANKID = dr.BANKID;
                drb.COUNTRY_MASTER = COUNTRY_MASTERDL.generate_Base(dr.COUNTRY_MASTER);
                drb.BANK_MASTER = BANK_MASTERDL.generate_Base(dr.BANK_MASTER);
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
