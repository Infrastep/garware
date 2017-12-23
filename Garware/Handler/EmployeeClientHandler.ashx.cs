using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseClass;
using BuisnessController;
using Newtonsoft.Json;
namespace Garware.Handler
{
    /// <summary>
    /// Summary description for EmployeeClientHandler
    /// </summary>
    public class EmployeeClientHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            if (data == "InsertEC")
            {
                dynamic jso=null;
                string EC = postdata.EmpID.ToString();
                if (EC.Contains(","))
                {
                    string[] EMPIds = EC.Split(',');
                    for (int i = 1; i < EMPIds.Length; i++)
                    {
                        EMPLOYEE_CLIENT_Base obj = new EMPLOYEE_CLIENT_Base();
                        obj.EMPCLINTID = Convert.ToInt32(postdata.id.ToString());
                        obj.EMP_ID = Convert.ToInt32(EMPIds[i]);
                        obj.SHIP_ID = Convert.ToInt32(postdata.shipId.ToString());
                        obj.RANK_CLASS_ID = Convert.ToInt32(postdata.rankclassId.ToString());
                        obj.STARTDATE = Convert.ToDateTime(postdata.sdate.ToString());
                        obj.ENDDATE = Convert.ToDateTime(postdata.edate.ToString());
                        obj.STATUS = 17;
                        jso = EmployeeClientBC.insertupdateData(obj);
                        if (jso != null)
                        {
                            EmployeeBC.UpdateStatus(Convert.ToInt32(obj.EMP_ID), Convert.ToInt32(obj.STATUS));
                            List<EMPLOYEE_CLIENT_Base> lst = new List<EMPLOYEE_CLIENT_Base>();
                            lst = EmployeeClientBC.getdatabyEmpId(Convert.ToInt32(obj.EMP_ID)).ToList();
                            if (lst.Count > 0)
                            {
                                HttpCookie Cookies = HttpContext.Current.Request.Cookies.Get("mylogcookie");
                                string adminEmail = Convert.ToString(Cookies["email"]);
                                UtilityBC.SendShipAssignMail(lst[0].EMP_FIXED.EMP_NAME, lst[0].SHIP_MASTER.VNAME, lst[0].EMP_FIXED.EMAIL, "", Convert.ToString(lst[0].STARTDATE), Convert.ToString(lst[0].ENDDATE), "ShipAssign", "");
                                UtilityBC.SendShipAssignMailToAdmin(lst[0].EMP_FIXED.EMP_NAME, lst[0].SHIP_MASTER.VNAME, adminEmail, "","", Convert.ToString(lst[0].STARTDATE), Convert.ToString(lst[0].ENDDATE), "ShipAssign", "");
                                UtilityBC.SendShipAssignMailToAdmin(lst[0].EMP_FIXED.EMP_NAME, lst[0].SHIP_MASTER.VNAME,"", "","", Convert.ToString(lst[0].STARTDATE), Convert.ToString(lst[0].ENDDATE), "ShipAssign", "");
                            }
                        }
                    }
                }
                jstring = JsonConvert.SerializeObject(jso);
            }
            if (data == "GetEC")
            {
                List<EMPLOYEE_CLIENT_Base> lst = new List<EMPLOYEE_CLIENT_Base>();
                lst = EmployeeClientBC.getdata();
                jstring = JsonConvert.SerializeObject(lst);
            }
            if (data == "GetECbyClientID")
            {
                List<EMPLOYEE_CLIENT_Base> lst = new List<EMPLOYEE_CLIENT_Base>();
                int clientId = Convert.ToInt32(postdata.CID.ToString());
                lst = EmployeeClientBC.getdatabyClientId(clientId);
                jstring = JsonConvert.SerializeObject(lst);
            }
            if (data == "GetECbyID")
            {
                List<EMPLOYEE_CLIENT_Base> lst = new List<EMPLOYEE_CLIENT_Base>();
                int EMP_ID = Convert.ToInt32(postdata.EmpID.ToString());
                lst = EmployeeClientBC.getdatabyEmpId(EMP_ID);
                jstring = JsonConvert.SerializeObject(lst);
            }
            context.Response.ContentType = "application/json";
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