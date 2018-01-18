using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.EF;
using BaseClass;
using AutoMapper;
namespace DataAccess.Infrastructure
{
   public class CATEGORYDL : COreEI
    {
        /// <summery>
        /// get all data from Address
        ///  returns List<Address>
        /// </summery>
        public List<CATEGORY_Base> getdata()
        {

            List<CATEGORY> dr = db1.CATEGORies.ToList();
            List<CATEGORY_Base> drb = generate_Base(dr);
            return drb;

        }

        public CATEGORY_Base getdata(int id)
        {

            CATEGORY dr = db1.CATEGORies.Where(q => q.CATEGORY_ID == id).Single();
            CATEGORY_Base STM = generate_Base(dr);
            return STM;


        }

        public CATEGORY_Base insertdata(CATEGORY_Base dr)
        {
            int id = dr.CATEGORY_ID;
            if (id != 0)
            {
                CATEGORY result = db1.CATEGORies.Where(q => q.CATEGORY_ID == id).Single();
                if (result != null)
                {
                    result.CATEGORY_ID =dr.CATEGORY_ID;
                    result.CATEGORY_CODE = dr.CATEGORY_CODE;
                    result.CATEGORY_NAME = dr.CATEGORY_NAME;
                    result.STATUS = dr.STATUS;

                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                CATEGORY result = new CATEGORY();
               
                result.CATEGORY_CODE = dr.CATEGORY_CODE;
                result.CATEGORY_NAME = dr.CATEGORY_NAME;
                result.STATUS = dr.STATUS;
                db1.CATEGORies.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static CATEGORY_Base generate_Base(CATEGORY dr)
        {
            CATEGORY_Base drb = Mapper.DynamicMap<CATEGORY, CATEGORY_Base>(dr);

            return drb;

            
        }

        public static List<CATEGORY_Base> generate_Base(ICollection<CATEGORY> i)
        {
            List<CATEGORY_Base> drbl = Mapper.DynamicMap<ICollection<CATEGORY>, List<CATEGORY_Base>>(i);

            return drbl;

            //List<CATEGORY_Base> drbl = new List<CATEGORY_Base>();
            //int x = 0;
            //foreach (CATEGORY dr in i)
            //{
            //    CATEGORY_Base drb = new CATEGORY_Base();
            //    drb.CATEGORY_ID = dr.CATEGORY_ID;
            //    drb.CATEGORY_CODE = dr.CATEGORY_CODE;
            //    drb.CATEGORY_NAME = dr.CATEGORY_NAME;
            //    drb.STATUS = dr.STATUS;
            //    drbl.Add(drb);

            //    x++;
            //}
            //return drbl;
        }
    }
}
