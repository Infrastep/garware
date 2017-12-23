using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
   public class SALUTATIONDL :COreEI
    {
        public List<SALUTATION_Base> getdata()
        {

            List<SALUTATION> dr = db1.SALUTATIONs.ToList();
            List<SALUTATION_Base> drb = generate_Base(dr);
            return drb;

        }

        public SALUTATION_Base getdata(int id)
        {

            SALUTATION dr = db1.SALUTATIONs.Where(q => q.SalutationID == id).Single();
            SALUTATION_Base STM = generate_Base(dr);
            return STM;


        }

        public SALUTATION_Base insertdata(SALUTATION_Base dr)
        {
            int id = dr.SalutationID;
            if (id != 0)
            {
                SALUTATION result = db1.SALUTATIONs.Where(q => q.SalutationID == id).Single();
                if (result != null)
                {
                    result.SalutationID = dr.SalutationID;
                    result.SalutationName = dr.SalutationName;

                    result.IsDeleted = dr.IsDeleted;



                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                SALUTATION result = new SALUTATION();

                result.SalutationName = dr.SalutationName;

                result.IsDeleted = dr.IsDeleted;

                db1.SALUTATIONs.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static SALUTATION_Base generate_Base(SALUTATION dr)
        {

            SALUTATION_Base drb = new SALUTATION_Base();
            if (dr != null)
            {
                drb.SalutationID = dr.SalutationID;
                drb.SalutationName = dr.SalutationName;

                drb.IsDeleted = dr.IsDeleted;


            }
            return drb;
        }

        public static List<SALUTATION_Base> generate_Base(ICollection<SALUTATION> i)
        {
            List<SALUTATION_Base> drbl = new List<SALUTATION_Base>();
            int x = 0;
            foreach (SALUTATION dr in i)
            {
                SALUTATION_Base drb = new SALUTATION_Base();
                drb.SalutationID = dr.SalutationID;
                drb.SalutationName = dr.SalutationName;

                drb.IsDeleted = dr.IsDeleted;


                drbl.Add(drb);

                x++;
            }
            return drbl;
        }

    }
}
