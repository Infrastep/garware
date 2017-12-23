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
    public class RULE4DL:COreEI
    {
        public List<RULE4_Base> getdata()
        {

            List<RULE4> dr = db1.RULE4.ToList();
            List<RULE4_Base> drb = generate_Base(dr);
            return drb;

        }

        public RULE4_Base getdata(int id)
        {

            RULE4 dr = db1.RULE4.Where(q => q.RULE4ID == id).Single();
            RULE4_Base STM = generate_Base(dr);
            return STM;


        }

        public RULE4_Base insertdata(RULE4_Base dr)
        {
            int id = dr.RULE4ID;
            if (id != 0)
            {
                RULE4 result = db1.RULE4.Where(q => q.RULE4ID == id).Single();
                if (result != null)
                {
                    result.RULE4ID = dr.RULE4ID;
                    result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
                    result.EMPL_CLASS = dr.EMPL_CLASS;
                    result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
                    result.MIN_SECONDARY_EARN_AMT = dr.MIN_SECONDARY_EARN_AMT;
                    result.MAX_SECONDARY_EARN_AMT = dr.MAX_SECONDARY_EARN_AMT;
                    result.FIXED_PRCNT_OTRATE_FLAG = dr.FIXED_PRCNT_OTRATE_FLAG;
                    result.SECONDARY_EARN_DEDN_CODE = dr.SECONDARY_EARN_DEDN_CODE;
                    result.EARN_DEDN_RATE = dr.EARN_DEDN_RATE;
                    result.ADD_BY = dr.ADD_BY;
                    result.ADD_TIME = dr.ADD_TIME;
                    result.EDIT_BY = dr.EDIT_BY;
                    result.EDIT_TIME = dr.EDIT_TIME;
                    result.XX = dr.XX;


                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                RULE4 result = new RULE4();

                result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
                result.EMPL_CLASS = dr.EMPL_CLASS;
                result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
                result.MIN_SECONDARY_EARN_AMT = dr.MIN_SECONDARY_EARN_AMT;
                result.MAX_SECONDARY_EARN_AMT = dr.MAX_SECONDARY_EARN_AMT;
                result.FIXED_PRCNT_OTRATE_FLAG = dr.FIXED_PRCNT_OTRATE_FLAG;
                result.SECONDARY_EARN_DEDN_CODE = dr.SECONDARY_EARN_DEDN_CODE;
                result.EARN_DEDN_RATE = dr.EARN_DEDN_RATE;
                result.ADD_BY = dr.ADD_BY;
                result.ADD_TIME = dr.ADD_TIME;
                result.EDIT_BY = dr.EDIT_BY;
                result.EDIT_TIME = dr.EDIT_TIME;
                result.XX = dr.XX;

                db1.RULE4.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static RULE4_Base generate_Base(RULE4 dr)
        {

            RULE4_Base drb = Mapper.DynamicMap<RULE4, RULE4_Base>(dr);

            return drb;
        }

        public static List<RULE4_Base> generate_Base(ICollection<RULE4> i)
        {
            List<RULE4_Base> drbl = Mapper.DynamicMap<ICollection<RULE4>, List<RULE4_Base>>(i);

            return drbl;
        }
        
    }
}
