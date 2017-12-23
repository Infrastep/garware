using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure 
{
   public  class RELIGIONDL :COreEI
    {
       public List<RELIGION_Base> getdata()
        {

            List<RELIGION> dr = db1.RELIGIONs.ToList();
            List<RELIGION_Base> drb = generate_Base(dr);
            return drb;

        }

        public RELIGION_Base getdata(int id)
        {

            RELIGION dr = db1.RELIGIONs.Where(q => q.RELIGIONID == id).Single();
            RELIGION_Base STM = generate_Base(dr);
            return STM;


        }

        public RELIGION_Base insertdata(RELIGION_Base dr)
        {
            int id = dr.RELIGIONID;
            if (id != 0)
            {
                RELIGION result = db1.RELIGIONs.Where(q => q.RELIGIONID == id).Single();
                if (result != null)
                {
                    result.RELIGIONID = dr.RELIGIONID;
                    result.RELIGION_NAME = dr.RELIGION_NAME;
                    result.STATUS = dr.STATUS;
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                RELIGION result = new RELIGION();
                
                result.RELIGION_NAME = dr.RELIGION_NAME;
                result.STATUS = dr.STATUS;
                db1.RELIGIONs.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static RELIGION_Base generate_Base(RELIGION dr)
        {

            RELIGION_Base drb = new RELIGION_Base();
            if (dr != null)
            {
                drb.RELIGIONID = dr.RELIGIONID;
                drb.RELIGION_NAME = dr.RELIGION_NAME;
                drb.STATUS = dr.STATUS;
            }
            return drb;
        }

        public static List<RELIGION_Base> generate_Base(ICollection<RELIGION> i)
        {
            List<RELIGION_Base> drbl = new List<RELIGION_Base>();
            int x = 0;
            foreach (RELIGION dr in i)
            {
                RELIGION_Base drb = new RELIGION_Base();
                drb.RELIGIONID = dr.RELIGIONID;
                drb.RELIGION_NAME = dr.RELIGION_NAME;
                drb.STATUS = dr.STATUS;
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
