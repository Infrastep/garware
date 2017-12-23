using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
  public  class CLIENT_COMMENTDL : COreEI
    {
        public List<CLIENT_COMMENT_Base> getdata()
        {

            List<CLIENT_COMMENT> dr = db1.CLIENT_COMMENT.ToList();
            List<CLIENT_COMMENT_Base> drb = generate_Base(dr);
            return drb;

        }

        public CLIENT_COMMENT_Base getdata(int id)
        {

            CLIENT_COMMENT dr = db1.CLIENT_COMMENT.Where(q => q.COMMENTID == id).Single();
            CLIENT_COMMENT_Base STM = generate_Base(dr);
            return STM;


        }
        public List<CLIENT_COMMENT_Base> getdatabyEmpId(int id)
        {
            List<CLIENT_COMMENT_Base> STM = new List<CLIENT_COMMENT_Base>();
            var lst = db1.CLIENT_COMMENT.Where(q => q.EMPID == id).ToList();
            if (lst.Count > 0)
            {
                List<CLIENT_COMMENT> dr = lst.ToList();
                STM = generate_Base(dr);
            }

            return STM;


        }


        public CLIENT_COMMENT_Base insertdata(CLIENT_COMMENT_Base dr)
        {
            int id = dr.COMMENTID;
            if (id != 0)
            {
                CLIENT_COMMENT result = db1.CLIENT_COMMENT.Where(q => q.COMMENTID == id).Single();
                if (result != null)
                {
                    result.COMMENTID = dr.COMMENTID;
                    result.COMMENT = dr.COMMENT;
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
                CLIENT_COMMENT result = new CLIENT_COMMENT();
                result.COMMENT = dr.COMMENT;
                result.COMMENTDATE = dr.COMMENTDATE;
                result.RECEIVERUSERID = dr.RECEIVERUSERID;
                result.SENDERUSERID = dr.SENDERUSERID;
                result.EMPID = dr.EMPID;
                result.PRIVATE = dr.PRIVATE;
                result.PUBLIC = dr.PUBLIC;
                db1.CLIENT_COMMENT.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static CLIENT_COMMENT_Base generate_Base(CLIENT_COMMENT dr)
        {

            CLIENT_COMMENT_Base drb = new CLIENT_COMMENT_Base();
            drb.COMMENTID = dr.COMMENTID;
            drb.COMMENT = dr.COMMENT;
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

        public static List<CLIENT_COMMENT_Base> generate_Base(ICollection<CLIENT_COMMENT> i)
        {
            List<CLIENT_COMMENT_Base> drbl = new List<CLIENT_COMMENT_Base>();
            int x = 0;
            foreach (CLIENT_COMMENT dr in i)
            {
                CLIENT_COMMENT_Base drb = new CLIENT_COMMENT_Base();
                drb.COMMENTID = dr.COMMENTID;
                drb.COMMENT = dr.COMMENT;
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
