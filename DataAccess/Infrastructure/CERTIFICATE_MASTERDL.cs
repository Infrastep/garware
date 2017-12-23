using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.EF;
using BaseClass;
namespace DataAccess.Infrastructure
{
   public class CERTIFICATE_MASTERDL :COreEI
    {
        /// <summery>
        /// get all data from Address
        ///  returns List<Address>
        /// </summery>
        public List<CERTIFICATE_MASTER_Base> getdata()
        {

            List<CERTIFICATE_MASTER> dr = db1.CERTIFICATE_MASTER.ToList();
            List<CERTIFICATE_MASTER_Base> drb = generate_Base(dr);
            return drb;

        }

        public CERTIFICATE_MASTER_Base getdata(int id)
        {

            CERTIFICATE_MASTER dr = db1.CERTIFICATE_MASTER.Where(q => q.CERTID == id).Single();
            CERTIFICATE_MASTER_Base STM = generate_Base(dr);
            return STM;


        }
        public List<CERTIFICATE_MASTER_Base> getdatabyEmpId(int id)
        {
            List<CERTIFICATE_MASTER_Base> STM = new List<CERTIFICATE_MASTER_Base>();
            var lst = db1.CERTIFICATE_MASTER.Where(q => q.EMP_ID == id).ToList();
            if (lst.Count > 0)
            {
                List<CERTIFICATE_MASTER> dr = lst.ToList();
                STM = generate_Base(dr);
            }

            return STM;


        }
        public CERTIFICATE_MASTER_Base insertdata(CERTIFICATE_MASTER_Base dr)
        {
            int id = dr.CERTID;
            if (id != 0)
            {
                CERTIFICATE_MASTER result = db1.CERTIFICATE_MASTER.Where(q => q.CERTID == id).Single();
                if (result != null)
                {
                    result.CERTID = dr.CERTID;
                    result.CERT_DESC = dr.CERT_DESC.Trim();
                    result.CTID = dr.CTID;
                    result.LAST_MODIFY = dr.LAST_MODIFY;
                    result.VALIDITY = dr.VALIDITY;
                    result.PATH = dr.PATH;
                    result.EMP_ID = dr.EMP_ID;
                    result.ISSUE_PLACE = dr.ISSUE_PLACE;


                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                CERTIFICATE_MASTER result = new CERTIFICATE_MASTER();
                
                result.CERT_DESC = dr.CERT_DESC.Trim();
                result.CTID = dr.CTID;
                result.LAST_MODIFY = dr.LAST_MODIFY;
                result.VALIDITY = dr.VALIDITY;
                result.PATH = dr.PATH;
                result.EMP_ID = dr.EMP_ID;
                result.ISSUE_PLACE = dr.ISSUE_PLACE;
                db1.CERTIFICATE_MASTER.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static CERTIFICATE_MASTER_Base generate_Base(CERTIFICATE_MASTER dr)
        {

            CERTIFICATE_MASTER_Base drb = new CERTIFICATE_MASTER_Base();
            drb.CERTID = dr.CERTID;
            drb.CERT_DESC = dr.CERT_DESC;

            drb.LAST_MODIFY = dr.LAST_MODIFY;
            drb.VALIDITY = dr.VALIDITY;
            drb.PATH = dr.PATH;
            drb.EMP_ID = dr.EMP_ID;
            drb.CTID = dr.CTID;
            drb.ISSUE_PLACE = dr.ISSUE_PLACE;
            drb.COUNTRY_MASTER = COUNTRY_MASTERDL.generate_Base(dr.COUNTRY_MASTER);
            drb.EMP_FIXED = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED);
            drb.CERTIFICATE_TYPE_MASTER = CERTIFICATE_TYPE_MASTERDL.generate_Base(dr.CERTIFICATE_TYPE_MASTER);
            return drb;
        }

        public static List<CERTIFICATE_MASTER_Base> generate_Base(ICollection<CERTIFICATE_MASTER> i)
        {
            List<CERTIFICATE_MASTER_Base> drbl = new List<CERTIFICATE_MASTER_Base>();
            int x = 0;
            foreach (CERTIFICATE_MASTER dr in i)
            {
                CERTIFICATE_MASTER_Base drb = new CERTIFICATE_MASTER_Base();
                drb.CERTID = dr.CERTID;
                drb.CERT_DESC = dr.CERT_DESC;
                drb.CTID = dr.CTID;
                drb.LAST_MODIFY = dr.LAST_MODIFY;
                drb.VALIDITY = dr.VALIDITY;
                drb.PATH = dr.PATH;
                drb.EMP_ID = dr.EMP_ID;
                drb.ISSUE_PLACE = dr.ISSUE_PLACE;
                drb.COUNTRY_MASTER = COUNTRY_MASTERDL.generate_Base(dr.COUNTRY_MASTER);
                drb.EMP_FIXED = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED);
                drb.CERTIFICATE_TYPE_MASTER = CERTIFICATE_TYPE_MASTERDL.generate_Base(dr.CERTIFICATE_TYPE_MASTER);
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
