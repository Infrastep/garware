using AutoMapper;
using BaseClass;
using DataAccess.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Infrastructure
{
   public class MISC_TAXABLE_INCOMEDL :COreEI
    {
        public List<MISC_TAXABLE_INCOME_Base> getdata()
        {

            List<MISC_TAXABLE_INCOME> dr = db1.MISC_TAXABLE_INCOME.ToList();
            List<MISC_TAXABLE_INCOME_Base> drb = generate_Base(dr);
            return drb;

        }

        public MISC_TAXABLE_INCOME_Base getdata(int id)
        {

            MISC_TAXABLE_INCOME dr = db1.MISC_TAXABLE_INCOME.Where(q => q.MISC_TAXABLE_INCOME_ID == id).Single();
            MISC_TAXABLE_INCOME_Base STM = generate_Base(dr);
            return STM;


        }

        public MISC_TAXABLE_INCOME_Base insertdata(MISC_TAXABLE_INCOME_Base dr)
        {
            Int64 id = dr.MISC_TAXABLE_INCOME_ID;
            if (id != 0)
            {
                MISC_TAXABLE_INCOME result = db1.MISC_TAXABLE_INCOME.Where(q => q.MISC_TAXABLE_INCOME_ID == id).Single();
                if (result != null)
                {
                    result.MISC_TAXABLE_INCOME_ID = dr.MISC_TAXABLE_INCOME_ID;
                    result.EMP_CODE = dr.EMP_CODE;
                    result.FINANCIAL_YEAR = dr.FINANCIAL_YEAR;
                    result.NARRATION = dr.NARRATION;
                    result.AMOUNT = dr.AMOUNT;
                    result.INCOME_CODE = dr.INCOME_CODE;
                    result.ENTRY_DATE = dr.ENTRY_DATE;
                    result.UTILISED = dr.UTILISED;
                    result.TAX_AMT_DED = dr.TAX_AMT_DED;
                    result.TAX_DED = dr.TAX_DED;
                    result.SCHG_DED = dr.SCHG_DED;
                    result.CESS_DED = dr.CESS_DED;
                    result.HCESS_DED = dr.HCESS_DED;
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                MISC_TAXABLE_INCOME result = new MISC_TAXABLE_INCOME();
                result.EMP_CODE = dr.EMP_CODE;
                result.FINANCIAL_YEAR = dr.FINANCIAL_YEAR;
                result.NARRATION = dr.NARRATION;
                result.AMOUNT = dr.AMOUNT;
                result.INCOME_CODE = dr.INCOME_CODE;
                result.ENTRY_DATE = dr.ENTRY_DATE;
                result.UTILISED = dr.UTILISED;
                result.TAX_AMT_DED = dr.TAX_AMT_DED;
                result.TAX_DED = dr.TAX_DED;
                result.SCHG_DED = dr.SCHG_DED;
                result.CESS_DED = dr.CESS_DED;
                result.HCESS_DED = dr.HCESS_DED;
                db1.MISC_TAXABLE_INCOME.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static MISC_TAXABLE_INCOME_Base generate_Base(MISC_TAXABLE_INCOME dr)
        {

            MISC_TAXABLE_INCOME_Base drb = Mapper.DynamicMap<MISC_TAXABLE_INCOME, MISC_TAXABLE_INCOME_Base>(dr);

            return drb;
        }

        public static List<MISC_TAXABLE_INCOME_Base> generate_Base(ICollection<MISC_TAXABLE_INCOME> i)
        {
            List<MISC_TAXABLE_INCOME_Base> drbl = Mapper.DynamicMap<ICollection<MISC_TAXABLE_INCOME>, List<MISC_TAXABLE_INCOME_Base>>(i);

            return drbl;
        }
    }
}
