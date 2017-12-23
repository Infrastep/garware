using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
   public class RANK_CLASSDL :COreEI
    {
       public List<RANK_CLASS_Base> getdata()
        {

            List<RANK_CLASS> dr = db1.RANK_CLASS.ToList();
            List<RANK_CLASS_Base> drb = generate_Base(dr);
            return drb;

        }

        public RANK_CLASS_Base getdata(int id)
        {

            RANK_CLASS dr = db1.RANK_CLASS.Where(q => q.RCID == id).Single();
            RANK_CLASS_Base STM = generate_Base(dr);
            return STM;


        }

        public RANK_CLASS_Base insertdata(RANK_CLASS_Base dr)
        {
            int id = dr.RCID;
            if (id != 0)
            {
                RANK_CLASS result = db1.RANK_CLASS.Where(q => q.RCID == id).Single();
                if (result != null)
                {

                    result.RCID = dr.RCID;

                    result.Class_Type = dr.Class_Type;
                    result.RANKID = dr.RANKID;
                    result.CLASSID = dr.CLASSID;
                    
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                RANK_CLASS result = new RANK_CLASS();
                
                result.Class_Type = dr.Class_Type;
                result.RANKID = dr.RANKID;
                result.CLASSID = dr.CLASSID;
                db1.RANK_CLASS.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static RANK_CLASS_Base generate_Base(RANK_CLASS dr)
        {

            RANK_CLASS_Base drb = new RANK_CLASS_Base();
            if (dr != null)
            {
                drb.RCID = dr.RCID;

                drb.Class_Type = dr.Class_Type;
                drb.RANKID = dr.RANKID;
                drb.CLASSID = dr.CLASSID;
                drb.RANK_MASTER = RANK_MASTERDL.generate_Base(dr.RANK_MASTER);

                drb.CLASS = CLASSDL.generate_Base(dr.CLASS);
            }
            return drb;
        }

        public static List<RANK_CLASS_Base> generate_Base(ICollection<RANK_CLASS> i)
        {
            List<RANK_CLASS_Base> drbl = new List<RANK_CLASS_Base>();
            int x = 0;
            foreach (RANK_CLASS dr in i)
            {
                RANK_CLASS_Base drb = new RANK_CLASS_Base();


                drb.RCID = dr.RCID;

                drb.Class_Type = dr.Class_Type;
                drb.RANKID = dr.RANKID;
                drb.CLASSID = dr.CLASSID;
                drb.RANK_MASTER = RANK_MASTERDL.generate_Base(dr.RANK_MASTER);

                drb.CLASS = CLASSDL.generate_Base(dr.CLASS);
                
           
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
