using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
   public class PERSONNEL_MASTERDL :COreEI
    {
       public List<PERSONNEL_MASTER_Base> getdata()
        {

            List<PERSONNEL_MASTER> dr = db1.PERSONNEL_MASTER.ToList();
            List<PERSONNEL_MASTER_Base> drb = generate_Base(dr);
            return drb;

        }

        public PERSONNEL_MASTER_Base getdata(int id)
        {

            PERSONNEL_MASTER dr = db1.PERSONNEL_MASTER.Where(q => q.PERSONNELID == id).Single();
            PERSONNEL_MASTER_Base STM = generate_Base(dr);
            return STM;


        }
        public PERSONNEL_MASTER_Base getdataByUserID(Guid id)
        {

            PERSONNEL_MASTER dr = db1.PERSONNEL_MASTER.Where(q => q.ASP_USER_DETAILS == id).Single();
            PERSONNEL_MASTER_Base STM = generate_Base(dr);
            return STM;


        }
        public PERSONNEL_MASTER_Base insertdata(PERSONNEL_MASTER_Base dr)
        {
            int id = dr.PERSONNELID;
            if (id != 0)
            {
                PERSONNEL_MASTER result = db1.PERSONNEL_MASTER.Where(q => q.PERSONNELID == id).Single();
                if (result != null)
                {
                    result.PERSONNELID = dr.PERSONNELID;
                    result.NAME = dr.NAME;
                    result.PHONE = dr.PHONE;
                    result.EMAIL = dr.EMAIL;
                    result.ASP_USER_DETAILS = dr.ASP_USER_DETAILS;


                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                PERSONNEL_MASTER result = new PERSONNEL_MASTER();
                
                result.NAME = dr.NAME;
                result.PHONE = dr.PHONE;
                result.EMAIL = dr.EMAIL;
                result.ASP_USER_DETAILS = dr.ASP_USER_DETAILS;
                db1.PERSONNEL_MASTER.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static PERSONNEL_MASTER_Base generate_Base(PERSONNEL_MASTER dr)
        {

            PERSONNEL_MASTER_Base drb = new PERSONNEL_MASTER_Base();
            if (dr != null)
            {
                drb.PERSONNELID = dr.PERSONNELID;
                drb.NAME = dr.NAME;
                drb.PHONE = dr.PHONE;
                drb.EMAIL = dr.EMAIL;
                drb.ASP_USER_DETAILS = dr.ASP_USER_DETAILS;
            }
            return drb;
        }

        public static List<PERSONNEL_MASTER_Base> generate_Base(ICollection<PERSONNEL_MASTER> i)
        {
            List<PERSONNEL_MASTER_Base> drbl = new List<PERSONNEL_MASTER_Base>();
            int x = 0;
            foreach (PERSONNEL_MASTER dr in i)
            {
                PERSONNEL_MASTER_Base drb = new PERSONNEL_MASTER_Base();
                drb.PERSONNELID = dr.PERSONNELID;
                drb.NAME = dr.NAME;
                drb.PHONE = dr.PHONE;
                drb.EMAIL = dr.EMAIL;
                drb.ASP_USER_DETAILS = dr.ASP_USER_DETAILS;
                
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
