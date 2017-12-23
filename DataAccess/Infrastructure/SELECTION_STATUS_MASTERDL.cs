using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
   public class SELECTION_STATUS_MASTERDL :COreEI

    {
       public List<SELECTION_STATUS_MASTER_Base> getdata()
        {

            List<SELECTION_STATUS_MASTER> dr = db1.SELECTION_STATUS_MASTER.ToList();
            List<SELECTION_STATUS_MASTER_Base> drb = generate_Base(dr);
            return drb;

        }

       public SELECTION_STATUS_MASTER_Base getdata(int id)
        {

            SELECTION_STATUS_MASTER dr = db1.SELECTION_STATUS_MASTER.Where(q => q.SPID == id).Single();
            SELECTION_STATUS_MASTER_Base STM = generate_Base(dr);
            return STM;


        }

       public SELECTION_STATUS_MASTER_Base insertdata(SELECTION_STATUS_MASTER dr)
        {
            int id = dr.SPID;
            if (id != 0)
            {
                SELECTION_STATUS_MASTER result = db1.SELECTION_STATUS_MASTER.Where(q => q.SPID == id).Single();
                if (result != null)
                {
                    result.SPID = dr.SPID;
                    result.SPNAME = dr.SPNAME;
                    result.SPDESCRIPTION = dr.SPDESCRIPTION;
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                SELECTION_STATUS_MASTER result = new SELECTION_STATUS_MASTER();
                
                result.SPNAME = dr.SPNAME;
                result.SPDESCRIPTION = dr.SPDESCRIPTION;
                db1.SELECTION_STATUS_MASTER.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static SELECTION_STATUS_MASTER_Base generate_Base(SELECTION_STATUS_MASTER dr)
        {

            SELECTION_STATUS_MASTER_Base drb = new SELECTION_STATUS_MASTER_Base();
            if (dr != null)
            {
                drb.SPID = dr.SPID;
                drb.SPNAME = dr.SPNAME;
                drb.SPDESCRIPTION = dr.SPDESCRIPTION;
            }
            return drb;
        }

        public static List<SELECTION_STATUS_MASTER_Base> generate_Base(ICollection<SELECTION_STATUS_MASTER> i)
        {
            List<SELECTION_STATUS_MASTER_Base> drbl = new List<SELECTION_STATUS_MASTER_Base>();
            int x = 0;
            foreach (SELECTION_STATUS_MASTER dr in i)
            {
                SELECTION_STATUS_MASTER_Base drb = new SELECTION_STATUS_MASTER_Base();
                drb.SPID = dr.SPID;
                drb.SPNAME = dr.SPNAME;
                drb.SPDESCRIPTION = dr.SPDESCRIPTION;
              

                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
