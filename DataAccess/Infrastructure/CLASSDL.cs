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
   public class CLASSDL :COreEI
    {
        public List<CLASS_Base> getdata()
        {

            List<CLASS> dr = db1.CLASSes.ToList();
            List<CLASS_Base> drb = generate_Base(dr);
            return drb;

        }

        public ADDRESSEE_MASTER_Base getdataMap(int id)
        {

            ADDRESSEE_MASTER dr = db1.ADDRESSEE_MASTER.Where(q => q.ADDRESSID == id).Single();
            ADDRESSEE_MASTER_Base drb = Mapper.Map<ADDRESSEE_MASTER_Base>(dr);
            return drb;

        }

        public CLASS_Base getdata(int id)
        {

            CLASS dr = db1.CLASSes.Where(q => q.CLASSID == id).Single();
            CLASS_Base STM = generate_Base(dr);
            return STM;


        }

        public CLASS_Base insertdata(CLASS_Base dr)
        {
            int id = dr.CLASSID;
            if (id != 0)
            {
                CLASS result = db1.CLASSes.Where(q => q.CLASSID == id).Single();
                if (result != null)
                {
                    result.CLASSID = dr.CLASSID;
                    result.CLASS_NAME = dr.CLASS_NAME;                  
                    result.ACTIVE = dr.ACTIVE;
                    result.CLASS_TYPE = dr.CLASS_TYPE;
                    result.COST_TO_COMP = dr.COST_TO_COMP;
                 
                    

                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                CLASS result = new CLASS();
                
                result.CLASS_NAME = dr.CLASS_NAME;              
                result.ACTIVE = dr.ACTIVE;
                result.CLASS_TYPE = dr.CLASS_TYPE;
                result.COST_TO_COMP = dr.COST_TO_COMP;
                 
                
                db1.CLASSes.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static CLASS_Base generate_Base(CLASS dr)
        {
            CLASS_Base drb = Mapper.DynamicMap<CLASS, CLASS_Base>(dr);

            return drb;

            //CLASS_Base drb = new CLASS_Base();
            //if (dr != null)
            //{
            //    drb.CLASSID = dr.CLASSID;
            //    drb.CLASS_NAME = dr.CLASS_NAME;
               
            //    drb.ACTIVE = dr.ACTIVE;
               
                
            //}
            //return drb;
        }

        public static List<CLASS_Base> generate_Base(ICollection<CLASS> i)
        {

            List<CLASS_Base> drbl = Mapper.DynamicMap<ICollection<CLASS>, List<CLASS_Base>>(i);

            return drbl;

            //List<CLASS_Base> drbl = new List<CLASS_Base>();
            //int x = 0;
            //foreach (CLASS dr in i)
            //{
            //    CLASS_Base drb = new CLASS_Base();
            //    drb.CLASSID = dr.CLASSID;
            //    drb.CLASS_NAME = dr.CLASS_NAME;
                
            //    drb.ACTIVE = dr.ACTIVE;
              

            //    drbl.Add(drb);

            //    x++;
            //}
            //return drbl;
        }
    }
}
