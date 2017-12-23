using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
  public  class CLIENT_USERBC
  {
      public static CLIENT_USER_Base insertupdateData(CLIENT_USER_Base obj)
      {
          CLIENT_USERDL ed = new CLIENT_USERDL();
          return ed.insertdata(obj);
      }

      public static List<CLIENT_USER_Base> getdata()
      {
          CLIENT_USERDL ed = new CLIENT_USERDL();
          return ed.getdata();
      }
      public static CLIENT_USER_Base getdata(int id)
      {
          CLIENT_USERDL ed = new CLIENT_USERDL();
          return ed.getdata(id);
      }
    }
}
