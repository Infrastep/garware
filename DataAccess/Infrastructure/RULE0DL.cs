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
   public class RULE0DL : COreEI
    {
        public List<RULE0_Base> getdata()
        {

            List<RULE0> dr = db1.RULE0.ToList();
            List<RULE0_Base> drb = generate_Base(dr);
            return drb;

        }

        public RULE0_Base getdata(int id)
        {

            RULE0 dr = db1.RULE0.Where(q => q.RULE0ID == id).Single();
            RULE0_Base STM = generate_Base(dr);
            return STM;


        }

        public RULE0_Base insertdata(RULE0_Base dr)
        {
            int id = dr.RULE0ID;
            if (id != 0)
            {
                RULE0 result = db1.RULE0.Where(q => q.RULE0ID == id).Single();
                if (result != null)
                {
                    result.RULE0ID = dr.RULE0ID;
                    result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
                    result.EMPL_CLASS = dr.EMPL_CLASS;
                    result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
                    result.RANK_CODE = dr.RANK_CODE;

                    result.SHIP_CODE = dr.SHIP_CODE;
                    result.FROM_MONTH = dr.FROM_MONTH;
                    result.TO_MONTH = dr.TO_MONTH;
                    result.EARN_DEDN_RATE = dr.EARN_DEDN_RATE;
                    //result.ADD_BY = dr.ADD_BY;
                    //result.ADD_TIME = dr.ADD_TIME;
                    result.EDIT_BY = dr.EDIT_BY;
                    result.EDIT_TIME = dr.EDIT_TIME;



                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                RULE0 result = new RULE0();

                
                result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
                result.EMPL_CLASS = dr.EMPL_CLASS;
                result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
                result.RANK_CODE = dr.RANK_CODE;

                result.SHIP_CODE = dr.SHIP_CODE;
                result.FROM_MONTH = dr.FROM_MONTH;
                result.TO_MONTH = dr.TO_MONTH;
                result.EARN_DEDN_RATE = dr.EARN_DEDN_RATE;
                result.ADD_BY = dr.ADD_BY;
                result.ADD_TIME = dr.ADD_TIME;
                //result.EDIT_BY = dr.EDIT_BY;
                //result.EDIT_TIME = dr.EDIT_TIME;

                db1.RULE0.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static RULE0_Base generate_Base(RULE0 dr)
        {

            RULE0_Base drb = Mapper.DynamicMap<RULE0, RULE0_Base>(dr);

            return drb;
        }

        public static List<RULE0_Base> generate_Base(ICollection<RULE0> i)
        {
            List<RULE0_Base> drbl = Mapper.DynamicMap<ICollection<RULE0>, List<RULE0_Base>>(i);

            return drbl;
        }
    }
}
