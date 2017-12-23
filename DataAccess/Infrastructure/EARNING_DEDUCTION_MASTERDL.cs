using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
using AutoMapper;
namespace DataAccess.Infrastructure
{
    public class EARNING_DEDUCTION_MASTERDL : COreEI
    {
        public List<EARNING_DEDUCTION_MASTER_Base> getdata()
        {

            List<EARNING_DEDUCTION_MASTER> dr = db1.EARNING_DEDUCTION_MASTER.ToList();
            List<EARNING_DEDUCTION_MASTER_Base> drb = generate_Base(dr);
            return drb;

        }

        public EARNING_DEDUCTION_MASTER_Base getdata(int id)
        {

            EARNING_DEDUCTION_MASTER dr = db1.EARNING_DEDUCTION_MASTER.Where(q => q.EARNDEDNID == id).Single();
            EARNING_DEDUCTION_MASTER_Base STM = generate_Base(dr);
            return STM;


        }

        public EARNING_DEDUCTION_MASTER_Base insertdata(EARNING_DEDUCTION_MASTER_Base dr)
        {
            int id = dr.EARNDEDNID;
            if (id != 0)
            {
                EARNING_DEDUCTION_MASTER result = db1.EARNING_DEDUCTION_MASTER.Where(q => q.EARNDEDNID == id).Single();
                if (result != null)
                {
                    result.EARNDEDNID = dr.EARNDEDNID;
                    result.CODE = dr.CODE;
                    result.DESCRIPTION = dr.DESCRIPTION;
                    

                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                EARNING_DEDUCTION_MASTER result = new EARNING_DEDUCTION_MASTER();

                result.CODE = dr.CODE;
                result.DESCRIPTION = dr.DESCRIPTION;

                db1.EARNING_DEDUCTION_MASTER.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static EARNING_DEDUCTION_MASTER_Base generate_Base(EARNING_DEDUCTION_MASTER dr)
        {

            EARNING_DEDUCTION_MASTER_Base drb = Mapper.DynamicMap<EARNING_DEDUCTION_MASTER, EARNING_DEDUCTION_MASTER_Base>(dr);

            return drb;
        }

        public static List<EARNING_DEDUCTION_MASTER_Base> generate_Base(ICollection<EARNING_DEDUCTION_MASTER> i)
        {
            List<EARNING_DEDUCTION_MASTER_Base> drbl = Mapper.DynamicMap<ICollection<EARNING_DEDUCTION_MASTER>, List<EARNING_DEDUCTION_MASTER_Base>>(i);

            return drbl;
        }
    }
}
