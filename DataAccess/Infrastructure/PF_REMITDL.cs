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
   public class PF_REMITDL :COreEI
   {
       public List<PF_REMIT_Base> getdata()
       {

           List<PF_REMIT> dr = db1.PF_REMIT.ToList();
           List<PF_REMIT_Base> drb = generate_Base(dr);
           return drb;

       }

       public PF_REMIT_Base getdata(int id)
       {

           PF_REMIT dr = db1.PF_REMIT.Where(q => q.PF_REMIT_ID == id).Single();
           PF_REMIT_Base STM = generate_Base(dr);
           return STM;


       }

       public PF_REMIT_Base insertdata(PF_REMIT_Base dr)
       {
           Int64 id = dr.PF_REMIT_ID;
           if (id != 0)
           {
               PF_REMIT result = db1.PF_REMIT.Where(q => q.PF_REMIT_ID == id).Single();
               if (result != null)
               {
                   result.PF_REMIT_ID = dr.PF_REMIT_ID;
                   result.REF_NO = dr.REF_NO;
                   result.REF_DT = dr.REF_DT;
                   result.ADDR0 = dr.ADDR0;
                   result.ADDR1 = dr.ADDR1;
                   result.ADDR2 = dr.ADDR2;
                   result.ADDR3 = dr.ADDR3;
                   result.ADDR4 = dr.ADDR4;
                   result.REMIT_CHQ_NO = dr.REMIT_CHQ_NO;
                   result.REMIT_CHQ_DT = dr.REMIT_CHQ_DT;
                   result.REMIT_BANK = dr.REMIT_BANK;
                   result.REMIT_AMT = dr.REMIT_AMT;
                   result.ADMN_CHQ_NO = dr.ADMN_CHQ_NO;
                   result.ADMN_CHQ_DT = dr.ADMN_CHQ_DT;
                   result.ADMN_BANK = dr.ADMN_BANK;
                   result.ADMN_AMT = dr.ADMN_AMT;
                   result.AUTH_SIGN = dr.AUTH_SIGN;
                   result.AUTH_DESIG = dr.AUTH_DESIG;
                   CommitChanges();
               }
               return generate_Base(result);
           }
           else
           {
               PF_REMIT result = new PF_REMIT();
               result.REF_NO = dr.REF_NO;
               result.REF_DT = dr.REF_DT;
               result.ADDR0 = dr.ADDR0;
               result.ADDR1 = dr.ADDR1;
               result.ADDR2 = dr.ADDR2;
               result.ADDR3 = dr.ADDR3;
               result.ADDR4 = dr.ADDR4;
               result.REMIT_CHQ_NO = dr.REMIT_CHQ_NO;
               result.REMIT_CHQ_DT = dr.REMIT_CHQ_DT;
               result.REMIT_BANK = dr.REMIT_BANK;
               result.REMIT_AMT = dr.REMIT_AMT;
               result.ADMN_CHQ_NO = dr.ADMN_CHQ_NO;
               result.ADMN_CHQ_DT = dr.ADMN_CHQ_DT;
               result.ADMN_BANK = dr.ADMN_BANK;
               result.ADMN_AMT = dr.ADMN_AMT;
               result.AUTH_SIGN = dr.AUTH_SIGN;
               result.AUTH_DESIG = dr.AUTH_DESIG;
               db1.PF_REMIT.Add(result);
               CommitChanges();
               return generate_Base(result);
           }
       }

       public static PF_REMIT_Base generate_Base(PF_REMIT dr)
       {

           PF_REMIT_Base drb = Mapper.DynamicMap<PF_REMIT, PF_REMIT_Base>(dr);

           return drb;
       }

       public static List<PF_REMIT_Base> generate_Base(ICollection<PF_REMIT> i)
       {
           List<PF_REMIT_Base> drbl = Mapper.DynamicMap<ICollection<PF_REMIT>, List<PF_REMIT_Base>>(i);

           return drbl;
       }
    }
}
