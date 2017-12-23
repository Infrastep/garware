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
   public class RULE7DL :COreEI
    {
        public List<RULE7_Base> getdata()
        {

            List<RULE7> dr = db1.RULE7.ToList();
            List<RULE7_Base> drb = generate_Base(dr);
            return drb;

        }

        public RULE7_Base getdata(int id)
        {

            RULE7 dr = db1.RULE7.Where(q => q.RULE7ID == id).Single();
            RULE7_Base STM = generate_Base(dr);
            return STM;


        }

        public RULE7_Base insertdata(RULE7_Base dr)
        {
            int id = dr.RULE7ID;
            if (id != 0)
            {
                RULE7 result = db1.RULE7.Where(q => q.RULE7ID == id).Single();
                if (result != null)
                {
                    result.RULE7ID = dr.RULE7ID;
                    result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
                    result.EMPL_CLASS = dr.EMPL_CLASS;
                    result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
                    result.MIN_NO_OF_YRS = dr.MIN_NO_OF_YRS;
                    result.MAX_NO_OF_YRS = dr.MAX_NO_OF_YRS;
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
                RULE7 result = new RULE7();

                result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
                result.EMPL_CLASS = dr.EMPL_CLASS;
                result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
                result.MIN_NO_OF_YRS = dr.MIN_NO_OF_YRS;
                result.MAX_NO_OF_YRS = dr.MAX_NO_OF_YRS;
                result.EARN_DEDN_RATE = dr.EARN_DEDN_RATE;
                result.ADD_BY = dr.ADD_BY;
                result.ADD_TIME = dr.ADD_TIME;
                result.EDIT_BY = dr.EDIT_BY;
                result.EDIT_TIME = dr.EDIT_TIME;

                db1.RULE7.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static RULE7_Base generate_Base(RULE7 dr)
        {

            RULE7_Base drb = Mapper.DynamicMap<RULE7, RULE7_Base>(dr);

            return drb;
        }

        public static List<RULE7_Base> generate_Base(ICollection<RULE7> i)
        {
            List<RULE7_Base> drbl = Mapper.DynamicMap<ICollection<RULE7>, List<RULE7_Base>>(i);

            return drbl;
        }
    }
}
