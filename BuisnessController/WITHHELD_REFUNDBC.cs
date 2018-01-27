using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using BaseClass.VM.WithheldRefund;
using DataAccess.Infrastructure;
namespace BuisnessController
{
  public  class WITHHELD_REFUNDBC
  {
      public static WITHHELD_REFUND_Base_WR insertupdateData(WITHHELD_REFUND_Base obj)
      {
          WITHHELD_REFUNDDL ed = new WITHHELD_REFUNDDL();
          return ed.insertdata(obj);
      }

      public static List<WITHHELD_REFUND_Base_WR> getdata()
      {
          WITHHELD_REFUNDDL ed = new WITHHELD_REFUNDDL();
          return ed.getdata();
      }
      public static WITHHELD_REFUND_Base_WR getdata(int id)
      {
          WITHHELD_REFUNDDL ed = new WITHHELD_REFUNDDL();
          return ed.getdata(id);
      }
    }
}
