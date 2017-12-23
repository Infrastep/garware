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
   public class RULE1DL : COreEI
    {
        public List<RULE1_Base> getdata()
        {

            List<RULE1> dr = db1.RULE1.ToList();
            List<RULE1_Base> drb = generate_Base(dr);
            return drb;

        }

        public RULE1_Base getdata(int id)
        {

            RULE1 dr = db1.RULE1.Where(q => q.RULE1ID == id).Single();
            RULE1_Base STM = generate_Base(dr);
            return STM;


        }

        public RULE1_Base insertdata(RULE1_Base dr)
        {
            int id = dr.RULE1ID;
            if (id != 0)
            {
                RULE1 result = db1.RULE1.Where(q => q.RULE1ID == id).Single();
                if (result != null)
                {
                    result.RULE1ID = dr.RULE1ID;
                    result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
                    result.EMPL_CLASS = dr.EMPL_CLASS;
                    result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
                    result.AMOUNT_DPM_MPY_FLAG = dr.AMOUNT_DPM_MPY_FLAG;
                    result.EARN_DEDN_RATE = dr.EARN_DEDN_RATE;
                    result.ADD_BY = dr.ADD_BY;
                    result.ADD_TIME = dr.ADD_TIME;
                    result.EDIT_BY = dr.EDIT_BY;
                    result.EDIT_TIME = dr.EDIT_TIME;
                    result.xx = dr.xx;


                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                RULE1 result = new RULE1();


                result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
                result.EMPL_CLASS = dr.EMPL_CLASS;
                result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
                result.AMOUNT_DPM_MPY_FLAG = dr.AMOUNT_DPM_MPY_FLAG;
                result.EARN_DEDN_RATE = dr.EARN_DEDN_RATE;
                result.ADD_BY = dr.ADD_BY;
                result.ADD_TIME = dr.ADD_TIME;
                result.EDIT_BY = dr.EDIT_BY;
                result.EDIT_TIME = dr.EDIT_TIME;
                result.xx = dr.xx;
                db1.RULE1.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static RULE1_Base generate_Base(RULE1 dr)
        {

            RULE1_Base drb = Mapper.DynamicMap<RULE1, RULE1_Base>(dr);

            return drb;
        }

        public static List<RULE1_Base> generate_Base(ICollection<RULE1> i)
        {
            List<RULE1_Base> drbl = Mapper.DynamicMap<ICollection<RULE1>, List<RULE1_Base>>(i);

            return drbl;
        }
    }
}
