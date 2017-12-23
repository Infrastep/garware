using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
   public class EMPLOYEE_STATUSDL :COreEI
    {
        public List<EMPLOYEE_STATUS_Base> getdata()
        {

            List<EMPLOYEE_STATUS> dr = db1.EMPLOYEE_STATUS.ToList();
            List<EMPLOYEE_STATUS_Base> drb = generate_Base(dr);
            return drb;

        }

        public EMPLOYEE_STATUS_Base getdata(int id)
        {

            EMPLOYEE_STATUS dr = db1.EMPLOYEE_STATUS.Where(q => q.EMPSTATID == id).Single();
            EMPLOYEE_STATUS_Base STM = generate_Base(dr);
            return STM;


        }

        public EMPLOYEE_STATUS_Base insertdata(EMPLOYEE_STATUS_Base dr)
        {
            long id = dr.EMPSTATID;
            if (id != 0)
            {
                EMPLOYEE_STATUS result = db1.EMPLOYEE_STATUS.Where(q => q.EMPSTATID == id).Single();
                if (result != null)
                {
                    result.EMPSTATID = dr.EMPSTATID;
                    result.EMP_ID = dr.EMP_ID;
                    result.STATUS_ID = dr.STATUS_ID;
                    result.UPDATE_DATE = dr.UPDATE_DATE;
                    result.UPDATE_PERSONEL = dr.UPDATE_PERSONEL;
                    result.ENTRY_DATE = dr.ENTRY_DATE;
                    result.REMARKS = dr.REMARKS;
                 
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                EMPLOYEE_STATUS result = new EMPLOYEE_STATUS();
                
                result.EMP_ID = dr.EMP_ID;
                result.STATUS_ID = dr.STATUS_ID;
                result.UPDATE_DATE = dr.UPDATE_DATE;
                result.UPDATE_PERSONEL = dr.UPDATE_PERSONEL;
                result.ENTRY_DATE = dr.ENTRY_DATE;
                result.REMARKS = dr.REMARKS;
               
                db1.EMPLOYEE_STATUS.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static EMPLOYEE_STATUS_Base generate_Base(EMPLOYEE_STATUS dr)
        {

            EMPLOYEE_STATUS_Base drb = new EMPLOYEE_STATUS_Base();
            drb.EMPSTATID = dr.EMPSTATID;
            drb.EMP_ID = dr.EMP_ID;
            drb.STATUS_ID = dr.STATUS_ID;
            drb.UPDATE_DATE = dr.UPDATE_DATE;
            drb.UPDATE_PERSONEL = dr.UPDATE_PERSONEL;
            drb.ENTRY_DATE = dr.ENTRY_DATE;
            drb.REMARKS = dr.REMARKS;
          
            drb.EMP_FIXED = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED);
            drb.EMP_FIXED1 = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED1);
            drb.SELECTION_STATUS_MASTER = SELECTION_STATUS_MASTERDL.generate_Base(dr.SELECTION_STATUS_MASTER);
            return drb;
        }

        public static List<EMPLOYEE_STATUS_Base> generate_Base(ICollection<EMPLOYEE_STATUS> i)
        {
            List<EMPLOYEE_STATUS_Base> drbl = new List<EMPLOYEE_STATUS_Base>();
            int x = 0;
            foreach (EMPLOYEE_STATUS dr in i)
            {
                EMPLOYEE_STATUS_Base drb = new EMPLOYEE_STATUS_Base();
                drb.EMPSTATID = dr.EMPSTATID;
                drb.EMP_ID = dr.EMP_ID;
                drb.STATUS_ID = dr.STATUS_ID;
                drb.UPDATE_DATE = dr.UPDATE_DATE;
                drb.UPDATE_PERSONEL = dr.UPDATE_PERSONEL;
                drb.ENTRY_DATE = dr.ENTRY_DATE;
                drb.REMARKS = dr.REMARKS;
                
                drb.EMP_FIXED = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED);
                drb.EMP_FIXED1 = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED1);
                drb.SELECTION_STATUS_MASTER = SELECTION_STATUS_MASTERDL.generate_Base(dr.SELECTION_STATUS_MASTER);

                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
