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
        public List<AEDCODE_Base> getdata()
        {

            List<AEDCODE> dr = db1.AEDCODEs.ToList();
            List<AEDCODE_Base> drb = generate_Base(dr);
            return drb;

        }

        public AEDCODE_Base getdata(int id)
        {

            AEDCODE dr = db1.AEDCODEs.Where(q => q.Id == id).Single();
            AEDCODE_Base STM = generate_Base(dr);
            return STM;


        }

        public AEDCODE_Base insertdata(AEDCODE_Base dr)
        {
            int id = dr.Id;
            if (id != 0)
            {
                AEDCODE result = db1.AEDCODEs.Where(q => q.Id  == id).Single();
                if (result != null)
                {
                    result.Id  = dr.Id ;
                    result.CODE = dr.CODE;
                    result.DESCR = dr.DESCR;
                    

                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                AEDCODE result = new AEDCODE();

                result.CODE = dr.CODE;
                result.DESCR = dr.DESCR;

                db1.AEDCODEs.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static AEDCODE_Base generate_Base(AEDCODE dr)
        {

            AEDCODE_Base drb = Mapper.DynamicMap<AEDCODE, AEDCODE_Base>(dr);

            return drb;
        }

        public static List<AEDCODE_Base> generate_Base(ICollection<AEDCODE> i)
        {
            List<AEDCODE_Base> drbl = Mapper.DynamicMap<ICollection<AEDCODE>, List<AEDCODE_Base>>(i);

            return drbl;
        }
    }
}
