using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseClass;
using BuisnessController;
using Newtonsoft.Json;
using System.Web.Security;
namespace Garware.Handler
{
    /// <summary>
    /// Summary description for EmployeeHandler
    /// </summary>
    public class EmployeeHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();
            System.Globalization.DateTimeFormatInfo format = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat;


            if (data == "InsertEM")
            {
                EMP_FIXED_Base obj = new EMP_FIXED_Base();



                obj.EMPID = Convert.ToInt32(postdata.id.ToString());
                obj.EMP_NAME = postdata.name.ToString();

                if (postdata.paddress1.ToString() != "") { obj.ADDR_PRESENT1 = postdata.paddress1.ToString(); }
                if (postdata.paddress2.ToString() != "") { obj.ADDR_PRESENT2 = postdata.paddress2.ToString(); }

                if (postdata.pmaddress1.ToString() != "") { obj.ADDR_PRMNT1 = postdata.pmaddress1.ToString(); }
                if (postdata.pmaddress2.ToString() != "") { obj.ADDR_PRMNT2 = postdata.pmaddress2.ToString(); }

                if (postdata.pphone.ToString() != "") { obj.TELEPHONE_PRESENT = postdata.pphone.ToString(); }
                if (postdata.pmphone.ToString() != "") { obj.TELEPHONE_PRMNT = postdata.pmphone.ToString(); }

                if (postdata.bplace.ToString() != "") { obj.BIRTH_PLACE = postdata.bplace.ToString(); }

                obj.DOB = Convert.ToDateTime(postdata.dob.ToString());

                if (postdata.code.ToString() != "") { obj.EMP_CODE = postdata.code.ToString(); }


                if (postdata.pmfax.ToString() != "") { obj.FAX = postdata.pmfax.ToString(); }

                if (postdata.pmmobile.ToString() != "") { obj.MOBILE = postdata.pmmobile.ToString(); }
                obj.NAME_PREFIX = postdata.prefix.ToString();
                obj.NATIONALITY = Convert.ToInt32(postdata.nationality.ToString()); 
                obj.PHOTO = postdata.photo.ToString();

                obj.RELIGIONID = Convert.ToInt32(postdata.religion.ToString());
                obj.FATHER_NAME = postdata.fathername.ToString();
                obj.EMAIL = postdata.pmemail.ToString();
                obj.SEX = postdata.prefix.ToString();
                if (postdata.citizen.ToString() == "0")
                { obj.SR_CITIZEN = false; }
                else { obj.SR_CITIZEN = true; }
                obj.STATUS = Convert.ToInt32(postdata.status.ToString());
                if (obj.EMPID == 0)
                {
                    MembershipUser mu = Membership.CreateUser(obj.EMAIL, "temppass@123", obj.EMAIL.ToString());

                    Guid aspnetid = new Guid(mu.ProviderUserKey.ToString());
                    Roles.AddUserToRole(mu.UserName, "Subscriber");
                    obj.ASP_USER_DETAILS = aspnetid;
                    UtilityBC.SendMail(obj.EMP_NAME, obj.EMAIL);
                }
                dynamic jso = EmployeeBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject(jso);
            }

            if (data == "GetEM")
            {
                string rolename = string.Empty;
                string[] roles = null;

                if (Membership.GetUser() != null)
                {
                    roles = Roles.GetRolesForUser(Membership.GetUser().UserName);
                    if (roles.Length > 0)
                    { rolename = roles[0]; }

                }

                List<EMP_FIXED_Base> lst = new List<EMP_FIXED_Base>();
              
                lst = EmployeeBC.getdata().OrderByDescending(q => q.EMPID).ToList();
             
                jstring = JsonConvert.SerializeObject(lst);
            }
            if (data == "VERIFYEM")
            {
                EMPLOYEE_STATUS_Base ESB = new EMPLOYEE_STATUS_Base();
                string UID = string.Empty; int res = 0;
                int statusid = 0;
                Guid currentuid = Guid.Empty;
                int userId = 0;
                int userId1 = 0;
                 string sendername ="";
                int ID = Convert.ToInt32(postdata.empID.ToString());
                string text = postdata.text.ToString();
                string comment = postdata.comment.ToString();
                string status = postdata.status.ToString();
                string empName = postdata.empname.ToString();
                string empEmail = postdata.email.ToString();
                if (text == "A")
                {
                    if (status == "true")
                    { statusid = 1; }
                    else if (status == "7")
                    { statusid = 11; }
                    else if (status == "8")
                    { statusid = 12; }
                }
                else if (text == "B")
                {
                    if (status == "true")
                    { statusid = 2; }
                    else if (status == "7")
                    { statusid = 13; }
                    else if (status == "8")
                    { statusid = 14; }
                }
                else if (text == "C")
                {
                    if (status == "true")
                    { statusid = 3; }
                    else if (status == "7")
                    { statusid = 15; }
                    else if (status == "8")
                    { statusid = 16; }
                }
                else if (text == "CA")
                { statusid = 4; }
                else if (text == "CNA")
                { statusid = 5; }
                else if (text == "CB")
                { statusid = 6; }
                else
                { statusid = 0; }
                if (Membership.GetUser() != null)
                {
                    UID = Membership.GetUser(HttpContext.Current.User.Identity.Name).ProviderUserKey.ToString();
                    currentuid = new Guid(UID);
                    //var lst = PersonnelMasterBC.getdataByUserID(currentuid);
                    var lst1 = EmployeeBC.getEmpIDByGuid(currentuid);
                    //if (lst != null)
                    //{
                    //    userId = lst.PERSONNELID;
                       
                    //}
                    if (lst1 != null)
                    {
                        userId1 = lst1.EMPID;
                        sendername = lst1.EMP_NAME;
                    }

                    res = EmployeeBC.VerifyEMP(ID, text,status);
                    if (res == 1)
                    {
                        ESB.EMP_ID = ID;
                        ESB.REMARKS = comment;
                        ESB.STATUS_ID = statusid;
                        ESB.UPDATE_PERSONEL = userId1;
                        ESB.UPDATE_DATE = DateTime.Now;
                        ESB.ENTRY_DATE = DateTime.Now;
                        EmployeeStatusBC.insertupdateData(ESB);
                        if (statusid == 4 || statusid == 5 || statusid ==6)
                        {
                            EmployeeClientBC.UpdateEMPStatus(ID, statusid);
                            CLIENT_COMMENT_Base obj = new CLIENT_COMMENT_Base();
                            obj.EMPID = ID;
                            obj.SENDERUSERID = userId1;
                            obj.RECEIVERUSERID = ID;
                            obj.COMMENT = comment;
                            obj.COMMENTDATE = Convert.ToDateTime(DateTime.Now);
                            obj.PUBLIC = false;
                            obj.PRIVATE = true;
                            CLIENT_COMMENTBC.insertupdateData(obj);
                        }
                        else
                        {
                            COMMENT_Base obj = new COMMENT_Base();
                            obj.EMPID = ID;
                            obj.SENDERUSERID = userId1;
                            obj.RECEIVERUSERID = ID;
                            obj.COMMENT1 = comment;
                            obj.COMMENTDATE = Convert.ToDateTime(DateTime.Now);
                            obj.PUBLIC = false;
                            obj.PRIVATE = true;
                            COMMENTBC.insertupdateData(obj);
                        }
                        UtilityBC.SendCommentMail(ID, sendername, empName, empName, "", "", "", comment, true);
                    }

                }

                jstring = JsonConvert.SerializeObject(res);
            }
            if (data == "GetRoles")
            {
                string[] roles = null;

                string[] roleNames = Roles.GetRolesForUser();
                roles = Roles.GetAllRoles();
              
                roles.Where(q => q != roleNames[0]);
                jstring = JsonConvert.SerializeObject(roles);
            }
            if (data == "GetEmpListForComment")
            {
                List<EMP_FIXED_Base> lst = new List<EMP_FIXED_Base>();
                int EmpID = Convert.ToInt32(postdata.empID.ToString());
                lst = EmployeeBC.getUserForMailsend(EmpID);
                jstring = JsonConvert.SerializeObject(lst);
            }
            if (data == "GetEmpListForClient")
            {
                List<EMP_FIXED_Base> lst = new List<EMP_FIXED_Base>();
                
                lst = EmployeeBC.getdataforClient();
                jstring = JsonConvert.SerializeObject(lst);
            }
            if (data == "GetEMP")
            {
                
                List<EMP_FIXED_Base> lst = new List<EMP_FIXED_Base>();

                lst = EmployeeBC.getdatanew().OrderByDescending(q => q.EMPID).ToList();

                jstring = JsonConvert.SerializeObject(lst);
            }
            if (data == "GetEMPByID")
            {

                EMP_FIXED_Base lst = new EMP_FIXED_Base();
                int EmpID = Convert.ToInt32(postdata.empID.ToString());
                lst = EmployeeBC.getdata(EmpID);

                jstring = JsonConvert.SerializeObject(lst);
            }
            context.Response.ContentType = "application / json";
            context.Response.Write(jstring);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}