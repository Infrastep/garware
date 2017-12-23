using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
    public class EMP_EXPERIENCEDL : COreEI
    {
        public List<EMP_EXPERIENCE_Base> getdata()
        {

            List<EMP_EXPERIENCE> dr = db1.EMP_EXPERIENCE.ToList();
            List<EMP_EXPERIENCE_Base> drb = generate_Base(dr);
            return drb;

        }

        public EMP_EXPERIENCE_Base getdata(int id)
        {

            EMP_EXPERIENCE dr = db1.EMP_EXPERIENCE.Where(q => q.EEID == id).Single();
            EMP_EXPERIENCE_Base STM = generate_Base(dr);
            return STM;


        }
        public List<EMP_EXPERIENCE_Base> getdataByEmpId(int id)
        {
            List<EMP_EXPERIENCE_Base> STM = new List<EMP_EXPERIENCE_Base>();
            var lst = db1.EMP_EXPERIENCE.Where(q => q.EMP_id == id).ToList();
            if (lst.Count > 0)
            {
                List<EMP_EXPERIENCE> dr = lst.ToList();
                STM = generate_Base(dr);
            }

            return STM;


        }

        public EMP_EXPERIENCE_Base insertdata(EMP_EXPERIENCE_Base dr)
        {
            int id = dr.EEID;
            if (id != 0)
            {
                EMP_EXPERIENCE result = db1.EMP_EXPERIENCE.Where(q => q.EEID == id).Single();
                if (result != null)
                {
                    result.EEID = dr.EEID;
                    result.EMP_id = dr.EMP_id;
                    result.Company_Served = dr.Company_Served;
                    result.Ship_name = dr.Ship_name;
                    result.Ship_Type = dr.Ship_Type;
                    result.DWT = dr.DWT;
                    result.BHP = dr.BHP;
                    result.Rank = dr.Rank;
                    result.Engine = dr.Engine;
                    result.Service_From = dr.Service_From;
                    result.Service_To = dr.Service_To;
                    result.Months = dr.Months;
                    result.Days = dr.Days;
                    result.DIRECT = dr.DIRECT;
                    result.Area_Sp_Job = dr.Area_Sp_Job;
                    result.Area_Operation = dr.Area_Operation;

                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                EMP_EXPERIENCE result = new EMP_EXPERIENCE();
                result.EMP_id = dr.EMP_id;
                result.Company_Served = dr.Company_Served;
                result.Ship_name = dr.Ship_name;
                result.Ship_Type = dr.Ship_Type;
                result.DWT = dr.DWT;
                result.Engine = dr.Engine;
                result.BHP = dr.BHP;
                result.Rank = dr.Rank;
                result.Service_From = dr.Service_From;
                result.Service_To = dr.Service_To;
                result.Months = dr.Months;
                result.Days = dr.Days;
                result.DIRECT = dr.DIRECT;
                result.Area_Sp_Job = dr.Area_Sp_Job;
                result.Area_Operation = dr.Area_Operation;

                db1.EMP_EXPERIENCE.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static EMP_EXPERIENCE_Base generate_Base(EMP_EXPERIENCE dr)
        {

            EMP_EXPERIENCE_Base drb = new EMP_EXPERIENCE_Base();
            drb.EEID = dr.EEID;
            drb.EMP_id = dr.EMP_id;
            drb.Company_Served = dr.Company_Served;
            drb.Ship_name = dr.Ship_name;
            drb.Ship_Type = dr.Ship_Type;
            drb.DWT = dr.DWT;
            drb.BHP = dr.BHP;
            drb.Rank = dr.Rank;
            drb.Engine = dr.Engine;
            drb.Service_From = dr.Service_From;
            drb.Service_To = dr.Service_To;
            drb.Months = dr.Months;
            drb.Days = dr.Days;
            drb.DIRECT = dr.DIRECT;
            drb.Area_Sp_Job = dr.Area_Sp_Job;
            drb.Area_Operation = dr.Area_Operation;
            drb.SHIP_TYPE_MASTER = SHIP_TYPE_MASTERDL.generate_Base(dr.SHIP_TYPE_MASTER);
            drb.EMP_FIXED = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED);
            return drb;
        }

        public static List<EMP_EXPERIENCE_Base> generate_Base(ICollection<EMP_EXPERIENCE> i)
        {
            List<EMP_EXPERIENCE_Base> drbl = new List<EMP_EXPERIENCE_Base>();
            int x = 0;
            foreach (EMP_EXPERIENCE dr in i)
            {
                EMP_EXPERIENCE_Base drb = new EMP_EXPERIENCE_Base();
                drb.EEID = dr.EEID;
                drb.EMP_id = dr.EMP_id;
                drb.Company_Served = dr.Company_Served;
                drb.Ship_name = dr.Ship_name;
                drb.Engine = dr.Engine;
                drb.Ship_Type = dr.Ship_Type;
                drb.DWT = dr.DWT;
                drb.BHP = dr.BHP;
                drb.Rank = dr.Rank;
                drb.Service_From = dr.Service_From;
                drb.Service_To = dr.Service_To;
                drb.Months = dr.Months;
                drb.Days = dr.Days;
                drb.DIRECT = dr.DIRECT;
                drb.Area_Sp_Job = dr.Area_Sp_Job;
                drb.Area_Operation = dr.Area_Operation;

                drb.SHIP_TYPE_MASTER = SHIP_TYPE_MASTERDL.generate_Base(dr.SHIP_TYPE_MASTER);
                drb.EMP_FIXED = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED);
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
