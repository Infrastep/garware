using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
   public class SECTION_LIMITDL : COreEI
    {
       public List<SECTION_LIMIT_Base> getdata()
        {

            List<SECTION_LIMIT> dr = db1.SECTION_LIMIT.ToList();
            List<SECTION_LIMIT_Base> drb = generate_Base(dr);
            return drb;

        }

        public SECTION_LIMIT_Base getdata(int id)
        {

            SECTION_LIMIT dr = db1.SECTION_LIMIT.Where(q => q.ID == id).Single();
            SECTION_LIMIT_Base STM = generate_Base(dr);
            return STM;


        }

        public SECTION_LIMIT_Base insertdata(SECTION_LIMIT_Base dr)
        {
            int id = dr.ID;
            if (id != 0)
            {
                SECTION_LIMIT result = db1.SECTION_LIMIT.Where(q => q.ID == id).Single();
                if (result != null)
                {
                    result.ID = dr.ID;
                    result.SECTION = dr.SECTION;
                    result.MAX_LIMIT = dr.MAX_LIMIT;
                    result.STATUS = dr.STATUS;
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                SECTION_LIMIT result = new SECTION_LIMIT();
                
                result.SECTION = dr.SECTION;
                result.MAX_LIMIT = dr.MAX_LIMIT;
                result.STATUS = dr.STATUS;
                db1.SECTION_LIMIT.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static SECTION_LIMIT_Base generate_Base(SECTION_LIMIT dr)
        {

            SECTION_LIMIT_Base drb = new SECTION_LIMIT_Base();
            if (dr != null)
            {
                drb.ID = dr.ID;
                drb.SECTION = dr.SECTION;
                drb.MAX_LIMIT = dr.MAX_LIMIT;
                drb.STATUS = dr.STATUS;
            }
            return drb;
        }

        public static List<SECTION_LIMIT_Base> generate_Base(ICollection<SECTION_LIMIT> i)
        {
            List<SECTION_LIMIT_Base> drbl = new List<SECTION_LIMIT_Base>();
            int x = 0;
            foreach (SECTION_LIMIT dr in i)
            {
                SECTION_LIMIT_Base drb = new SECTION_LIMIT_Base();
                drb.ID = dr.ID;
                drb.SECTION = dr.SECTION;
                drb.MAX_LIMIT = dr.MAX_LIMIT;
                drb.STATUS = dr.STATUS;
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
