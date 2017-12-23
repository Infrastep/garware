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
   public class WITHHELD_TRANSFERDL:COreEI
   {
       public List<WITHHELD_TRANSFER_Base> getdata()
       {

           List<WITHHELD_TRANSFER> dr = db1.WITHHELD_TRANSFER.ToList();
           List<WITHHELD_TRANSFER_Base> drb = generate_Base(dr);
           return drb;

       }

       public WITHHELD_TRANSFER_Base getdata(int id)
       {

           WITHHELD_TRANSFER dr = db1.WITHHELD_TRANSFER.Where(q => q.WITHHELD_TRANSFER_ID == id).Single();
           WITHHELD_TRANSFER_Base STM = generate_Base(dr);
           return STM;


       }

       public WITHHELD_TRANSFER_Base insertdata(WITHHELD_TRANSFER_Base dr)
       {
           Int64 id = dr.WITHHELD_TRANSFER_ID;
           if (id != 0)
           {
               WITHHELD_TRANSFER result = db1.WITHHELD_TRANSFER.Where(q => q.WITHHELD_TRANSFER_ID == id).Single();
               if (result != null)
               {
                   result.WITHHELD_TRANSFER_ID = dr.WITHHELD_TRANSFER_ID;
                   result.EMP_CODE = dr.EMP_CODE;
                   result.YR = dr.YR;
                   result.MON = dr.MON;
                   result.TRANS_AMT = dr.TRANS_AMT;
                   result.AGREEMENT_CODE = dr.AGREEMENT_CODE;
                  
                   CommitChanges();
               }
               return generate_Base(result);
           }
           else
           {
               WITHHELD_TRANSFER result = new WITHHELD_TRANSFER();


               
               result.EMP_CODE = dr.EMP_CODE;
               result.YR = dr.YR;
               result.MON = dr.MON;
               result.TRANS_AMT = dr.TRANS_AMT;
               result.AGREEMENT_CODE = dr.AGREEMENT_CODE;
               db1.WITHHELD_TRANSFER.Add(result);
               CommitChanges();
               return generate_Base(result);
           }
       }

       public static WITHHELD_TRANSFER_Base generate_Base(WITHHELD_TRANSFER dr)
       {

           WITHHELD_TRANSFER_Base drb = Mapper.DynamicMap<WITHHELD_TRANSFER, WITHHELD_TRANSFER_Base>(dr);

           return drb;
       }

       public static List<WITHHELD_TRANSFER_Base> generate_Base(ICollection<WITHHELD_TRANSFER> i)
       {
           List<WITHHELD_TRANSFER_Base> drbl = Mapper.DynamicMap<ICollection<WITHHELD_TRANSFER>, List<WITHHELD_TRANSFER_Base>>(i);

           return drbl;
       }
    }
}
