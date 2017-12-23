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
   public class GRATUITY_REMITDL :COreEI
    {
        public List<GRATUITY_REMIT_Base> getdata()
        {

            List<GRATUITY_REMIT> dr = db1.GRATUITY_REMIT.ToList();
            List<GRATUITY_REMIT_Base> drb = generate_Base(dr);
            return drb;

        }

        public GRATUITY_REMIT_Base getdata(int id)
        {

            GRATUITY_REMIT dr = db1.GRATUITY_REMIT.Where(q => q.GRATUITY_REMITID == id).Single();
            GRATUITY_REMIT_Base STM = generate_Base(dr);
            return STM;


        }

        public GRATUITY_REMIT_Base insertdata(GRATUITY_REMIT_Base dr)
        {
            Int64 id = dr.GRATUITY_REMITID;
            if (id != 0)
            {
                GRATUITY_REMIT result = db1.GRATUITY_REMIT.Where(q => q.GRATUITY_REMITID == id).Single();
                if (result != null)
                {
                    result.GRATUITY_REMITID = dr.GRATUITY_REMITID;
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
                   
                    result.AUTH_SIGN = dr.AUTH_SIGN;
                    result.AUTH_DESIG = dr.AUTH_DESIG;
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                GRATUITY_REMIT result = new GRATUITY_REMIT();
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
                
                result.AUTH_SIGN = dr.AUTH_SIGN;
                result.AUTH_DESIG = dr.AUTH_DESIG;
                db1.GRATUITY_REMIT.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static GRATUITY_REMIT_Base generate_Base(GRATUITY_REMIT dr)
        {

            GRATUITY_REMIT_Base drb = Mapper.DynamicMap<GRATUITY_REMIT, GRATUITY_REMIT_Base>(dr);

            return drb;
        }

        public static List<GRATUITY_REMIT_Base> generate_Base(ICollection<GRATUITY_REMIT> i)
        {
            List<GRATUITY_REMIT_Base> drbl = Mapper.DynamicMap<ICollection<GRATUITY_REMIT>, List<GRATUITY_REMIT_Base>>(i);

            return drbl;
        }
    }
}
