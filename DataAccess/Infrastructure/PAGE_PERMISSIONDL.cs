using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
using AutoMapper;
namespace DataAccess.Infrastructure
{
   public class PAGE_PERMISSIONDL : COreEI
   {
       public List<PAGE_PERMISSION_Base> getdata()
       {

           List<PAGE_PERMISSION> dr = db1.PAGE_PERMISSION.ToList();
           List<PAGE_PERMISSION_Base> drb = generate_Base(dr);
           return drb;

       }

       public PAGE_PERMISSION_Base getdata(int id)
       {

           PAGE_PERMISSION dr = db1.PAGE_PERMISSION.Where(q => q.PAGEPERMISSIONID == id).Single();
           PAGE_PERMISSION_Base STM = generate_Base(dr);
           return STM;


       }

       public List<PAGE_PERMISSION_Base> getdatabyRolename(string rolename)
       {

           List<PAGE_PERMISSION> dr = db1.PAGE_PERMISSION.Where(q => q.ROLENAME == rolename).ToList();
           List<PAGE_PERMISSION_Base> STM = generate_Base(dr);
           return STM;


       }

       public List<PAGE_PERMISSION_Base> getdatabyPagename(string pagename,int permission)
       {

           List<PAGE_PERMISSION> dr = db1.PAGE_PERMISSION.Where(q => q.PAGE_MASTER.PAGENAME == pagename && q.PERMISSIONID==permission).ToList();
           List<PAGE_PERMISSION_Base> STM = generate_Base(dr);
           return STM;


       }

       public PAGE_PERMISSION_Base insertdata(PAGE_PERMISSION_Base dr)
       {
           int id = dr.PAGEPERMISSIONID;
           if (id != 0)
           {
               PAGE_PERMISSION result = db1.PAGE_PERMISSION.Where(q => q.PAGEPERMISSIONID == id).Single();
               if (result != null)
               {
                   result.PAGEPERMISSIONID = dr.PAGEPERMISSIONID;
                   //result.PAGEID = dr.PAGEID;
                   //result.ROLENAME = dr.ROLENAME;
                   result.PERMISSIONID = dr.PERMISSIONID;
                  
                   CommitChanges();
               }
               return generate_Base(result);
           }
           else
           {
               PAGE_PERMISSION result = new PAGE_PERMISSION();

               result.PAGEID = dr.PAGEID;
               result.ROLENAME = dr.ROLENAME;
               result.PERMISSIONID = dr.PERMISSIONID;
               db1.PAGE_PERMISSION.Add(result);
               CommitChanges();
               return generate_Base(result);
           }
       }

       public static PAGE_PERMISSION_Base generate_Base(PAGE_PERMISSION dr)
       {

           PAGE_PERMISSION_Base drb = Mapper.DynamicMap<PAGE_PERMISSION, PAGE_PERMISSION_Base>(dr);

           return drb;
       }

       public static List<PAGE_PERMISSION_Base> generate_Base(ICollection<PAGE_PERMISSION> i)
       {
           List<PAGE_PERMISSION_Base> drbl = Mapper.DynamicMap<ICollection<PAGE_PERMISSION>, List<PAGE_PERMISSION_Base>>(i);

           return drbl;
       }

    }
}
