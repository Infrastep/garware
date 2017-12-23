using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
  public  class SHIP_TYPE_MASTERDL :COreEI
    {
      public List<SHIP_TYPE_MASTER_Base> getdata()
        {

            List<SHIP_TYPE_MASTER> dr = db1.SHIP_TYPE_MASTER.ToList();
            List<SHIP_TYPE_MASTER_Base> drb = generate_Base(dr);
            return drb;

        }

        public SHIP_TYPE_MASTER_Base getdata(int id)
        {

            SHIP_TYPE_MASTER dr = db1.SHIP_TYPE_MASTER.Where(q => q.TypeID == id).Single();
            SHIP_TYPE_MASTER_Base STM = generate_Base(dr);
            return STM;


        }

        public SHIP_TYPE_MASTER_Base insertdata(SHIP_TYPE_MASTER_Base dr)
        {
            int id = dr.TypeID;
            if (id != 0)
            {
                SHIP_TYPE_MASTER result = db1.SHIP_TYPE_MASTER.Where(q => q.TypeID == id).Single();
                if (result != null)
                {
                    result.TypeID = dr.TypeID;
                    result.Description = dr.Description;
                    result.Status = dr.Status;
              
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                SHIP_TYPE_MASTER result = new SHIP_TYPE_MASTER();
                
                result.Description = dr.Description;
                result.Status = dr.Status;
                db1.SHIP_TYPE_MASTER.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static SHIP_TYPE_MASTER_Base generate_Base(SHIP_TYPE_MASTER dr)
        {

            SHIP_TYPE_MASTER_Base drb = new SHIP_TYPE_MASTER_Base();
            if (dr != null)
            {
                drb.TypeID = dr.TypeID;
                drb.Description = dr.Description;
                drb.Status = dr.Status;
            }

            return drb;
        }

        public static List<SHIP_TYPE_MASTER_Base> generate_Base(ICollection<SHIP_TYPE_MASTER> i)
        {
            List<SHIP_TYPE_MASTER_Base> drbl = new List<SHIP_TYPE_MASTER_Base>();
            int x = 0;
            foreach (SHIP_TYPE_MASTER dr in i)
            {
                SHIP_TYPE_MASTER_Base drb = new SHIP_TYPE_MASTER_Base();
                drb.TypeID = dr.TypeID;
                drb.Description = dr.Description;
                drb.Status = dr.Status;
                drbl.Add(drb);
                x++;
            }
            return drbl;
        }
    }
}
