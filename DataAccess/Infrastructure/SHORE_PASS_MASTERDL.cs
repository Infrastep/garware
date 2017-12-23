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
   public class SHORE_PASS_MASTERDL :COreEI
    {
        public List<SHORE_PASS_MASTER_Base> getdata()
        {

            List<SHORE_PASS_MASTER> dr = db1.SHORE_PASS_MASTER.ToList();
            List<SHORE_PASS_MASTER_Base> drb = generate_Base(dr);
            return drb;

        }

        public SHORE_PASS_MASTER_Base getdata(int id)
        {

            SHORE_PASS_MASTER dr = db1.SHORE_PASS_MASTER.Where(q => q.SPID == id).Single();
            SHORE_PASS_MASTER_Base STM = generate_Base(dr);
            return STM;


        }

        public SHORE_PASS_MASTER_Base insertdata(SHORE_PASS_MASTER_Base dr)
        {
            int id = dr.SPID ;
            if (id != 0)
            {
                SHORE_PASS_MASTER result = db1.SHORE_PASS_MASTER.Where(q => q.SPID == id).Single();
                if (result != null)
                {
                    result.SPID = dr.SPID;
                    result.CODE = dr.CODE;
                    result.DESCRIPTION = dr.DESCRIPTION ;



                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                SHORE_PASS_MASTER result = new SHORE_PASS_MASTER();

                result.CODE = dr.CODE;
                result.DESCRIPTION = dr.DESCRIPTION;

                db1.SHORE_PASS_MASTER.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static SHORE_PASS_MASTER_Base generate_Base(SHORE_PASS_MASTER dr)
        {

            SHORE_PASS_MASTER_Base drb = Mapper.DynamicMap<SHORE_PASS_MASTER, SHORE_PASS_MASTER_Base>(dr);
          
            return drb;
        }

        public static List<SHORE_PASS_MASTER_Base> generate_Base(ICollection<SHORE_PASS_MASTER> i)
        {
            List<SHORE_PASS_MASTER_Base> drbl = Mapper.DynamicMap<ICollection<SHORE_PASS_MASTER>, List<SHORE_PASS_MASTER_Base>>(i);
            
            return drbl;
        }

    }
}
