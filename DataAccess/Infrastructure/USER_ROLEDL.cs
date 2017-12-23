using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
    public class USER_ROLEDL : COreEI
    {

        public List<USER_ROLE_Base> getdata()
        {

            List<vw_UserRoleDetails> dr = db1.vw_UserRoleDetails.Where(q => q.RoleName != "Subscriber" && q.RoleName != "SuperAdmin").ToList();
            List<USER_ROLE_Base> drb = generate_Base(dr);
            return drb;

        }

        public static USER_ROLE_Base generate_Base(vw_UserRoleDetails dr)
        {

            USER_ROLE_Base drb = new USER_ROLE_Base();
            if (dr != null)
            {
                drb.EMPID = dr.EMPID;
                drb.STATUS = dr.STATUS;

                drb.EMP_CODE = dr.EMP_CODE;
                drb.EMP_NAME = dr.EMP_NAME;
                drb.NAME_PREFIX = dr.NAME_PREFIX;
                drb.ADDR_PRESENT1 = dr.ADDR_PRESENT1;
                drb.ADDR_PRESENT2 = dr.ADDR_PRESENT2;
                drb.ADDR_PRESENT3 = dr.ADDR_PRESENT3;
                drb.ADDR_PRMNT1 = dr.ADDR_PRMNT1;
                drb.ADDR_PRMNT2 = dr.ADDR_PRMNT2;
                drb.ADDR_PRMNT3 = dr.ADDR_PRMNT3;
                drb.TELEPHONE_PRESENT = dr.TELEPHONE_PRESENT;
                drb.TELEPHONE_PRMNT = dr.TELEPHONE_PRMNT;

                drb.SEX = dr.SEX;
                drb.DOB = dr.DOB;

                drb.NATIONALITY = dr.NATIONALITY;
                drb.FAX = dr.FAX;
                drb.MOBILE = dr.MOBILE;
                drb.EMAIL = dr.EMAIL;
                drb.RELIGIONID = dr.RELIGIONID;
                if (dr.PHOTO != null && dr.PHOTO != "")
                { drb.PHOTO = UTILITYDL.GetImage(dr.PHOTO,"user"); }
                else
                { drb.PHOTO = "/uploads/avatar.png"; }

                drb.ASP_USER_DETAILS = dr.ASP_USER_DETAILS;
                drb.RELIGIONID = dr.RELIGIONID;
                drb.RELIGION_NAME = dr.RELIGION_NAME;
                drb.DESIGNATION = dr.DESIGNATION;
                drb.SIGNINGAUTH = dr.SIGNINGAUTH;
                drb.SPID = dr.SPID;
                drb.SPNAME = dr.SPNAME;
                drb.RoleName = dr.RoleName;
                drb.CLIENTUSERID = dr.CLIENTUSERID;
                drb.CLIENTID = dr.CLIENTID;
                drb.USERID = dr.USERID;
                drb.CLIENT_NAME = dr.CLIENT_NAME;
                drb.ClientEmail = dr.ClientEmail;
            }
            return drb;
        }

        public static List<USER_ROLE_Base> generate_Base(ICollection<vw_UserRoleDetails> i)
        {
            List<USER_ROLE_Base> drbl = new List<USER_ROLE_Base>();
            int x = 0;
            foreach (vw_UserRoleDetails dr in i)
            {
                USER_ROLE_Base drb = new USER_ROLE_Base();
                drb.EMPID = dr.EMPID;
                drb.STATUS = dr.STATUS;

                drb.EMP_CODE = dr.EMP_CODE;
                drb.EMP_NAME = dr.EMP_NAME;
                drb.NAME_PREFIX = dr.NAME_PREFIX;
                drb.ADDR_PRESENT1 = dr.ADDR_PRESENT1;
                drb.ADDR_PRESENT2 = dr.ADDR_PRESENT2;
                drb.ADDR_PRESENT3 = dr.ADDR_PRESENT3;
                drb.ADDR_PRMNT1 = dr.ADDR_PRMNT1;
                drb.ADDR_PRMNT2 = dr.ADDR_PRMNT2;
                drb.ADDR_PRMNT3 = dr.ADDR_PRMNT3;
                drb.TELEPHONE_PRESENT = dr.TELEPHONE_PRESENT;
                drb.TELEPHONE_PRMNT = dr.TELEPHONE_PRMNT;

                drb.SEX = dr.SEX;
                drb.DOB = dr.DOB;

                drb.NATIONALITY = dr.NATIONALITY;
                drb.FAX = dr.FAX;
                drb.MOBILE = dr.MOBILE;
                drb.EMAIL = dr.EMAIL;
                drb.RELIGIONID = dr.RELIGIONID;
                if (dr.PHOTO != null && dr.PHOTO != "")
                { drb.PHOTO = UTILITYDL.GetImage(dr.PHOTO,"user"); }
                else
                { drb.PHOTO = "/uploads/avatar.png"; }

                drb.ASP_USER_DETAILS = dr.ASP_USER_DETAILS;
                drb.RELIGIONID = dr.RELIGIONID;
                drb.RELIGION_NAME = dr.RELIGION_NAME;
                drb.DESIGNATION = dr.DESIGNATION;
                drb.SIGNINGAUTH = dr.SIGNINGAUTH;
                drb.SPID = dr.SPID;
                drb.SPNAME = dr.SPNAME;
                drb.RoleName = dr.RoleName;
                drb.CLIENTUSERID = dr.CLIENTUSERID;
                drb.CLIENTID = dr.CLIENTID;
                drb.USERID = dr.USERID;
                drb.CLIENT_NAME = dr.CLIENT_NAME;
                drb.ClientEmail = dr.ClientEmail;
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
