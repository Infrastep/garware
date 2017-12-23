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
   public class RULE2DL :COreEI
    {
        public List<RULE2_Base> getdata()
        {

            List<RULE2> dr = db1.RULE2.ToList();
            List<RULE2_Base> drb = generate_Base(dr);
            return drb;

        }

        public RULE2_Base getdata(int id)
        {

            RULE2 dr = db1.RULE2.Where(q => q.RULE2ID == id).Single();
            RULE2_Base STM = generate_Base(dr);
            return STM;


        }

        public RULE2_Base insertdata(RULE2_Base dr)
        {
            int id = dr.RULE2ID;
            if (id != 0)
            {
                RULE2 result = db1.RULE2.Where(q => q.RULE2ID == id).Single();
                if (result != null)
                {
                    result.RULE2ID = dr.RULE2ID;
                    result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
                    result.EMPL_CLASS = dr.EMPL_CLASS;
                    result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
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
                RULE2 result = new RULE2();

                result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
                result.EMPL_CLASS = dr.EMPL_CLASS;
                result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
                result.SECONDARY_EARN_DEDN_CODE = dr.SECONDARY_EARN_DEDN_CODE;
                result.EARN_DEDN_RATE = dr.EARN_DEDN_RATE;
                result.ADD_BY = dr.ADD_BY;
                result.ADD_TIME = dr.ADD_TIME;
                result.EDIT_BY = dr.EDIT_BY;
                result.EDIT_TIME = dr.EDIT_TIME;
                result.XX = dr.XX;

                db1.RULE2.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static RULE2_Base generate_Base(RULE2 dr)
        {

            RULE2_Base drb = Mapper.DynamicMap<RULE2, RULE2_Base>(dr);

            return drb;
        }

        public static List<RULE2_Base> generate_Base(ICollection<RULE2> i)
        {
            List<RULE2_Base> drbl = Mapper.DynamicMap<ICollection<RULE2>, List<RULE2_Base>>(i);

            return drbl;
        }
    }
}
