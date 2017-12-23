
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
    public class WITHHELD_REFUNDDL : COreEI
   {
       public List<WITHHELD_REFUND_Base> getdata()
       {

           List<WITHHELD_REFUND> dr = db1.WITHHELD_REFUND.ToList();
           List<WITHHELD_REFUND_Base> drb = generate_Base(dr);
           return drb;

       }

       public WITHHELD_REFUND_Base getdata(int id)
       {

           WITHHELD_REFUND dr = db1.WITHHELD_REFUND.Where(q => q.ID == id).Single();
           WITHHELD_REFUND_Base STM = generate_Base(dr);
           return STM;


       }

       public WITHHELD_REFUND_Base insertdata(WITHHELD_REFUND_Base dr)
       {
           int id = dr.ID;
           if (id != 0)
           {
               WITHHELD_REFUND result = db1.WITHHELD_REFUND.Where(q => q.ID == id).Single();
               if (result != null)
               {
                   result.ID = dr.ID;
                   result.EMP_CODE = dr.EMP_CODE;
                   result.REMARKS = dr.REMARKS;
                   result.AMOUNT = dr.AMOUNT;
                   result.FINANCIAL_YEAR = dr.FINANCIAL_YEAR;
                   result.REF_PREFIX = dr.REF_PREFIX;
                   result.REF_NO = dr.REF_NO;
                   result.REF_DATE = dr.REF_DATE;
                  

                   CommitChanges();
               }
               return generate_Base(result);
           }
           else
           {
               WITHHELD_REFUND result = new WITHHELD_REFUND();


               result.EMP_CODE = dr.EMP_CODE;
               result.REMARKS = dr.REMARKS;
               result.AMOUNT = dr.AMOUNT;
               result.FINANCIAL_YEAR = dr.FINANCIAL_YEAR;
               result.REF_PREFIX = dr.REF_PREFIX;
               result.REF_NO = dr.REF_NO;
               result.REF_DATE = dr.REF_DATE;
               db1.WITHHELD_REFUND.Add(result);
               CommitChanges();
               return generate_Base(result);
           }
       }

       public static WITHHELD_REFUND_Base generate_Base(WITHHELD_REFUND dr)
       {

           WITHHELD_REFUND_Base drb = Mapper.DynamicMap<WITHHELD_REFUND, WITHHELD_REFUND_Base>(dr);

           return drb;
       }

       public static List<WITHHELD_REFUND_Base> generate_Base(ICollection<WITHHELD_REFUND> i)
       {
           List<WITHHELD_REFUND_Base> drbl = Mapper.DynamicMap<ICollection<WITHHELD_REFUND>, List<WITHHELD_REFUND_Base>>(i);

           return drbl;
       }
    }
}
