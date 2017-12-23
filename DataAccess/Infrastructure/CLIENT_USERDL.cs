using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
  public  class CLIENT_USERDL:COreEI
    {

        public List<CLIENT_USER_Base> getdata()
        {

            List<CLIENT_USER> dr = db1.CLIENT_USER.ToList();
            List<CLIENT_USER_Base> drb = generate_Base(dr);
            return drb;

        }

        public CLIENT_USER_Base getdata(int id)
        {

            CLIENT_USER dr = db1.CLIENT_USER.Where(q => q.USERID == id).Single();
            CLIENT_USER_Base STM = generate_Base(dr);
            return STM;


        }

        public CLIENT_USER_Base insertdata(CLIENT_USER_Base dr)
        {
            int id = dr.CLIENTUSERID;
            if (id != 0)
            {
                CLIENT_USER result = db1.CLIENT_USER.Where(q => q.CLIENTID == id).Single();
                if (result != null)
                {
                    result.CLIENTUSERID = dr.CLIENTUSERID;
                    result.CLIENTID = dr.CLIENTID;
                    result.USERID = dr.USERID;
                   
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                CLIENT_USER result = new CLIENT_USER();

                result.CLIENTID = dr.CLIENTID;
                result.USERID = dr.USERID;

                db1.CLIENT_USER.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static CLIENT_USER_Base generate_Base(CLIENT_USER dr)
        {

            CLIENT_USER_Base drb = new CLIENT_USER_Base();
            if (dr != null)
            {
                drb.CLIENTID = dr.CLIENTID;
                drb.USERID = dr.USERID;
                drb.CLIENT_MASTER =CLIENT_MASTERDL.generate_Base( dr.CLIENT_MASTER);
                drb.EMP_FIXED = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED);
               
            }
            return drb;
        }

        public static List<CLIENT_USER_Base> generate_Base(ICollection<CLIENT_USER> i)
        {
            List<CLIENT_USER_Base> drbl = new List<CLIENT_USER_Base>();
            int x = 0;
            foreach (CLIENT_USER dr in i)
            {
                CLIENT_USER_Base drb = new CLIENT_USER_Base();
                drb.CLIENTID = dr.CLIENTID;
                drb.USERID = dr.USERID;
                drb.CLIENT_MASTER = CLIENT_MASTERDL.generate_Base(dr.CLIENT_MASTER);
                drb.EMP_FIXED = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED);
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
