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
   public class RULE6DL : COreEI
    {
        public List<RULE6_Base> getdata()
        {

            List<RULE6> dr = db1.RULE6.ToList();
            List<RULE6_Base> drb = generate_Base(dr);
            return drb;

        }

        public RULE6_Base getdata(int id)
        {

            RULE6 dr = db1.RULE6.Where(q => q.RULE6ID == id).Single();
            RULE6_Base STM = generate_Base(dr);
            return STM;


        }

        public RULE6_Base insertdata(RULE6_Base dr)
        {
            int id = dr.RULE6ID;
            if (id != 0)
            {
                RULE6 result = db1.RULE6.Where(q => q.RULE6ID == id).Single();
                if (result != null)
                {
                    result.RULE6ID = dr.RULE6ID;
                    result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
                    result.EMPL_CLASS = dr.EMPL_CLASS;
                    result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
                    result.CERT_CODE = dr.CERT_CODE;
                    result.RANK_CODE = dr.RANK_CODE;
                    result.FIXED_PRCNT_FLAG = dr.FIXED_PRCNT_FLAG;
                    result.SECONDARY_EARN_DEDN_CODE = dr.SECONDARY_EARN_DEDN_CODE;
                    result.EARN_DEDN_RATE = dr.EARN_DEDN_RATE;
                    result.ADD_BY = dr.ADD_BY;
                    result.ADD_TIME = dr.ADD_TIME;
                    result.EDIT_BY = dr.EDIT_BY;
                    result.EDIT_TIME = dr.EDIT_TIME;
                    

                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                RULE6 result = new RULE6();

                result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
                result.EMPL_CLASS = dr.EMPL_CLASS;
                result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
                result.CERT_CODE = dr.CERT_CODE;
                result.RANK_CODE = dr.RANK_CODE;
                result.FIXED_PRCNT_FLAG = dr.FIXED_PRCNT_FLAG;
                result.SECONDARY_EARN_DEDN_CODE = dr.SECONDARY_EARN_DEDN_CODE;
                result.EARN_DEDN_RATE = dr.EARN_DEDN_RATE;
                result.ADD_BY = dr.ADD_BY;
                result.ADD_TIME = dr.ADD_TIME;
                result.EDIT_BY = dr.EDIT_BY;
                result.EDIT_TIME = dr.EDIT_TIME;
                    

                db1.RULE6.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static RULE6_Base generate_Base(RULE6 dr)
        {

            RULE6_Base drb = Mapper.DynamicMap<RULE6, RULE6_Base>(dr);

            return drb;
        }

        public static List<RULE6_Base> generate_Base(ICollection<RULE6> i)
        {
            List<RULE6_Base> drbl = Mapper.DynamicMap<ICollection<RULE6>, List<RULE6_Base>>(i);

            return drbl;
        }
    }
}
