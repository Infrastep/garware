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
   public class MARITIME_HOLIDAYDL :COreEI
    {
        public List<MARITIME_HOLIDAY_Base> getdata()
        {

            List<MARITIME_HOLIDAY> dr = db1.MARITIME_HOLIDAY.ToList();
            List<MARITIME_HOLIDAY_Base> drb = generate_Base(dr);
            return drb;

        }

        public MARITIME_HOLIDAY_Base getdata(int id)
        {

            MARITIME_HOLIDAY dr = db1.MARITIME_HOLIDAY.Where(q => q.MID  == id).Single();
            MARITIME_HOLIDAY_Base STM = generate_Base(dr);
            return STM;


        }

        public MARITIME_HOLIDAY_Base insertdata(MARITIME_HOLIDAY_Base dr)
        {
            int id = dr.MID ;
            if (id != 0)
            {
                MARITIME_HOLIDAY result = db1.MARITIME_HOLIDAY.Where(q => q.MID  == id).Single();
                if (result != null)
                {
                    result.MID = dr.MID ;
                    result.DAY = dr.DAY;
                    result.MONTH = dr.MONTH;


                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                MARITIME_HOLIDAY result = new MARITIME_HOLIDAY();

                result.DAY = dr.DAY;
                result.MONTH = dr.MONTH;

                db1.MARITIME_HOLIDAY.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static MARITIME_HOLIDAY_Base generate_Base(MARITIME_HOLIDAY dr)
        {

            MARITIME_HOLIDAY_Base drb = Mapper.DynamicMap<MARITIME_HOLIDAY, MARITIME_HOLIDAY_Base>(dr);
          
            return drb;
        }

        public static List<MARITIME_HOLIDAY_Base> generate_Base(ICollection<MARITIME_HOLIDAY> i)
        {
            List<MARITIME_HOLIDAY_Base> drbl = Mapper.DynamicMap<ICollection<MARITIME_HOLIDAY>, List<MARITIME_HOLIDAY_Base>>(i);
            
            return drbl;
        }

    }
}
