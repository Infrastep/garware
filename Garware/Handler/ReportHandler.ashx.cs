using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;
using Newtonsoft.Json;
using System.Configuration;

namespace Garware.Handler
{
    /// <summary>
    /// Summary description for ReportHandler
    /// </summary>
    public class ReportHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string ReportPath = string.Empty;
            string SelectionFormula = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = context.Request.QueryString["Method"];// postdata.Method.ToString();
            ReportPath = ConfigurationManager.AppSettings["Reportpath"] + data + ".rpt";


            switch (data)
            {
                case "Allotment_Report":

                  
                    SelectionFormula = "{EMP_FIXED.EMPID}=" + Convert.ToInt32(context.Request.QueryString["id"]);
           
                    break;

                case "Gratuity_Letter":


                    SelectionFormula = "{PF_REMIT.GRATUITY_REMITID}=" + Convert.ToInt32(context.Request.QueryString["id"]);

                    break;
                case "PF_Letter":


                    SelectionFormula = "{PF_REMIT.PF_REMIT_ID}=" + Convert.ToInt32(context.Request.QueryString["id"]);

                    break;

                    case "employee_list":

                    string _rank = string.Empty;
                    if (context.Request.QueryString["Rank"] == "")
                        _rank = "{RANK_MASTER.RANKID}in [{RANK_MASTER.RANKID}]";
                    else
                        _rank = "{RANK_MASTER.RANKID} in[" + context.Request.QueryString["Rank"] + "]";

                    string _dt = string.Empty;
                    if (context.Request.QueryString["Dt"] == "")
                        _dt = "{DUTY_TYPE_MASTER.ID} in[{DUTY_TYPE_MASTER.ID}]";
                    else
                        _dt = "{DUTY_TYPE_MASTER.ID} in[" + context.Request.QueryString["Dt"] + "] ";

                                        string _shp = string.Empty;
                    if (context.Request.QueryString["shp"] == "")
                        _shp = "{SHIP_MASTER.SMID} in[{SHIP_MASTER.SMID}]";
                    else
                        _shp = "{SHIP_MASTER.SMID} in[" + context.Request.QueryString["shp"] + "] ";

                     SelectionFormula = _rank + " and "+_dt+" and "+ _shp;
                    break;

            }
           
         

            context.Response.Write(ReportPath);
            BinaryReader stream = CrystalToPdf(ReportPath, SelectionFormula);
            context.Response.ClearContent();
            context.Response.ClearHeaders();            
            context.Response.ContentType = "application/pdf";
            var bt = stream.ReadBytes(Convert.ToInt32(stream.BaseStream.Length));
            context.Response.BinaryWrite(bt);
            context.Response.Flush();
            context.Response.Close();

        }

        public BinaryReader CrystalToPdf(string ReportPath, string SelectionFormula)
        {
            try
            {

                ReportDocument doc = new ReportDocument();
                     
                doc.Load(ReportPath);
                doc.RecordSelectionFormula = SelectionFormula;
                doc.SetDatabaseLogon("sa", "JoydeepS@123", "192.169.244.76,49294", "fsmanning", true);
                doc.Refresh();
                ExportOptions CrExportOptions;
                CrExportOptions = doc.ExportOptions;
                CrystalDecisions.Shared.ExportRequestContext MyExportRequestContext = new ExportRequestContext();
                CrExportOptions.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat;
                MyExportRequestContext.ExportInfo = CrExportOptions;


                BinaryReader MyStream =new BinaryReader ( doc.FormatEngine.ExportToStream(MyExportRequestContext));

                doc.Close();

                doc.Dispose();
                return MyStream;
              

            }
            catch (Exception ex)
            {
                return null;
            }
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