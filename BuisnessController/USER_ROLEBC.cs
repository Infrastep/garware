using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class USER_ROLEBC
    {
       public static List<USER_ROLE_Base> getdata()
       {
           USER_ROLEDL ed = new USER_ROLEDL();
           return ed.getdata();
       }
    }
}
