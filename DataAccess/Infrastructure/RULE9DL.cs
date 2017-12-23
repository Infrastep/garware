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
   public class RULE9DL :COreEI
    {
        public List<RULE9_Base> getdata()
        {

            List<RULE9> dr = db1.RULE9.ToList();
            List<RULE9_Base> drb = generate_Base(dr);
            return drb;

        }

        public RULE9_Base getdata(int id)
        {

            RULE9 dr = db1.RULE9.Where(q => q.RULE9ID == id).Single();
            RULE9_Base STM = generate_Base(dr);
            return STM;


        }

        public RULE9_Base insertdata(RULE9_Base dr)
        {
            int id = dr.RULE9ID;
            if (id != 0)
            {
                RULE9 result = db1.RULE9.Where(q => q.RULE9ID == id).Single();
                if (result != null)
                {
                    result.RULE9ID = dr.RULE9ID;
                    result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
                    result.EMPL_CLASS = dr.EMPL_CLASS;
                    result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
                    result.MIN_NO_OF_DAYS = dr.MIN_NO_OF_DAYS;
                    result.MAX_NO_OF_DAYS = dr.MAX_NO_OF_DAYS;
                    result.SECONDARY_EARN_DEDN_CODE = dr.SECONDARY_EARN_DEDN_CODE;
                    result.EARN_PRCNT = dr.EARN_PRCNT;
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
                RULE9 result = new RULE9();

                result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
                result.EMPL_CLASS = dr.EMPL_CLASS;
                result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
                result.MIN_NO_OF_DAYS = dr.MIN_NO_OF_DAYS;
                result.MAX_NO_OF_DAYS = dr.MAX_NO_OF_DAYS;
                result.SECONDARY_EARN_DEDN_CODE = dr.SECONDARY_EARN_DEDN_CODE;
                result.EARN_PRCNT = dr.EARN_PRCNT;
                result.ADD_BY = dr.ADD_BY;
                result.ADD_TIME = dr.ADD_TIME;
                result.EDIT_BY = dr.EDIT_BY;
                result.EDIT_TIME = dr.EDIT_TIME;

                db1.RULE9.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static RULE9_Base generate_Base(RULE9 dr)
        {

            RULE9_Base drb = Mapper.DynamicMap<RULE9, RULE9_Base>(dr);

            return drb;
        }

        public static List<RULE9_Base> generate_Base(ICollection<RULE9> i)
        {
            List<RULE9_Base> drbl = Mapper.DynamicMap<ICollection<RULE9>, List<RULE9_Base>>(i);

            return drbl;
        }
    }
}
