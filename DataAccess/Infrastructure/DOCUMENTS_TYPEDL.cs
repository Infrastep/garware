using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
   public class DOCUMENTS_TYPEDL : COreEI
    {
        public List<DOCUMENTS_TYPE_Base> getdata()
        {

            List<DOCUMENTS_TYPE> dr = db1.DOCUMENTS_TYPE.ToList();
            List<DOCUMENTS_TYPE_Base> drb = generate_Base(dr);
            return drb;

        }

        public DOCUMENTS_TYPE_Base getdata(int id)
        {

            DOCUMENTS_TYPE dr = db1.DOCUMENTS_TYPE.Where(q => q.DTID == id).Single();
            DOCUMENTS_TYPE_Base STM = generate_Base(dr);
            return STM;


        }

        public DOCUMENTS_TYPE_Base insertdata(DOCUMENTS_TYPE_Base dr)
        {
            int id = dr.DTID;
            if (id != 0)
            {
                DOCUMENTS_TYPE result = db1.DOCUMENTS_TYPE.Where(q => q.DTID == id).Single();
                if (result != null)
                {
                    result.DTID = dr.DTID;
                    result.DTNAME = dr.DTNAME;
                    result.STATUS = dr.STATUS;

                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                DOCUMENTS_TYPE result = new DOCUMENTS_TYPE();
                
                result.DTNAME = dr.DTNAME;
                result.STATUS = dr.STATUS;
                db1.DOCUMENTS_TYPE.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static DOCUMENTS_TYPE_Base generate_Base(DOCUMENTS_TYPE dr)
        {

            DOCUMENTS_TYPE_Base drb = new DOCUMENTS_TYPE_Base();
            if (dr != null)
            {
                drb.DTID = dr.DTID;
                drb.DTNAME = dr.DTNAME;
                drb.STATUS = dr.STATUS;
            }
            return drb;
        }

        public static List<DOCUMENTS_TYPE_Base> generate_Base(ICollection<DOCUMENTS_TYPE> i)
        {
            List<DOCUMENTS_TYPE_Base> drbl = new List<DOCUMENTS_TYPE_Base>();
            int x = 0;
            foreach (DOCUMENTS_TYPE dr in i)
            {
                DOCUMENTS_TYPE_Base drb = new DOCUMENTS_TYPE_Base();
                drb.DTID = dr.DTID;
                drb.DTNAME = dr.DTNAME;
                drb.STATUS = dr.STATUS;
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
