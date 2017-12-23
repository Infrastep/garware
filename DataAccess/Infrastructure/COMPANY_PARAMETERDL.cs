using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
  public  class COMPANY_PARAMETERDL :COreEI
    {
        public List<COMPANY_PARAMETER_Base> getdata()
        {

            List<COMPANY_PARAMETER> dr = db1.COMPANY_PARAMETER.ToList();
            List<COMPANY_PARAMETER_Base> drb = generate_Base(dr);
            return drb;

        }

        public COMPANY_PARAMETER_Base getdata(int id)
        {

            COMPANY_PARAMETER dr = db1.COMPANY_PARAMETER.Where(q => q.COMPANYID == id).Single();
            COMPANY_PARAMETER_Base STM = generate_Base(dr);
            return STM;


        }

        public COMPANY_PARAMETER_Base insertdata(COMPANY_PARAMETER_Base dr)
        {
            int id = dr.COMPANYID;
            if (id != 0)
            {
                COMPANY_PARAMETER result = db1.COMPANY_PARAMETER.Where(q => q.COMPANYID == id).Single();
                if (result != null)
                {
                    result.COMPANYID = dr.COMPANYID;
                    result.COMPANY_NAME = dr.COMPANY_NAME;
                   
                    result.PHONE = dr.PHONE;

                    result.FAX_NO = dr.FAX_NO;
                    result.EMAIL = dr.EMAIL;
                    result.SERVICE_TAX_NO = dr.SERVICE_TAX_NO;
                    result.PAN_NO = dr.PAN_NO;
                    if (dr.COMPANY_LOGO != "")
                    {
                        result.COMPANY_LOGO = dr.COMPANY_LOGO;
                    }
                    result.STATUS = dr.STATUS;


                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                COMPANY_PARAMETER result = new COMPANY_PARAMETER();
               
                result.COMPANY_NAME = dr.COMPANY_NAME;
                
                result.PHONE = dr.PHONE;
                result.FAX_NO = dr.FAX_NO;
                result.EMAIL = dr.EMAIL;
                result.SERVICE_TAX_NO = dr.SERVICE_TAX_NO;
                result.PAN_NO = dr.PAN_NO;
                result.COMPANY_LOGO = dr.COMPANY_LOGO;
                result.STATUS = dr.STATUS;
                db1.COMPANY_PARAMETER.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static COMPANY_PARAMETER_Base generate_Base(COMPANY_PARAMETER dr)
        {

            COMPANY_PARAMETER_Base drb = new COMPANY_PARAMETER_Base();
            if (dr != null)
            {
                drb.COMPANYID = dr.COMPANYID;
                drb.COMPANY_NAME = dr.COMPANY_NAME;
                
                drb.PHONE = dr.PHONE;
                drb.FAX_NO = dr.FAX_NO;
                drb.EMAIL = dr.EMAIL;
                drb.SERVICE_TAX_NO = dr.SERVICE_TAX_NO;
                drb.PAN_NO = dr.PAN_NO;
                drb.COMPANY_LOGO = dr.COMPANY_LOGO;
                drb.STATUS = dr.STATUS;
            }
            return drb;
        }

        public static List<COMPANY_PARAMETER_Base> generate_Base(ICollection<COMPANY_PARAMETER> i)
        {
            List<COMPANY_PARAMETER_Base> drbl = new List<COMPANY_PARAMETER_Base>();
            int x = 0;
            foreach (COMPANY_PARAMETER dr in i)
            {
                COMPANY_PARAMETER_Base drb = new COMPANY_PARAMETER_Base();
                drb.COMPANYID = dr.COMPANYID;
                drb.COMPANY_NAME = dr.COMPANY_NAME;
                
                drb.PHONE = dr.PHONE;
                drb.FAX_NO = dr.FAX_NO;
                drb.EMAIL = dr.EMAIL;
                drb.SERVICE_TAX_NO = dr.SERVICE_TAX_NO;
                drb.PAN_NO = dr.PAN_NO;
                drb.COMPANY_LOGO = dr.COMPANY_LOGO;
                drb.STATUS = dr.STATUS;
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
