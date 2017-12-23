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
   public class AREA_OPERATION_MASTERDL :COreEI
    {
        public List<AREA_OPERATION_MASTER_Base> getdata()
        {

            List<AREA_OPERATION_MASTER> dr = db1.AREA_OPERATION_MASTER.ToList();
            List<AREA_OPERATION_MASTER_Base> drb = generate_Base(dr);
            return drb;

        }

        public AREA_OPERATION_MASTER_Base getdata(int id)
        {

            AREA_OPERATION_MASTER dr = db1.AREA_OPERATION_MASTER.Where(q => q.AREAID == id).Single();
            AREA_OPERATION_MASTER_Base STM = generate_Base(dr);
            return STM;


        }

        public AREA_OPERATION_MASTER_Base insertdata(AREA_OPERATION_MASTER_Base dr)
        {
            int id = dr.AREAID;
            if (id != 0)
            {
                AREA_OPERATION_MASTER result = db1.AREA_OPERATION_MASTER.Where(q => q.AREAID == id).Single();
                if (result != null)
                {
                    result.AREAID = dr.AREAID;
                    result.AREACODE = dr.AREACODE;
                    result.NAME = dr.NAME;
                    result.DESCRIPTION = dr.DESCRIPTION;
                    result.ISINDIA = dr.ISINDIA;



                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                AREA_OPERATION_MASTER result = new AREA_OPERATION_MASTER();

                result.AREACODE = dr.AREACODE;
                result.NAME = dr.NAME;
                result.DESCRIPTION = dr.DESCRIPTION;
                result.ISINDIA = dr.ISINDIA;

                db1.AREA_OPERATION_MASTER.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static AREA_OPERATION_MASTER_Base generate_Base(AREA_OPERATION_MASTER dr)
        {

            AREA_OPERATION_MASTER_Base drb = Mapper.DynamicMap<AREA_OPERATION_MASTER, AREA_OPERATION_MASTER_Base>(dr);
          
            return drb;
        }

        public static List<AREA_OPERATION_MASTER_Base> generate_Base(ICollection<AREA_OPERATION_MASTER> i)
        {
            List<AREA_OPERATION_MASTER_Base> drbl = Mapper.DynamicMap<ICollection<AREA_OPERATION_MASTER>, List<AREA_OPERATION_MASTER_Base>>(i);
            
            return drbl;
        }

    }
}
