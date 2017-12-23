using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseClass;
using BuisnessController;
using Newtonsoft.Json;
using System.Web.Security;
using System.Collections;
namespace Frontend.Handler
{
    /// <summary>
    /// Summary description for CommentHandler
    /// </summary>
    public class CommentHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();
            System.Globalization.DateTimeFormatInfo format = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat;


            if (data == "GetCOM")
            {
                COMMENT_Base obj = new COMMENT_Base();
                List<COMMENT_Base> lst = new List<COMMENT_Base>();
                obj.EMPID = Convert.ToInt32(postdata.id.ToString());

                lst = COMMENTBC.getdatabyEmpId(obj).ToList();

                jstring = JsonConvert.SerializeObject(lst);
            }

            if (data == "InsertCOM")
            {
                COMMENT_Base obj = new COMMENT_Base();
                obj.EMPID = Convert.ToInt32(postdata.empID.ToString());
                obj.COMMENTID = Convert.ToInt32(postdata.comid.ToString());

                obj.SENDERUSERID = Convert.ToInt32(postdata.sender.ToString());

                obj.RECEIVERUSERID = Convert.ToInt32(postdata.receiver.ToString());
                obj.COMMENT1 = postdata.comment.ToString();
                obj.COMMENTDATE = Convert.ToDateTime(DateTime.Now);
                obj.PUBLIC = Convert.ToBoolean(postdata.pub.ToString());
                obj.PRIVATE = Convert.ToBoolean(postdata.pri.ToString());
                //dynamic jso = COMMENTBC.insertupdateData(obj);
                var dt = COMMENTBC.insertupdateData(obj);

                var lst = EmployeeBC.getdata(Convert.ToInt32(obj.EMPID));
                var lst1 = EmployeeBC.getdata(Convert.ToInt32(obj.SENDERUSERID));
                var lst2 = EmployeeBC.getdata(Convert.ToInt32(obj.RECEIVERUSERID));
                string SenderName = dt.EMP_FIXED1.EMP_NAME;
                string RecevierName = dt.EMP_FIXED2.EMP_NAME;
                string EmpEmail = dt.EMP_FIXED.EMAIL;
                string SenderEmail = dt.EMP_FIXED1.EMAIL;
                string RecevierEmail = dt.EMP_FIXED2.EMAIL;
                if (obj.PUBLIC == true)
                {
                    UtilityBC.SendCommentMail(Convert.ToInt32(obj.EMPID), lst1.EMP_NAME, lst2.EMP_NAME, lst.EMP_NAME, "", "", "", obj.COMMENT1, true);
                }
                else
                { UtilityBC.SendCommentMail(Convert.ToInt32(obj.EMPID), lst1.EMP_NAME, lst2.EMP_NAME, lst.EMP_NAME, lst1.EMAIL, lst2.EMAIL, lst.EMAIL, obj.COMMENT1, false); }
                jstring = JsonConvert.SerializeObject(dt);
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