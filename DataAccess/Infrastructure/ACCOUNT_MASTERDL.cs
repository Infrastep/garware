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
    public class ACCOUNT_MASTERDL : COreEI
    {
        public List<ACCOUNT_MASTER_Base> getdata()
        {

            List<ACCOUNT_MASTER> dr = db1.ACCOUNT_MASTER.ToList();
            List<ACCOUNT_MASTER_Base> drb = generate_Base(dr);
            return drb;

        }

        public ACCOUNT_MASTER_Base getdata(int id)
        {

            ACCOUNT_MASTER dr = db1.ACCOUNT_MASTER.Where(q => q.Id == id).Single();
            ACCOUNT_MASTER_Base STM = generate_Base(dr);
            return STM;


        }

        public ACCOUNT_MASTER_Base insertdata(ACCOUNT_MASTER_Base dr)
        {
            int id = dr.Id;
            if (id != 0)
            {
                ACCOUNT_MASTER result = db1.ACCOUNT_MASTER.Where(q => q.Id == id).Single();
                if (result != null)
                {
                    result.Code = dr.Code;
                    result.Description = dr.Description;
                    
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                ACCOUNT_MASTER result = new ACCOUNT_MASTER();

                result.Id = dr.Id;
                result.Code = dr.Code;
                result.Description = dr.Description;

                db1.ACCOUNT_MASTER.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static ACCOUNT_MASTER_Base generate_Base(ACCOUNT_MASTER dr)
        {

            ACCOUNT_MASTER_Base drb = Mapper.DynamicMap<ACCOUNT_MASTER, ACCOUNT_MASTER_Base>(dr);
          
            return drb;
        }

        public static List<ACCOUNT_MASTER_Base> generate_Base(ICollection<ACCOUNT_MASTER> i)
        {
            List<ACCOUNT_MASTER_Base> drbl = Mapper.DynamicMap<ICollection<ACCOUNT_MASTER>, List<ACCOUNT_MASTER_Base>>(i);
            
            return drbl;
        }

    }
}
