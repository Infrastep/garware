using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
    public class EMP_FIXEDDL : COreEI
    {
        public List<EMP_FIXED_Base> getdata()
        {

            List<EMP_FIXED> dr = db1.EMP_FIXED.Where(q => q.EMPID < 3958 || q.EMPID > 3961).ToList();
            List<EMP_FIXED_Base> drb = generate_Base(dr);
            return drb;

        }

        public List<EMP_FIXED_Base> getdatanew()
        {

            List<EMP_FIXED> dr = db1.EMP_FIXED.ToList();
            List<EMP_FIXED_Base> drb = generate_Base(dr);
            return drb;

        }
        public List<EMP_FIXED_Base> getSubscriber()
        {
           
            Guid RolId=new Guid("657C1D66-70DD-426A-BC94-ED5E2C6842F2");
            List<EMP_FIXED_Base> lstEmp = new List<EMP_FIXED_Base>();

            var lst = (from dr in db1.EMP_FIXED
                       
                       join
                           r in db1.aspnet_UsersInRoles on dr.ASP_USER_DETAILS equals r.UserId
                       where r.RoleId == RolId
                       select new  { dr,r}).ToList();
                       if(lst.Count > 0)
                       {
                           for (int i = 0; i < lst.Count; i++)
                           {
                               EMP_FIXED_Base drb = new EMP_FIXED_Base();
                               drb.EMPID = lst[i].dr.EMPID;
                               drb.STATUS = lst[i].dr.STATUS;
                               drb.SR_CITIZEN = lst[i].dr.SR_CITIZEN;
                               drb.EMP_CODE = lst[i].dr.EMP_CODE;
                               drb.EMP_NAME = lst[i].dr.EMP_NAME;
                               drb.NAME_PREFIX = lst[i].dr.NAME_PREFIX;
                               drb.ADDR_PRESENT1 = lst[i].dr.ADDR_PRESENT1;
                               drb.ADDR_PRESENT2 = lst[i].dr.ADDR_PRESENT2;
                               drb.ADDR_PRESENT3 = lst[i].dr.ADDR_PRESENT3;
                               drb.ADDR_PRMNT1 = lst[i].dr.ADDR_PRMNT1;
                               drb.ADDR_PRMNT2 = lst[i].dr.ADDR_PRMNT2;
                               drb.ADDR_PRMNT3 = lst[i].dr.ADDR_PRMNT3;
                               drb.TELEPHONE_PRESENT = lst[i].dr.TELEPHONE_PRESENT;
                               drb.TELEPHONE_PRMNT = lst[i].dr.TELEPHONE_PRMNT;
                               drb.FATHER_NAME = lst[i].dr.FATHER_NAME;
                               drb.SEX = lst[i].dr.SEX;
                               drb.DOB = lst[i].dr.DOB;
                               drb.BIRTH_PLACE = lst[i].dr.BIRTH_PLACE;
                               drb.NATIONALITY = lst[i].dr.NATIONALITY;
                               drb.FAX = lst[i].dr.FAX;
                               drb.MOBILE = lst[i].dr.MOBILE;
                               drb.EMAIL = lst[i].dr.EMAIL;
                               drb.RELIGIONID = lst[i].dr.RELIGIONID;
                               if (lst[i].dr.PHOTO != null && lst[i].dr.PHOTO != "")
                               { drb.PHOTO = UTILITYDL.GetImage(lst[i].dr.PHOTO, "user", lst[i].dr.EMPID); }
                               else
                               { drb.PHOTO = "/uploads/avatar.png"; }

                               drb.ASP_USER_DETAILS = lst[i].dr.ASP_USER_DETAILS;
                               drb.ALEVELVERIFY = lst[i].dr.ALEVELVERIFY;
                               drb.BLEVELVERIFY = lst[i].dr.BLEVELVERIFY;
                               drb.CLEVELVERIFY = lst[i].dr.CLEVELVERIFY;
                               drb.RELIGION = RELIGIONDL.generate_Base(lst[i].dr.RELIGION);
                               drb.SELECTION_STATUS_MASTER = SELECTION_STATUS_MASTERDL.generate_Base(lst[i].dr.SELECTION_STATUS_MASTER);
                               lstEmp.Add(drb);
                           }
                       
                       }

            //List<EMP_FIXED_Base> drb = generate_Base(dr);
           // var cd=()
                       return lstEmp;

        }
        public List<EMP_FIXED_Base> getdataNotIn()
        {

            List<EMP_FIXED> dr = db1.EMP_FIXED.Where(q => q.EMPID < 3950).ToList();
            List<EMP_FIXED_Base> drb = generate_Base(dr);
            return drb;

        }


        public EMP_FIXED_Base getdata(int id)
        {

            EMP_FIXED dr = db1.EMP_FIXED.Where(q => q.EMPID == id).Single();
            EMP_FIXED_Base STM = generate_Base(dr);
            return STM;


        }
        public EMP_FIXED_Base getEmpIDByGuid(Guid id)
        {
            EMP_FIXED_Base STM = new EMP_FIXED_Base();
            List<EMP_FIXED> dr = db1.EMP_FIXED.Where(q => q.ASP_USER_DETAILS == id).ToList();
            if (dr.Count > 0)
            {
                STM = generate_Base(dr[0]);
            }
            return STM;


        }
        public List<EMP_FIXED_Base> getUserForMailsend(int id)
        {
            List<EMP_FIXED_Base> lst = new List<EMP_FIXED_Base>();
            var dr = db1.sp_GetUserIdForMailsend(id).ToList();
            if (dr.Count > 0)
            {
                for (int i = 0; i < dr.Count; i++)
                {
                    EMP_FIXED_Base EFBC = new EMP_FIXED_Base();
                    EFBC.EMPID = dr[i].EMPID;
                    EFBC.EMP_NAME = dr[i].EMP_NAME;
                    EFBC.EMAIL = dr[i].EMAIL;
                    lst.Add(EFBC);
                }
            }
            return lst;
        }

        public EMP_FIXED_Base insertdata(EMP_FIXED_Base dr)
        {
            int id = dr.EMPID;
            if (id != 0)
            {
                EMP_FIXED result = db1.EMP_FIXED.Where(q => q.EMPID == id).Single();
                if (result != null)
                {
                    result.EMPID = dr.EMPID;
                    if (dr.STATUS == 9 || dr.STATUS == 10 )
                    {
                        result.STATUS = dr.STATUS;
                    }
                    else if (dr.STATUS == 0)
                    { result.STATUS = result.STATUS; }
                    else
                    { result.STATUS = result.STATUS; }
                    result.SR_CITIZEN = dr.SR_CITIZEN;
                    if (dr.EMP_CODE != "")
                    {
                        result.EMP_CODE = dr.EMP_CODE;
                    }
                    result.EMP_NAME = dr.EMP_NAME;
                    result.NAME_PREFIX = dr.NAME_PREFIX;
                    result.ADDR_PRESENT1 = dr.ADDR_PRESENT1;

                    result.ADDR_PRESENT2 = dr.ADDR_PRESENT2;
                    result.ADDR_PRESENT3 = dr.ADDR_PRESENT3;
                    result.ADDR_PRMNT1 = dr.ADDR_PRMNT1;
                    result.ADDR_PRMNT2 = dr.ADDR_PRMNT2;
                    result.ADDR_PRMNT3 = dr.ADDR_PRMNT3;
                    result.TELEPHONE_PRESENT = dr.TELEPHONE_PRESENT;
                    result.TELEPHONE_PRMNT = dr.TELEPHONE_PRMNT;
                    result.FATHER_NAME = dr.FATHER_NAME;
                    result.SEX = dr.SEX;
                    result.DOB = dr.DOB;
                    result.BIRTH_PLACE = dr.BIRTH_PLACE;
                    result.NATIONALITY = dr.NATIONALITY;
                    result.FAX = dr.FAX;
                    result.MOBILE = dr.MOBILE;
                    result.EMAIL = dr.EMAIL;
                    result.RELIGIONID = dr.RELIGIONID;
                    if (dr.PHOTO != null && dr.PHOTO != "")
                    { result.PHOTO = dr.PHOTO; }
                    
                    //result.ASP_USER_DETAILS = dr.ASP_USER_DETAILS;
                    //result.ALABLEVERIFY = false;
                    //result.BLABLEVERIFY = false;
                    result.SIGNINGAUTH = dr.SIGNINGAUTH;
                    result.DESIGNATION = dr.DESIGNATION;

                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                EMP_FIXED result = new EMP_FIXED();

                result.STATUS = dr.STATUS;
                result.SR_CITIZEN = dr.SR_CITIZEN;
                result.EMP_CODE = dr.EMP_CODE;
                result.EMP_NAME = dr.EMP_NAME;
                result.NAME_PREFIX = dr.NAME_PREFIX;
                result.ADDR_PRESENT1 = dr.ADDR_PRESENT1;

                result.ADDR_PRESENT2 = dr.ADDR_PRESENT2;
                result.ADDR_PRESENT3 = dr.ADDR_PRESENT3;
                result.ADDR_PRMNT1 = dr.ADDR_PRMNT1;
                result.ADDR_PRMNT2 = dr.ADDR_PRMNT2;
                result.ADDR_PRMNT3 = dr.ADDR_PRMNT3;
                result.TELEPHONE_PRESENT = dr.TELEPHONE_PRESENT;
                result.TELEPHONE_PRMNT = dr.TELEPHONE_PRMNT;
                result.FATHER_NAME = dr.FATHER_NAME;
                result.SEX = dr.SEX;
                result.DOB = dr.DOB;
                result.BIRTH_PLACE = dr.BIRTH_PLACE;
                result.NATIONALITY = dr.NATIONALITY;
                result.FAX = dr.FAX;
                result.MOBILE = dr.MOBILE;
                result.EMAIL = dr.EMAIL;
                result.RELIGIONID = dr.RELIGIONID;
                result.PHOTO = dr.PHOTO;
                result.ASP_USER_DETAILS = dr.ASP_USER_DETAILS;
                result.ALEVELVERIFY = false;
                result.BLEVELVERIFY = false;
                result.CLEVELVERIFY = false;
                result.SIGNINGAUTH = dr.SIGNINGAUTH;
                result.DESIGNATION = dr.DESIGNATION;
                db1.EMP_FIXED.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public int VerifyEMP(int id, string text, string status)
        {
            int res = 0;
            EMP_FIXED dr = db1.EMP_FIXED.Where(q => q.EMPID == id).Single();
            if (dr != null)
            {
                if (text == "A")
                {
                    if (status == "true")
                    {
                        dr.ALEVELVERIFY = true;
                        dr.STATUS = 1;
                    }
                    else if (status == "7")
                    { dr.ALEVELVERIFY = false; dr.STATUS = 11; }
                    else if (status == "8")
                    { dr.ALEVELVERIFY = false; dr.STATUS = 12; }
                }
                else if (text == "B")
                {
                    if (status == "true")
                    { dr.BLEVELVERIFY = true; dr.STATUS = 2; }
                    else if (status == "7")
                    { dr.BLEVELVERIFY = false; dr.STATUS = 13; }
                    else if (status == "8")
                    { dr.BLEVELVERIFY = false; dr.STATUS = 14; }
                }
                else if (text == "C")
                {
                    if (status == "true")
                    { dr.CLEVELVERIFY = true; dr.STATUS = 3; }
                    else if (status == "7")
                    { dr.CLEVELVERIFY = false; dr.STATUS = 15; }
                    else if (status == "8")
                    { dr.CLEVELVERIFY = false; dr.STATUS = 16; }

                }
                else
                {
                    dr.STATUS = Convert.ToInt32(status);
                }
                CommitChanges();
                res = 1;
            }

            return res;


        }
        public int UpdateStatus(int id, int status)
        {
            int res = 0;
            var dr = db1.EMP_FIXED.Where(q => q.EMPID == id).ToList();
            if (dr.Count > 0)
            {
                dr[0].STATUS = status;
                CommitChanges();
                res = 1;
            }
            return res;
        }
        public int UpdateImage(int id, string path)
        {
            int res = 0;
            var dr = db1.EMP_FIXED.Where(q => q.EMPID == id).ToList();
            if (dr.Count > 0)
            {
                dr[0].PHOTO = path;
                CommitChanges();
                res = 1;
            }
            return res;
        }
        public List<EMP_FIXED_Base> getdataforClient()
        {

            List<EMP_FIXED> dr = db1.EMP_FIXED.Where(q => q.STATUS == 3).ToList();
            List<EMP_FIXED_Base> STM = generate_Base(dr);
            return STM;


        }

        public static EMP_FIXED_Base generate_Base(EMP_FIXED dr)
        {

            EMP_FIXED_Base drb = new EMP_FIXED_Base();
            if (dr != null)
            {
                drb.EMPID = dr.EMPID;
                drb.STATUS = dr.STATUS;
                drb.SR_CITIZEN = dr.SR_CITIZEN;
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
                drb.FATHER_NAME = dr.FATHER_NAME;
                drb.SEX = dr.SEX;
                drb.DOB = dr.DOB;
                drb.BIRTH_PLACE = dr.BIRTH_PLACE;
                drb.NATIONALITY = dr.NATIONALITY;
                drb.FAX = dr.FAX;
                drb.MOBILE = dr.MOBILE;
                drb.EMAIL = dr.EMAIL;
                drb.RELIGIONID = dr.RELIGIONID;
                if(dr.PHOTO != null && dr.PHOTO !="" )
                { drb.PHOTO = UTILITYDL.GetImage(dr.PHOTO, "user", dr.EMPID); }
                else
                { drb.PHOTO = "/uploads/avatar.png"; }
                
                drb.ASP_USER_DETAILS = dr.ASP_USER_DETAILS;
                drb.ALEVELVERIFY = dr.ALEVELVERIFY;
                drb.BLEVELVERIFY = dr.BLEVELVERIFY;
                drb.CLEVELVERIFY = dr.CLEVELVERIFY;
                drb.SIGNINGAUTH = dr.SIGNINGAUTH;
                drb.DESIGNATION = dr.DESIGNATION;
                drb.RELIGION = RELIGIONDL.generate_Base(dr.RELIGION);
                drb.SELECTION_STATUS_MASTER = SELECTION_STATUS_MASTERDL.generate_Base(dr.SELECTION_STATUS_MASTER);
            }
            return drb;
        }

        public static List<EMP_FIXED_Base> generate_Base(ICollection<EMP_FIXED> i)
        {
            List<EMP_FIXED_Base> drbl = new List<EMP_FIXED_Base>();
            int x = 0;
            foreach (EMP_FIXED dr in i)
            {
                EMP_FIXED_Base drb = new EMP_FIXED_Base();
                drb.EMPID = dr.EMPID;
                drb.STATUS = dr.STATUS;
                drb.SR_CITIZEN = dr.SR_CITIZEN;
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
                drb.FATHER_NAME = dr.FATHER_NAME;
                drb.SEX = dr.SEX;
                drb.DOB = dr.DOB;
                drb.BIRTH_PLACE = dr.BIRTH_PLACE;
                drb.NATIONALITY = dr.NATIONALITY;
                drb.FAX = dr.FAX;
                drb.MOBILE = dr.MOBILE;
                drb.EMAIL = dr.EMAIL;
                drb.RELIGIONID = dr.RELIGIONID;
                if (dr.PHOTO != null && dr.PHOTO != "")
                { drb.PHOTO = UTILITYDL.GetImage(dr.PHOTO, "user", dr.EMPID); }
                else
                { drb.PHOTO = "/uploads/avatar.png"; }
                drb.ASP_USER_DETAILS = dr.ASP_USER_DETAILS;
                drb.ALEVELVERIFY = dr.ALEVELVERIFY;
                drb.BLEVELVERIFY = dr.BLEVELVERIFY;
                drb.CLEVELVERIFY = dr.CLEVELVERIFY;
                drb.SIGNINGAUTH = dr.SIGNINGAUTH;
                drb.DESIGNATION = dr.DESIGNATION;
                drb.RELIGION = RELIGIONDL.generate_Base(dr.RELIGION);
                drb.SELECTION_STATUS_MASTER = SELECTION_STATUS_MASTERDL.generate_Base(dr.SELECTION_STATUS_MASTER);

                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
