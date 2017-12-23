using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
using AutoMapper;
using BaseClass.VM.AgreementDetails;
namespace DataAccess.Infrastructure
{
   public class AGREEMENT_DETAILSDL:COreEI
    {
        public List<AGREEMENT_DETAILS_Base_AD> getdata()
        {

            List<AGREEMENT_DETAILS> dr = db1.AGREEMENT_DETAILS.ToList();
            List<AGREEMENT_DETAILS_Base_AD> drb = generate_Base(dr);
            return drb;

        }

        public AGREEMENT_DETAILS_Base_AD getdata(int id)
        {

            AGREEMENT_DETAILS dr = db1.AGREEMENT_DETAILS.Where(q => q.AGREEMENT_DETAILS_ID == id).Single();
            AGREEMENT_DETAILS_Base_AD STM = generate_Base(dr);
            return STM;


        }

        public AGREEMENT_DETAILS_Base_AD insertdata(AGREEMENT_DETAILS_Base_AD dr)
        {
            Int64 id = dr.AGREEMENT_DETAILS_ID;
            if (id != 0)
            {
                AGREEMENT_DETAILS result = db1.AGREEMENT_DETAILS.Where(q => q.AGREEMENT_DETAILS_ID == id).Single();
                if (result != null)
                {
                    //result.AGREEMENT_DETAILS_ID = dr.AGREEMENT_DETAILS_ID;
                    //result.EMP_CODE = dr.EMP_CODE;
                    //result.YR = dr.YR;
                    //result.MON = dr.MON;
                    //result.TRANS_AMT = dr.TRANS_AMT;
                    //result.AGREEMENT_CODE = dr.AGREEMENT_CODE;

                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                AGREEMENT_DETAILS result = new AGREEMENT_DETAILS();



                //result.EMP_CODE = dr.EMP_CODE;
                //result.YR = dr.YR;
                //result.MON = dr.MON;
                //result.TRANS_AMT = dr.TRANS_AMT;
                //result.AGREEMENT_CODE = dr.AGREEMENT_CODE;
                //db1.AGREEMENT_DETAILS.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static AGREEMENT_DETAILS_Base_AD generate_Base(AGREEMENT_DETAILS dr)
        {

            AGREEMENT_DETAILS_Base_AD drb = Mapper.DynamicMap<AGREEMENT_DETAILS, AGREEMENT_DETAILS_Base_AD>(dr);

            return drb;
        }

        public static List<AGREEMENT_DETAILS_Base_AD> generate_Base(ICollection<AGREEMENT_DETAILS> i)
        {
            List<AGREEMENT_DETAILS_Base_AD> drbl = Mapper.DynamicMap<ICollection<AGREEMENT_DETAILS>, List<AGREEMENT_DETAILS_Base_AD>>(i);

            return drbl;
        }
    }
}
