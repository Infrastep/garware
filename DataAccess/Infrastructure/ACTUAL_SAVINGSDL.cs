using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
using AutoMapper;
using BaseClass.VM.ActualSavings;
namespace DataAccess.Infrastructure
{
   public class ACTUAL_SAVINGSDL :  COreEI
    {
        public List<ACTUAL_SAVINGS_Base_ACS> getdata()
        {

            List<ACTUAL_SAVINGS> dr = db1.ACTUAL_SAVINGS.ToList();
            List<ACTUAL_SAVINGS_Base_ACS> drb = generate_Base(dr);
            return drb;

        }

        public ACTUAL_SAVINGS_Base_ACS getdata(int id)
        {

            ACTUAL_SAVINGS dr = db1.ACTUAL_SAVINGS.Where(q => q.ACTUAL_SAVINGS_ID == id).Single();
            ACTUAL_SAVINGS_Base_ACS STM = generate_Base(dr);
            return STM;


        }

        public ACTUAL_SAVINGS_Base_ACS insertdata(ACTUAL_SAVINGS_Base_ACS dr)
        {
            int id = dr.ACTUAL_SAVINGS_ID;
            if (id != 0)
            {
                ACTUAL_SAVINGS result = db1.ACTUAL_SAVINGS.Where(q => q.ACTUAL_SAVINGS_ID == id).Single();
                if (result != null)
                {
                    result.ACTUAL_SAVINGS_ID = dr.ACTUAL_SAVINGS_ID;
                    result.EMP_CODE = dr.EMP_CODE;
                    result.TYPE = dr.TYPE;
                    result.AMOUNT = dr.AMOUNT;
                    result.FINANCIAL_YEAR = dr.FINANCIAL_YEAR;
                    result.CERTIFICATE_NO = dr.CERTIFICATE_NO;
                    result.SAVINGS_DATE = dr.SAVINGS_DATE;
                    result.NO_MONTHS = dr.NO_MONTHS;

                    result.AUTH_BY = dr.AUTH_BY;
                    result.AUTH_COMPUTER = dr.AUTH_COMPUTER;
                    result.AUTH_TIME = dr.AUTH_TIME;
                    result.AUTH_DATE = dr.AUTH_DATE;
                    result.AGREEMENT_CODE = dr.AGREEMENT_CODE;
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                ACTUAL_SAVINGS result = new ACTUAL_SAVINGS();
                result.EMP_CODE = dr.EMP_CODE;
                result.TYPE = dr.TYPE;
                result.AMOUNT = dr.AMOUNT;
                result.FINANCIAL_YEAR = dr.FINANCIAL_YEAR;
                result.CERTIFICATE_NO = dr.CERTIFICATE_NO;
                result.SAVINGS_DATE = dr.SAVINGS_DATE;
                result.NO_MONTHS = dr.NO_MONTHS;

                result.AUTH_BY = dr.AUTH_BY;
                result.AUTH_COMPUTER = dr.AUTH_COMPUTER;
                result.AUTH_TIME = dr.AUTH_TIME;
                result.AUTH_DATE = dr.AUTH_DATE;
                result.AGREEMENT_CODE = dr.AGREEMENT_CODE;
                db1.ACTUAL_SAVINGS.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static ACTUAL_SAVINGS_Base_ACS generate_Base(ACTUAL_SAVINGS dr)
        {

            ACTUAL_SAVINGS_Base_ACS drb = Mapper.DynamicMap<ACTUAL_SAVINGS, ACTUAL_SAVINGS_Base_ACS>(dr);

            return drb;
        }

        public static List<ACTUAL_SAVINGS_Base_ACS> generate_Base(ICollection<ACTUAL_SAVINGS> i)
        {
            List<ACTUAL_SAVINGS_Base_ACS> drbl = Mapper.DynamicMap<ICollection<ACTUAL_SAVINGS>, List<ACTUAL_SAVINGS_Base_ACS>>(i);

            return drbl;
        }
    }
}
