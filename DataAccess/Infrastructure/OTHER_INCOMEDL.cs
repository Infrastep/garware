using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
    public class OTHER_INCOMEDL :COreEI
    {
        public List<OTHER_INCOME_Base> getdata()
        {

            List<OTHER_INCOME> dr = db1.OTHER_INCOME.ToList();
            List<OTHER_INCOME_Base> drb = generate_Base(dr);
            return drb;

        }

        public OTHER_INCOME_Base getdata(int id)
        {

            OTHER_INCOME dr = db1.OTHER_INCOME.Where(q => q.ID == id).Single();
            OTHER_INCOME_Base STM = generate_Base(dr);
            return STM;


        }

        public OTHER_INCOME_Base insertdata(OTHER_INCOME_Base dr)
        {
            int id = dr.ID;
            if (id != 0)
            {
                OTHER_INCOME result = db1.OTHER_INCOME.Where(q => q.ID == id).Single();
                if (result != null)
                {
                    result.ID = dr.ID;
                    result.DESCRIPTION = dr.DESCRIPTION;
                    result.TYPE = dr.TYPE;
                    result.NON_TAXABLE_LIMIT = dr.NON_TAXABLE_LIMIT;


                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                OTHER_INCOME result = new OTHER_INCOME();
                
                result.DESCRIPTION = dr.DESCRIPTION;
                result.TYPE = dr.TYPE;
                result.NON_TAXABLE_LIMIT = dr.NON_TAXABLE_LIMIT;
                db1.OTHER_INCOME.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static OTHER_INCOME_Base generate_Base(OTHER_INCOME dr)
        {

            OTHER_INCOME_Base drb = new OTHER_INCOME_Base();
            drb.ID = dr.ID;
            drb.DESCRIPTION = dr.DESCRIPTION;
            drb.TYPE = dr.TYPE;
            drb.NON_TAXABLE_LIMIT = dr.NON_TAXABLE_LIMIT;

            return drb;
        }

        public static List<OTHER_INCOME_Base> generate_Base(ICollection<OTHER_INCOME> i)
        {
            List<OTHER_INCOME_Base> drbl = new List<OTHER_INCOME_Base>();
            int x = 0;
            foreach (OTHER_INCOME dr in i)
            {
                OTHER_INCOME_Base drb = new OTHER_INCOME_Base();
                drb.ID = dr.ID;
                drb.DESCRIPTION = dr.DESCRIPTION;
                drb.TYPE = dr.TYPE;
                drb.NON_TAXABLE_LIMIT = dr.NON_TAXABLE_LIMIT;
              
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
