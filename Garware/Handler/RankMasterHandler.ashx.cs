using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseClass;
using BuisnessController;
using Newtonsoft.Json;
using BaseClass.VM.RankMaster;
namespace Garware.Handler
{
    /// <summary>
    /// Summary description for RankMasterHandler
    /// </summary>
    public class RankMasterHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            if (data == "InsertRM")
            {
                RANK_MASTER_Base_RM obj = new RANK_MASTER_Base_RM();
                obj.RANKID = Convert.ToInt32(postdata.id.ToString());

                obj.RANK_DESC = postdata.description.ToString();
                obj.CATEGORYID = Convert.ToInt32(postdata.category.ToString());
                obj.Withheld_Perc_NRI = postdata.Withheld_Perc_NRI.ToString();
                obj.Print_order = Convert.ToInt32(postdata.Print_order.ToString());
                obj.Pf_Applicable = Convert.ToBoolean(postdata.status.ToString());
                obj.Active = Convert.ToBoolean(postdata.Pf_Applicable.ToString());
                RankMasterBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }

            if (data == "GetRM")
            {
                List<RANK_MASTER_Base_RM> lst = new List<RANK_MASTER_Base_RM>();
                lst = RankMasterBC.getdata();
                jstring = JsonConvert.SerializeObject(lst);
            }

            if (data == "GetRMByID")
            {
                RANK_MASTER_Base_RM lst = new RANK_MASTER_Base_RM();
                int RankID = Convert.ToInt32(postdata.RankID.ToString());
                lst = RankMasterBC.getdata(RankID);
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