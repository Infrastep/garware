using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
using BaseClass.VM.AgreementDetails;
namespace BuisnessController
{
   public class AGREEMENT_DETAILSBC
    {
        public static AGREEMENT_DETAILS_Base_AD insertupdateData(AGREEMENT_DETAILS_Base_AD obj)
        {
            AGREEMENT_DETAILSDL ed = new AGREEMENT_DETAILSDL();
            return ed.insertdata(obj);
        }

        public static List<AGREEMENT_DETAILS_Base_AD> getdata()
        {
            AGREEMENT_DETAILSDL ed = new AGREEMENT_DETAILSDL();
            return ed.getdata();
        }
        public static AGREEMENT_DETAILS_Base_AD getdata(int id)
        {
            AGREEMENT_DETAILSDL ed = new AGREEMENT_DETAILSDL();
            return ed.getdata(id);
        }
        public static AGREEMENT_DETAILS_Base_AD getdata(string Ref)
        {
            AGREEMENT_DETAILSDL ed = new AGREEMENT_DETAILSDL();
            return ed.getdata(Ref);
        }
    }
}
