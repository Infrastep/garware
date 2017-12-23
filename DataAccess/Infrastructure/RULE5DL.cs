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
    public class RULE5DL :COreEI
    {
        public List<RULE5_Base> getdata()
        {

            List<RULE5> dr = db1.RULE5.ToList();
            List<RULE5_Base> drb = generate_Base(dr);
            return drb;

        }

        public RULE5_Base getdata(int id)
        {

            RULE5 dr = db1.RULE5.Where(q => q.RULE5ID == id).Single();
            RULE5_Base STM = generate_Base(dr);
            return STM;


        }

        public RULE5_Base insertdata(RULE5_Base dr)
        {
            int id = dr.RULE5ID;
            if (id != 0)
            {
                RULE5 result = db1.RULE5.Where(q => q.RULE5ID == id).Single();
                if (result != null)
                {
                    result.RULE5ID = dr.RULE5ID;
                    result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
                    result.EMPL_CLASS = dr.EMPL_CLASS;
                    result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
                    result.SHIP_CODE = dr.SHIP_CODE;
                    result.RANK_CODE = dr.RANK_CODE;
                    result.FIXED_PRCNT_DPM_FLAG = dr.FIXED_PRCNT_DPM_FLAG;
                    result.SECONDARY_EARN_DEDN_CODE = dr.SECONDARY_EARN_DEDN_CODE;
                    result.EARN_DEDN_RATE = dr.EARN_DEDN_RATE;
                    result.ADD_BY = dr.ADD_BY;
                    result.ADD_TIME = dr.ADD_TIME;
                    result.EDIT_BY = dr.EDIT_BY;
                    result.EDIT_TIME = dr.EDIT_TIME;
                    result.s = dr.s;


                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                RULE5 result = new RULE5();

                result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
                result.EMPL_CLASS = dr.EMPL_CLASS;
                result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
                result.SHIP_CODE = dr.SHIP_CODE;
                result.RANK_CODE = dr.RANK_CODE;
                result.FIXED_PRCNT_DPM_FLAG = dr.FIXED_PRCNT_DPM_FLAG;
                result.SECONDARY_EARN_DEDN_CODE = dr.SECONDARY_EARN_DEDN_CODE;
                result.EARN_DEDN_RATE = dr.EARN_DEDN_RATE;
                result.ADD_BY = dr.ADD_BY;
                result.ADD_TIME = dr.ADD_TIME;
                result.EDIT_BY = dr.EDIT_BY;
                result.EDIT_TIME = dr.EDIT_TIME;
                result.s = dr.s;

                db1.RULE5.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static RULE5_Base generate_Base(RULE5 dr)
        {

            RULE5_Base drb = Mapper.DynamicMap<RULE5, RULE5_Base>(dr);

            return drb;
        }

        public static List<RULE5_Base> generate_Base(ICollection<RULE5> i)
        {
            List<RULE5_Base> drbl = Mapper.DynamicMap<ICollection<RULE5>, List<RULE5_Base>>(i);

            return drbl;
        }
    }
}
