using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass.VM.ShipAgreement;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class SHIP_AGREEMENTBC
    {
       public static SHIP_AGREEMENT_Base_SA insertupdateData(SHIP_AGREEMENT_Base_SA obj)
        {
            SHIP_AGREEMENTDL ed = new SHIP_AGREEMENTDL();
            return ed.insertdata(obj);
        }

       public static List<SHIP_AGREEMENT_Base_SA> getdata()
        {
            SHIP_AGREEMENTDL ed = new SHIP_AGREEMENTDL();
            return ed.getdata();
        }
       public static SHIP_AGREEMENT_Base_SA getdata(int id)
        {
            SHIP_AGREEMENTDL ed = new SHIP_AGREEMENTDL();
            return ed.getdata(id);
        }
    }
}
