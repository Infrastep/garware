using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class SELECTION_STATUS_MASTERBC
    {
       public static List<SELECTION_STATUS_MASTER_Base> getdata()
       {
           SELECTION_STATUS_MASTERDL ed = new SELECTION_STATUS_MASTERDL();
           return ed.getdata();
       }
    }
}
