using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
   public class COUNTRY_MASTERDL :COreEI
    {
        public List<COUNTRY_MASTER_Base> getdata()
        {

            List<COUNTRY_MASTER> dr = db1.COUNTRY_MASTER.ToList();
            List<COUNTRY_MASTER_Base> drb = generate_Base(dr);
            return drb;

        }

        public COUNTRY_MASTER_Base getdata(int id)
        {

            COUNTRY_MASTER dr = db1.COUNTRY_MASTER.Where(q => q.CID == id).Single();
            COUNTRY_MASTER_Base STM = generate_Base(dr);
            return STM;


        }

        public COUNTRY_MASTER_Base insertdata(COUNTRY_MASTER_Base dr)
        {
            int id = dr.CID;
            if (id != 0)
            {
                COUNTRY_MASTER result = db1.COUNTRY_MASTER.Where(q => q.CID == id).Single();
                if (result != null)
                {
                    result.CID = dr.CID;
                    result.C_Name = dr.C_Name;
                    result.add_by = dr.add_by;
                    result.CCODE = dr.CCODE;
                    result.Edit_by = dr.Edit_by;
                    result.add_time = Convert.ToDateTime(dr.add_time);
                    result.Edit_time = Convert.ToDateTime(dr.Edit_time);
                    result.status = dr.status;
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                COUNTRY_MASTER result = new COUNTRY_MASTER();
                result.C_Name = dr.C_Name;
                result.add_by = dr.add_by;
                result.CCODE = dr.CCODE;
                result.Edit_by = dr.Edit_by;
                result.add_time = Convert.ToDateTime(dr.add_time);
                result.Edit_time = Convert.ToDateTime(dr.Edit_time);
                result.status = dr.status;
                db1.COUNTRY_MASTER.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static COUNTRY_MASTER_Base generate_Base(COUNTRY_MASTER dr)
        {

            COUNTRY_MASTER_Base drb = new COUNTRY_MASTER_Base();
            if (dr != null)
            {
                drb.CID = dr.CID;
                drb.CCODE = dr.CCODE;
                drb.C_Name = dr.C_Name;
                drb.add_by = dr.add_by;

                drb.Edit_by = dr.Edit_by;
                drb.add_time = Convert.ToDateTime(dr.add_time);
                drb.Edit_time = Convert.ToDateTime(dr.Edit_time);
                drb.status = dr.status;
            }

            return drb;
        }

        public static List<COUNTRY_MASTER_Base> generate_Base(ICollection<COUNTRY_MASTER> i)
        {
            List<COUNTRY_MASTER_Base> drbl = new List<COUNTRY_MASTER_Base>();
            int x = 0;
            foreach (COUNTRY_MASTER dr in i)
            {
                COUNTRY_MASTER_Base drb = new COUNTRY_MASTER_Base();
                drb.CID = dr.CID;
                drb.CCODE = dr.CCODE;
                drb.C_Name = dr.C_Name;
                drb.add_by = dr.add_by;

                drb.Edit_by = dr.Edit_by;
                drb.add_time = Convert.ToDateTime(dr.add_time);
                drb.Edit_time = Convert.ToDateTime(dr.Edit_time);
                drb.status = dr.status;
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
