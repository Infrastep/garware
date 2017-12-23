using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
   public class PAGE_PERMISSIONBC
    {
        public static PAGE_PERMISSION_Base insertupdateData(PAGE_PERMISSION_Base obj)
        {
            PAGE_PERMISSIONDL ed = new PAGE_PERMISSIONDL();
            return ed.insertdata(obj);
        }

        public static List<PAGE_PERMISSION_Base> getdata()
        {
            PAGE_PERMISSIONDL ed = new PAGE_PERMISSIONDL();
            return ed.getdata();
        }
        public static PAGE_PERMISSION_Base getdata(int id)
        {
            PAGE_PERMISSIONDL ed = new PAGE_PERMISSIONDL();
            return ed.getdata(id);
        }
        public static List<PAGE_PERMISSION_Base> getdatabyRolename(string Rolename)
        {
            PAGE_PERMISSIONDL ed = new PAGE_PERMISSIONDL();
            return ed.getdatabyRolename(Rolename);
        }

        public static List<PAGE_PERMISSION_Base> getdatabyPagename(string Pagename,int permission)
        {
            PAGE_PERMISSIONDL ed = new PAGE_PERMISSIONDL();
            return ed.getdatabyPagename(Pagename,permission);
        }
    }
}
