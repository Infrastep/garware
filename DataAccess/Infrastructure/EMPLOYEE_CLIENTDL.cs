using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure 
{
   public class EMPLOYEE_CLIENTDL :COreEI
    {
        public List<EMPLOYEE_CLIENT_Base> getdata()
        {

            List<EMPLOYEE_CLIENT> dr = db1.EMPLOYEE_CLIENT.ToList();
            List<EMPLOYEE_CLIENT_Base> drb = generate_Base(dr);
            return drb;

        }

        public EMPLOYEE_CLIENT_Base getdata(int id)
        {

            EMPLOYEE_CLIENT dr = db1.EMPLOYEE_CLIENT.Where(q => q.EMPCLINTID == id).Single();
            EMPLOYEE_CLIENT_Base STM = generate_Base(dr);
            return STM;


        }
        public List<EMPLOYEE_CLIENT_Base> getdatabyClientId(int id)
        {

            List<EMPLOYEE_CLIENT> dr = db1.EMPLOYEE_CLIENT.Where(q => q.SHIP_MASTER.CLIENT_ID == id).ToList();
            List<EMPLOYEE_CLIENT_Base> STM = generate_Base(dr);
            return STM;


        }
        public List<EMPLOYEE_CLIENT_Base> getdatabyEmpID(int id)
        {

            List<EMPLOYEE_CLIENT> dr = db1.EMPLOYEE_CLIENT.Where(q => q.EMP_ID == id).ToList();
            List<EMPLOYEE_CLIENT_Base> STM = generate_Base(dr);
            return STM;


        }

        public int UpdateEMPStatus(int id, int status)
        { 
            int res = 0;
            var dr = db1.EMPLOYEE_CLIENT.Where(q => q.EMP_ID == id).ToList();
            if (dr.Count >0 )
            {
                dr[0].STATUS = status;
                CommitChanges();
                res = 1;
            }
            return res;
        }
        public EMPLOYEE_CLIENT_Base insertdata(EMPLOYEE_CLIENT_Base dr)
        {
            long id = dr.EMPCLINTID;
            if (id != 0)
            {
                EMPLOYEE_CLIENT result = db1.EMPLOYEE_CLIENT.Where(q => q.EMPCLINTID == id).Single();
                if (result != null)
                {
                    result.EMPCLINTID = dr.EMPCLINTID;
                    result.EMP_ID = dr.EMP_ID;
                    result.SHIP_ID = dr.SHIP_ID;
                    result.RANK_CLASS_ID = dr.RANK_CLASS_ID;
                    result.STARTDATE = dr.STARTDATE;
                    result.ENDDATE = dr.ENDDATE;
                    result.STATUS = dr.STATUS;
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                EMPLOYEE_CLIENT result = new EMPLOYEE_CLIENT();
              
                result.EMP_ID = dr.EMP_ID;
                result.SHIP_ID = dr.SHIP_ID;
                result.RANK_CLASS_ID = dr.RANK_CLASS_ID;
                result.STARTDATE = dr.STARTDATE;
                result.ENDDATE = dr.ENDDATE;
                result.STATUS = dr.STATUS;
                db1.EMPLOYEE_CLIENT.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static EMPLOYEE_CLIENT_Base generate_Base(EMPLOYEE_CLIENT dr)
        {

            EMPLOYEE_CLIENT_Base drb = new EMPLOYEE_CLIENT_Base();
            drb.EMPCLINTID = dr.EMPCLINTID;
            drb.EMP_ID = dr.EMP_ID;
            drb.SHIP_ID = dr.SHIP_ID;
            drb.RANK_CLASS_ID = dr.RANK_CLASS_ID;
            drb.STARTDATE = dr.STARTDATE;
            drb.ENDDATE = dr.ENDDATE;
            drb.STATUS = dr.STATUS;
          
            drb.EMP_FIXED = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED);
            drb.RANK_CLASS = RANK_CLASSDL.generate_Base(dr.RANK_CLASS);
            drb.SHIP_MASTER = SHIP_MASTERDL.generate_Base(dr.SHIP_MASTER);
            
            return drb;
        }

        public static List<EMPLOYEE_CLIENT_Base> generate_Base(ICollection<EMPLOYEE_CLIENT> i)
        {
            List<EMPLOYEE_CLIENT_Base> drbl = new List<EMPLOYEE_CLIENT_Base>();
            int x = 0;
            foreach (EMPLOYEE_CLIENT dr in i)
            {
                EMPLOYEE_CLIENT_Base drb = new EMPLOYEE_CLIENT_Base();
                drb.EMPCLINTID = dr.EMPCLINTID;
                drb.EMP_ID = dr.EMP_ID;
                drb.SHIP_ID = dr.SHIP_ID;
                drb.RANK_CLASS_ID = dr.RANK_CLASS_ID;
                drb.STARTDATE = dr.STARTDATE;
                drb.ENDDATE = dr.ENDDATE;
                drb.STATUS = dr.STATUS;
                drb.EMP_FIXED = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED);
                drb.RANK_CLASS = RANK_CLASSDL.generate_Base(dr.RANK_CLASS);
                drb.SHIP_MASTER = SHIP_MASTERDL.generate_Base(dr.SHIP_MASTER);

                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
