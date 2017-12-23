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
    public class PAGE_MASTERDL : COreEI
    {
        public List<PAGE_MASTER_Base> getdata()
        {

            List<PAGE_MASTER> dr = db1.PAGE_MASTER.ToList();
            List<PAGE_MASTER_Base> drb = generate_Base(dr);
            return drb;

        }

        public PAGE_MASTER_Base getdata(int id)
        {

            PAGE_MASTER dr = db1.PAGE_MASTER.Where(q => q.PAGEID == id).Single();
            PAGE_MASTER_Base STM = generate_Base(dr);
            return STM;


        }

        //public PAGE_MASTER_Base insertdata(PAGE_MASTER_Base dr)
        //{
        //    int id = dr.PAGE_MASTERID;
        //    if (id != 0)
        //    {
        //        PAGE_MASTER result = db1.PAGE_MASTER.Where(q => q.PAGEID == id).Single();
        //        if (result != null)
        //        {
        //            result.PAGE_MASTERID = dr.PAGE_MASTERID;
        //            result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
        //            result.EMPL_CLASS = dr.EMPL_CLASS;
        //            result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
        //            result.AMOUNT_DPM_MPY_FLAG = dr.AMOUNT_DPM_MPY_FLAG;
        //            result.EARN_DEDN_RATE = dr.EARN_DEDN_RATE;
        //            result.ADD_BY = dr.ADD_BY;
        //            result.ADD_TIME = dr.ADD_TIME;
        //            result.EDIT_BY = dr.EDIT_BY;
        //            result.EDIT_TIME = dr.EDIT_TIME;
        //            result.xx = dr.xx;


        //            CommitChanges();
        //        }
        //        return generate_Base(result);
        //    }
        //    else
        //    {
        //        PAGE_MASTER result = new PAGE_MASTER();


        //        result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
        //        result.EMPL_CLASS = dr.EMPL_CLASS;
        //        result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
        //        result.AMOUNT_DPM_MPY_FLAG = dr.AMOUNT_DPM_MPY_FLAG;
        //        result.EARN_DEDN_RATE = dr.EARN_DEDN_RATE;
        //        result.ADD_BY = dr.ADD_BY;
        //        result.ADD_TIME = dr.ADD_TIME;
        //        result.EDIT_BY = dr.EDIT_BY;
        //        result.EDIT_TIME = dr.EDIT_TIME;
        //        result.xx = dr.xx;
        //        db1.PAGE_MASTER.Add(result);
        //        CommitChanges();
        //        return generate_Base(result);
        //    }
        //}

        public static PAGE_MASTER_Base generate_Base(PAGE_MASTER dr)
        {

            PAGE_MASTER_Base drb = Mapper.DynamicMap<PAGE_MASTER, PAGE_MASTER_Base>(dr);

            return drb;
        }

        public static List<PAGE_MASTER_Base> generate_Base(ICollection<PAGE_MASTER> i)
        {
            List<PAGE_MASTER_Base> drbl = Mapper.DynamicMap<ICollection<PAGE_MASTER>, List<PAGE_MASTER_Base>>(i);

            return drbl;
        }
    }
}
