using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
   public class DOCUMENTS_MASTERDL :COreEI
    {
        public List<DOCUMENTS_MASTER_Base> getdata()
        {

            List<DOCUMENTS_MASTER> dr = db1.DOCUMENTS_MASTER.ToList();
            List<DOCUMENTS_MASTER_Base> drb = generate_Base(dr);
            return drb;

        }


        public DOCUMENTS_MASTER_Base getdata(int id)
        {

            DOCUMENTS_MASTER dr = db1.DOCUMENTS_MASTER.Where(q => q.DMID == id).Single();
            DOCUMENTS_MASTER_Base STM = generate_Base(dr);
            return STM;


        }
        public List<DOCUMENTS_MASTER_Base> getdataByEmpId(DOCUMENTS_MASTER_Base d)
        {

            List<DOCUMENTS_MASTER_Base> STM = new List<DOCUMENTS_MASTER_Base>();
            var lst = db1.DOCUMENTS_MASTER.Where(q => q.EMP_ID == d.EMP_ID).ToList();
            if (lst.Count > 0)
            {
                List<DOCUMENTS_MASTER> dr = lst.ToList();
                STM = generate_Base(dr);
            }

            return STM;

        }
        public int getdataByDocType(string code)
        {

            
            var lst = (from d in db1.DOCUMENTS_MASTER
                       join dt in db1.DOCUMENTS_TYPE on d.DOCUMENTS_TYPE.DTID equals dt.DTID
                       where dt.DTNAME == "CDC" && d.DMCODE == code
                       select new { d, dt }).ToList();


            
            return lst.Count;

        }
        public DOCUMENTS_MASTER_Base insertdata(DOCUMENTS_MASTER_Base dr)
        {
            int id = dr.DMID;
            if (id != 0)
            {
                DOCUMENTS_MASTER result = db1.DOCUMENTS_MASTER.Where(q => q.DMID == id).Single();
                if (result != null)
                {
                    result.DMID = dr.DMID;
                    result.DMCODE = dr.DMCODE;
                    result.DMDESCRIPTION = dr.DMDESCRIPTION;
                    result.PATH = dr.PATH;
                    result.EMP_ID = dr.EMP_ID;
                    result.LAST_MODIFY = dr.LAST_MODIFY;
                    result.VALIDITY = dr.VALIDITY;
                    result.DT_ID = dr.DT_ID;
                    result.ISSUE_DATE = dr.ISSUE_DATE;
                    result.ISSUE_PLACE = dr.ISSUE_PLACE;
                    result.MED_TYPE = dr.MED_TYPE;
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                DOCUMENTS_MASTER result = new DOCUMENTS_MASTER();
               
                result.DMCODE = dr.DMCODE;
                result.DMDESCRIPTION = dr.DMDESCRIPTION;
                result.PATH = dr.PATH;
                result.EMP_ID = dr.EMP_ID;
                result.LAST_MODIFY = dr.LAST_MODIFY;
                result.VALIDITY = dr.VALIDITY;
                result.DT_ID = dr.DT_ID;
                result.ISSUE_DATE = dr.ISSUE_DATE;
                result.ISSUE_PLACE = dr.ISSUE_PLACE;
                result.MED_TYPE = dr.MED_TYPE;

                db1.DOCUMENTS_MASTER.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static DOCUMENTS_MASTER_Base generate_Base(DOCUMENTS_MASTER dr)
        {

            DOCUMENTS_MASTER_Base drb = new DOCUMENTS_MASTER_Base();
            drb.DMID = dr.DMID;
            drb.DMCODE = dr.DMCODE;
            drb.DMDESCRIPTION = dr.DMDESCRIPTION;
            drb.PATH = dr.PATH;
            drb.EMP_ID = dr.EMP_ID;
            drb.LAST_MODIFY = dr.LAST_MODIFY;
            drb.VALIDITY = dr.VALIDITY;
            drb.DT_ID = dr.DT_ID;
            drb.ISSUE_DATE = dr.ISSUE_DATE;
            drb.ISSUE_PLACE = dr.ISSUE_PLACE;
            drb.MED_TYPE = dr.MED_TYPE;
            drb.COUNTRY_MASTER = COUNTRY_MASTERDL.generate_Base(dr.COUNTRY_MASTER);
            drb.EMP_FIXED = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED);
            drb.DOCUMENTS_TYPE = DOCUMENTS_TYPEDL.generate_Base(dr.DOCUMENTS_TYPE);

            return drb;
        }

        public static List<DOCUMENTS_MASTER_Base> generate_Base(ICollection<DOCUMENTS_MASTER> i)
        {
            List<DOCUMENTS_MASTER_Base> drbl = new List<DOCUMENTS_MASTER_Base>();
            int x = 0;
            foreach (DOCUMENTS_MASTER dr in i)
            {
                DOCUMENTS_MASTER_Base drb = new DOCUMENTS_MASTER_Base();
                drb.DMID = dr.DMID;
                drb.DMCODE = dr.DMCODE;
                drb.DMDESCRIPTION = dr.DMDESCRIPTION;
                drb.PATH = dr.PATH;
                drb.EMP_ID = dr.EMP_ID;
                drb.LAST_MODIFY = dr.LAST_MODIFY;
                drb.VALIDITY = dr.VALIDITY;
                drb.DT_ID = dr.DT_ID;
                drb.ISSUE_DATE = dr.ISSUE_DATE;
                drb.ISSUE_PLACE = dr.ISSUE_PLACE;
                drb.MED_TYPE = dr.MED_TYPE;

                drb.COUNTRY_MASTER = COUNTRY_MASTERDL.generate_Base(dr.COUNTRY_MASTER);
                drb.EMP_FIXED = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED);
                drb.DOCUMENTS_TYPE = DOCUMENTS_TYPEDL.generate_Base(dr.DOCUMENTS_TYPE);
               
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }

    }
}
