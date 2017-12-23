using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
   public class TAX_SLABDL :COreEI

    {
       public List<TAX_SLAB_Base> getdata()
        {

            List<TAX_SLAB> dr = db1.TAX_SLAB.ToList();
            List<TAX_SLAB_Base> drb = generate_Base(dr);
            return drb;

        }

        public TAX_SLAB_Base getdata(int id)
        {

            TAX_SLAB dr = db1.TAX_SLAB.Where(q => q.ID == id).Single();
            TAX_SLAB_Base STM = generate_Base(dr);
            return STM;


        }

        public TAX_SLAB_Base insertdata(TAX_SLAB_Base dr)
        {
            int id = dr.ID;
            if (id != 0)
            {
                TAX_SLAB result = db1.TAX_SLAB.Where(q => q.ID == id).Single();
                if (result != null)
                {
                    result.ID = dr.ID;
                    result.TYPE = dr.TYPE;
                    result.TAX_PER = dr.TAX_PER;
                    result.TAX_AMT = dr.TAX_AMT;
                    result.TO_AMT = dr.TO_AMT;
                    result.FROM_AMT = dr.FROM_AMT;
                    result.FINANCIAL_YEAR = dr.FINANCIAL_YEAR;
                    result.STATUS = dr.STATUS;
               

                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                TAX_SLAB result = new TAX_SLAB();
              
                result.TYPE = dr.TYPE;
                result.TAX_PER = dr.TAX_PER;
                result.TAX_AMT = dr.TAX_AMT;
                result.TO_AMT = dr.TO_AMT;
                result.FROM_AMT = dr.FROM_AMT;
                result.FINANCIAL_YEAR = dr.FINANCIAL_YEAR;
                result.STATUS = dr.STATUS;
                db1.TAX_SLAB.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static TAX_SLAB_Base generate_Base(TAX_SLAB dr)
        {

            TAX_SLAB_Base drb = new TAX_SLAB_Base();
            drb.ID = dr.ID;
            drb.TYPE = dr.TYPE;
            drb.TAX_PER = dr.TAX_PER;
            drb.TAX_AMT = dr.TAX_AMT;
            drb.TO_AMT = dr.TO_AMT;
            drb.FROM_AMT = dr.FROM_AMT;
            drb.FINANCIAL_YEAR = dr.FINANCIAL_YEAR;
            drb.STATUS = dr.STATUS;
            return drb;
        }

        public static List<TAX_SLAB_Base> generate_Base(ICollection<TAX_SLAB> i)
        {
            List<TAX_SLAB_Base> drbl = new List<TAX_SLAB_Base>();
            int x = 0;
            foreach (TAX_SLAB dr in i)
            {
                TAX_SLAB_Base drb = new TAX_SLAB_Base();
                drb.ID = dr.ID;
                drb.TYPE = dr.TYPE;
                drb.TAX_PER = dr.TAX_PER;
                drb.TAX_AMT = dr.TAX_AMT;
                drb.TO_AMT = dr.TO_AMT;
                drb.FROM_AMT = dr.FROM_AMT;
                drb.FINANCIAL_YEAR = dr.FINANCIAL_YEAR;
                drb.STATUS = dr.STATUS;
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
