using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
    public class COMMENTDL : COreEI
    {
        public List<COMMENT_Base> getdata()
        {

            List<COMMENT> dr = db1.COMMENTs.ToList();
            List<COMMENT_Base> drb = generate_Base(dr);
            return drb;

        }

        public COMMENT_Base getdata(int id)
        {

            COMMENT dr = db1.COMMENTs.Where(q => q.COMMENTID == id).Single();
            COMMENT_Base STM = generate_Base(dr);
            return STM;


        }
        public List<COMMENT_Base> getdatabyEmpId(int id)
        {
            List<COMMENT_Base> STM = new List<COMMENT_Base>();
            var lst = db1.COMMENTs.Where(q => q.EMPID == id).ToList();
            if (lst.Count > 0)
            {
                List<COMMENT> dr = lst.ToList();
                STM = generate_Base(dr);
            }

            return STM;


        }
       

        public COMMENT_Base insertdata(COMMENT_Base dr)
        {
            int id = dr.COMMENTID;
            if (id != 0)
            {
                COMMENT result = db1.COMMENTs.Where(q => q.COMMENTID == id).Single();
                if (result != null)
                {
                    result.COMMENTID = dr.COMMENTID;
                    result.COMMENT1 = dr.COMMENT1;
                    result.COMMENTDATE = dr.COMMENTDATE;
                    result.RECEIVERUSERID = dr.RECEIVERUSERID;
                    result.SENDERUSERID = dr.SENDERUSERID;
                    result.EMPID = dr.EMPID;
                    result.PRIVATE = dr.PRIVATE;
                    result.PUBLIC = dr.PUBLIC;
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                COMMENT result = new COMMENT();
                result.COMMENT1 = dr.COMMENT1;
                result.COMMENTDATE = dr.COMMENTDATE;
                result.RECEIVERUSERID = dr.RECEIVERUSERID;
                result.SENDERUSERID = dr.SENDERUSERID;
                result.EMPID = dr.EMPID;
                result.PRIVATE = dr.PRIVATE;
                result.PUBLIC = dr.PUBLIC;
                db1.COMMENTs.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static COMMENT_Base generate_Base(COMMENT dr)
        {

            COMMENT_Base drb = new COMMENT_Base();
            drb.COMMENTID = dr.COMMENTID;
            drb.COMMENT1 = dr.COMMENT1;
            drb.COMMENTDATE = dr.COMMENTDATE;
            drb.RECEIVERUSERID = dr.RECEIVERUSERID;
            drb.SENDERUSERID = dr.SENDERUSERID;
            drb.EMPID = dr.EMPID;
            drb.PRIVATE = dr.PRIVATE;
            drb.PUBLIC = dr.PUBLIC;
            drb.EMP_FIXED = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED);
            drb.EMP_FIXED1 = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED1);
            drb.EMP_FIXED2 = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED2);
            return drb;
        }

        public static List<COMMENT_Base> generate_Base(ICollection<COMMENT> i)
        {
            List<COMMENT_Base> drbl = new List<COMMENT_Base>();
            int x = 0;
            foreach (COMMENT dr in i)
            {
                COMMENT_Base drb = new COMMENT_Base();
                drb.COMMENTID = dr.COMMENTID;
                drb.COMMENT1 = dr.COMMENT1;
                drb.COMMENTDATE = dr.COMMENTDATE;
                drb.RECEIVERUSERID = dr.RECEIVERUSERID;
                drb.SENDERUSERID = dr.SENDERUSERID;
                drb.EMPID = dr.EMPID;
                drb.EMPID = dr.EMPID;
                drb.PRIVATE = dr.PRIVATE;
                drb.EMP_FIXED = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED);
                drb.EMP_FIXED1 = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED1);
                drb.EMP_FIXED2 = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED2);
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
