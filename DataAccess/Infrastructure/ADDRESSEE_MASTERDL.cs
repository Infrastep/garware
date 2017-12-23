using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.EF;
using BaseClass;
namespace DataAccess.Infrastructure
{
    public class ADDRESSEE_MASTERDL : COreEI
    {
        /// <summery>
        /// get all data from Address
        ///  returns List<Address>
        /// </summery>
        public List<ADDRESSEE_MASTER_Base> getdata()
        {

            List<ADDRESSEE_MASTER> dr = db1.ADDRESSEE_MASTER.ToList();
            List<ADDRESSEE_MASTER_Base> drb = generate_Base(dr);
            return drb;

        }

        public ADDRESSEE_MASTER_Base getdata(int id)
        {

            ADDRESSEE_MASTER dr = db1.ADDRESSEE_MASTER.Where(q => q.ADDRESSID == id).Single();
            ADDRESSEE_MASTER_Base STM = generate_Base(dr);
            return STM;


        }
        public List<ADDRESSEE_MASTER_Base> getdataByCompanyId(int id)
        {

            List<ADDRESSEE_MASTER> dr = db1.ADDRESSEE_MASTER.Where(q => q.COMPANYID == id).ToList();
            List<ADDRESSEE_MASTER_Base> drb = generate_Base(dr);
            return drb;

        }

        public ADDRESSEE_MASTER_Base insertdata(ADDRESSEE_MASTER_Base dr)
        {
            int id = dr.ADDRESSID;
            if (id != 0)
            {
                ADDRESSEE_MASTER result = db1.ADDRESSEE_MASTER.Where(q => q.ADDRESSID == id).Single();
                if (result != null)
                {
                    result.ADDRESSID = dr.ADDRESSID;
                    result.ADDR0 = dr.ADDR0;
                    result.ADDR1 = dr.ADDR1;
                    result.CITY = dr.CITY;
                    result.COUNTRY = dr.COUNTRY;
                    result.ZIP = dr.ZIP;
                    result.COMPANYID = dr.COMPANYID;
                    result.STATUS = dr.STATUS;
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                ADDRESSEE_MASTER result = new ADDRESSEE_MASTER();
               
                result.ADDR0 = dr.ADDR0;
                result.ADDR1 = dr.ADDR1;
                result.CITY = dr.CITY;
                result.COUNTRY = dr.COUNTRY;
                result.ZIP = dr.ZIP;
                result.COMPANYID = dr.COMPANYID;
                result.STATUS = dr.STATUS;
                db1.ADDRESSEE_MASTER.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static ADDRESSEE_MASTER_Base generate_Base(ADDRESSEE_MASTER dr)
        {

            ADDRESSEE_MASTER_Base drb = new ADDRESSEE_MASTER_Base();
            drb.ADDRESSID = dr.ADDRESSID;
            drb.ADDR0 = dr.ADDR0;
            drb.ADDR1 = dr.ADDR1;
            drb.CITY = dr.CITY;
            drb.COUNTRY = dr.COUNTRY;
            drb.ZIP = dr.ZIP;
            drb.COMPANYID = dr.COMPANYID; 
            drb.STATUS = dr.STATUS;
            drb.COUNTRY_MASTER = COUNTRY_MASTERDL.generate_Base(dr.COUNTRY_MASTER);
            drb.COMPANY_PARAMETER = COMPANY_PARAMETERDL.generate_Base(dr.COMPANY_PARAMETER);
            return drb;
        }

        public static List<ADDRESSEE_MASTER_Base> generate_Base(ICollection<ADDRESSEE_MASTER> i)
        {
            List<ADDRESSEE_MASTER_Base> drbl = new List<ADDRESSEE_MASTER_Base>();
            int x = 0;
            foreach (ADDRESSEE_MASTER dr in i)
            {
                ADDRESSEE_MASTER_Base drb = new ADDRESSEE_MASTER_Base();
                drb.ADDRESSID = dr.ADDRESSID;
                drb.ADDR0 = dr.ADDR0;
                drb.ADDR1 = dr.ADDR1;
                drb.CITY = dr.CITY;
                drb.COUNTRY = dr.COUNTRY;
                drb.ZIP = dr.ZIP;
                drb.COMPANYID = dr.COMPANYID;
                drb.STATUS = dr.STATUS;
                drb.COUNTRY_MASTER = COUNTRY_MASTERDL.generate_Base(dr.COUNTRY_MASTER);
                drb.COMPANY_PARAMETER = COMPANY_PARAMETERDL.generate_Base(dr.COMPANY_PARAMETER);


                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
