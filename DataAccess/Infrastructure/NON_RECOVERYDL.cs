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
    public class NON_RECOVERYDL : COreEI
   {
       public List<NON_RECOVERY_Base> getdata()
       {

           List<NON_RECOVERY> dr = db1.NON_RECOVERY.ToList();
           List<NON_RECOVERY_Base> drb = generate_Base(dr);
           return drb;

       }

       public NON_RECOVERY_Base getdata(int id)
       {

           NON_RECOVERY dr = db1.NON_RECOVERY.Where(q => q.ID == id).Single();
           NON_RECOVERY_Base STM = generate_Base(dr);
           return STM;


       }

       public NON_RECOVERY_Base insertdata(NON_RECOVERY_Base dr)
       {
           int id = dr.ID;
           if (id != 0)
           {
               NON_RECOVERY result = db1.NON_RECOVERY.Where(q => q.ID == id).Single();
               if (result != null)
               {
                   result.ID = dr.ID;
                   result.EMP_CODE = dr.EMP_CODE;
                   result.REMARKS = dr.REMARKS;
                   result.AMOUNT = dr.AMOUNT;
                   result.INACTIVE_BY = dr.INACTIVE_BY;
                   result.INACTIVE_TIME = dr.INACTIVE_TIME;
                   result.INACTIVE_COMPUTER = dr.INACTIVE_COMPUTER;

                   CommitChanges();
               }
               return generate_Base(result);
           }
           else
           {
               NON_RECOVERY result = new NON_RECOVERY();


               result.EMP_CODE = dr.EMP_CODE;
               result.REMARKS = dr.REMARKS;
               result.AMOUNT = dr.AMOUNT;
               result.INACTIVE_BY = dr.INACTIVE_BY;
               result.INACTIVE_TIME = dr.INACTIVE_TIME;
               result.INACTIVE_COMPUTER = dr.INACTIVE_COMPUTER;
               db1.NON_RECOVERY.Add(result);
               CommitChanges();
               return generate_Base(result);
           }
       }

       public static NON_RECOVERY_Base generate_Base(NON_RECOVERY dr)
       {

           NON_RECOVERY_Base drb = Mapper.DynamicMap<NON_RECOVERY, NON_RECOVERY_Base>(dr);

           return drb;
       }

       public static List<NON_RECOVERY_Base> generate_Base(ICollection<NON_RECOVERY> i)
       {
           List<NON_RECOVERY_Base> drbl = Mapper.DynamicMap<ICollection<NON_RECOVERY>, List<NON_RECOVERY_Base>>(i);

           return drbl;
       }
    }
}
