using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
   public class RELATIONSHIP_MASTERDL :COreEI
    {
       public List<RELATIONSHIP_MASTER_Base> getdata()
        {

            List<RELATIONSHIP_MASTER> dr = db1.RELATIONSHIP_MASTER.ToList();
            List<RELATIONSHIP_MASTER_Base> drb = generate_Base(dr);
            return drb;

        }

        public RELATIONSHIP_MASTER_Base getdata(int id)
        {

            RELATIONSHIP_MASTER dr = db1.RELATIONSHIP_MASTER.Where(q => q.RELATIONSHIPID == id).Single();
            RELATIONSHIP_MASTER_Base STM = generate_Base(dr);
            return STM;


        }

        public RELATIONSHIP_MASTER_Base insertdata(RELATIONSHIP_MASTER_Base dr)
        {
            int id = dr.RELATIONSHIPID;
            if (id != 0)
            {
                RELATIONSHIP_MASTER result = db1.RELATIONSHIP_MASTER.Where(q => q.RELATIONSHIPID == id).Single();
                if (result != null)
                {
                    result.RELATIONSHIPID = dr.RELATIONSHIPID;
                    result.RELATION = dr.RELATION;
                    result.STATUS = dr.STATUS;
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                RELATIONSHIP_MASTER result = new RELATIONSHIP_MASTER();
               
                result.RELATION = dr.RELATION;
                result.STATUS = dr.STATUS;
                db1.RELATIONSHIP_MASTER.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static RELATIONSHIP_MASTER_Base generate_Base(RELATIONSHIP_MASTER dr)
        {

            RELATIONSHIP_MASTER_Base drb = new RELATIONSHIP_MASTER_Base();
            if (dr != null)
            {
                drb.RELATIONSHIPID = dr.RELATIONSHIPID;
                drb.RELATION = dr.RELATION;
                drb.STATUS = dr.STATUS;
            }
            return drb;
        }

        public static List<RELATIONSHIP_MASTER_Base> generate_Base(ICollection<RELATIONSHIP_MASTER> i)
        {
            List<RELATIONSHIP_MASTER_Base> drbl = new List<RELATIONSHIP_MASTER_Base>();
            int x = 0;
            foreach (RELATIONSHIP_MASTER dr in i)
            {
                RELATIONSHIP_MASTER_Base drb = new RELATIONSHIP_MASTER_Base();
                drb.RELATIONSHIPID = dr.RELATIONSHIPID;
                drb.RELATION = dr.RELATION;
                drb.STATUS = dr.STATUS;
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
