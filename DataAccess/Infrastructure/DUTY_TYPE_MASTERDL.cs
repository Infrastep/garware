using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
   public class DUTY_TYPE_MASTERDL :COreEI
    {
        public List<DUTY_TYPE_MASTER_Base> getdata()
        {

            List<DUTY_TYPE_MASTER> dr = db1.DUTY_TYPE_MASTER.ToList();
            List<DUTY_TYPE_MASTER_Base> drb = generate_Base(dr);
            return drb;

        }

        public DUTY_TYPE_MASTER_Base getdata(int id)
        {

            DUTY_TYPE_MASTER dr = db1.DUTY_TYPE_MASTER.Where(q => q.ID == id).Single();
            DUTY_TYPE_MASTER_Base STM = generate_Base(dr);
            return STM;


        }

        public DUTY_TYPE_MASTER_Base insertdata(DUTY_TYPE_MASTER_Base dr)
        {
            int id = dr.ID;
            if (id != 0)
            {
                DUTY_TYPE_MASTER result = db1.DUTY_TYPE_MASTER.Where(q => q.ID == id).Single();
                if (result != null)
                {
                    result.ID = dr.ID;
                    result.CODE = dr.CODE;
                    result.DESCRIPTION = dr.DESCRIPTION;
                    result.CATEGORY = dr.CATEGORY;
                    result.ACTIVE = dr.ACTIVE;
                    result.EMP_TYPE = dr.EMP_TYPE;
                    
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                DUTY_TYPE_MASTER result = new DUTY_TYPE_MASTER();
                
                result.CODE = dr.CODE;
                result.DESCRIPTION = dr.DESCRIPTION;
                result.CATEGORY = dr.CATEGORY;
                result.ACTIVE = dr.ACTIVE;
                result.EMP_TYPE = dr.EMP_TYPE;
                db1.DUTY_TYPE_MASTER.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static DUTY_TYPE_MASTER_Base generate_Base(DUTY_TYPE_MASTER dr)
        {

            DUTY_TYPE_MASTER_Base drb = new DUTY_TYPE_MASTER_Base();
            drb.ID = dr.ID;
            drb.CODE = dr.CODE;
            drb.DESCRIPTION = dr.DESCRIPTION;
            drb.CATEGORY = dr.CATEGORY;
            drb.ACTIVE = dr.ACTIVE;
            drb.EMP_TYPE = dr.EMP_TYPE;
            drb.CATEGORY1 = CATEGORYDL.generate_Base(dr.CATEGORY1);
            return drb;
        }

        public static List<DUTY_TYPE_MASTER_Base> generate_Base(ICollection<DUTY_TYPE_MASTER> i)
        {
            List<DUTY_TYPE_MASTER_Base> drbl = new List<DUTY_TYPE_MASTER_Base>();
            int x = 0;
            foreach (DUTY_TYPE_MASTER dr in i)
            {
                DUTY_TYPE_MASTER_Base drb = new DUTY_TYPE_MASTER_Base();
                drb.ID = dr.ID;
                drb.CODE = dr.CODE;
                drb.DESCRIPTION = dr.DESCRIPTION;
                drb.CATEGORY = dr.CATEGORY;
                drb.ACTIVE = dr.ACTIVE;
                drb.EMP_TYPE = dr.EMP_TYPE;
                drb.CATEGORY1 = CATEGORYDL.generate_Base(dr.CATEGORY1);
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
