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
   public class RULE3DL :COreEI
    {
        public List<RULE3_Base> getdata()
        {

            List<RULE3> dr = db1.RULE3.ToList();
            List<RULE3_Base> drb = generate_Base(dr);
            return drb;

        }

        public RULE3_Base getdata(int id)
        {

            RULE3 dr = db1.RULE3.Where(q => q.RULE3ID == id).Single();
            RULE3_Base STM = generate_Base(dr);
            return STM;


        }

        public RULE3_Base insertdata(RULE3_Base dr)
        {
            int id = dr.RULE3ID;
            if (id != 0)
            {
                RULE3 result = db1.RULE3.Where(q => q.RULE3ID == id).Single();
                if (result != null)
                {
                    result.RULE3ID = dr.RULE3ID;
                    result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
                    result.EMPL_CLASS = dr.EMPL_CLASS;
                    result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
                    result.SECONDARY_EARN_DEDN_CODE = dr.SECONDARY_EARN_DEDN_CODE;
                    result.EARN_DEDN_RATE = dr.EARN_DEDN_RATE;
                    result.ADD_BY = dr.ADD_BY;
                    result.ADD_TIME = dr.ADD_TIME;
                    result.EDIT_BY = dr.EDIT_BY;
                    result.EDIT_TIME = dr.EDIT_TIME;
                    result.RANK_CODE = dr.RANK_CODE;
                    result.FIXED_PRCNT_DPM_FLAG = dr.FIXED_PRCNT_DPM_FLAG;
                    result.s = dr.s;


                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                RULE3 result = new RULE3();

                result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
                result.EMPL_CLASS = dr.EMPL_CLASS;
                result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
                result.SECONDARY_EARN_DEDN_CODE = dr.SECONDARY_EARN_DEDN_CODE;
                result.EARN_DEDN_RATE = dr.EARN_DEDN_RATE;
                result.ADD_BY = dr.ADD_BY;
                result.ADD_TIME = dr.ADD_TIME;
                result.EDIT_BY = dr.EDIT_BY;
                result.EDIT_TIME = dr.EDIT_TIME;
                result.RANK_CODE = dr.RANK_CODE;
                result.FIXED_PRCNT_DPM_FLAG = dr.FIXED_PRCNT_DPM_FLAG;
                result.s = dr.s;

                db1.RULE3.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static RULE3_Base generate_Base(RULE3 dr)
        {

            RULE3_Base drb = Mapper.DynamicMap<RULE3, RULE3_Base>(dr);

            return drb;
        }

        public static List<RULE3_Base> generate_Base(ICollection<RULE3> i)
        {
            List<RULE3_Base> drbl = Mapper.DynamicMap<ICollection<RULE3>, List<RULE3_Base>>(i);

            return drbl;
        }
        
    }
}
