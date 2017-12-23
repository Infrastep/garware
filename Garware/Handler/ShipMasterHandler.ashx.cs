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
    /// Summary description for ShipMasterHandler
    /// </summary>
    public class ShipMasterHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            if (data == "InsertSM")
            {
                SHIP_MASTER_Base obj = new SHIP_MASTER_Base();
                obj.SMID = Convert.ToInt32(postdata.id.ToString());
                obj.VNAME = Convert.ToString(postdata.name.ToString());
                obj.PORT_REG_TRADE = Convert.ToString(postdata.port.ToString());
                obj.AREA_OF_OPERATION = Convert.ToString(postdata.trade.ToString());
                obj.OFFICIAL_NO = Convert.ToString(postdata.offno.ToString());
                obj.GT_POWER = Convert.ToString(postdata.gt.ToString());
                obj.NO_OF_CREW = Convert.ToInt32(postdata.crew.ToString());
                obj.NRT = Convert.ToInt32(postdata.nrt.ToString());
               
                obj.OFF_IMO_NO = Convert.ToString(postdata.imo.ToString());
                obj.POWER_KW_BHP = Convert.ToString(postdata.power.ToString());                
                obj.TYPEID = Convert.ToInt32(postdata.type.ToString());                
                obj.COUNTRY_FLAG = Convert.ToInt32(postdata.country.ToString());
                obj.CLIENT_ID = Convert.ToInt32(postdata.client.ToString());
                obj.PHOTO = Convert.ToString(postdata.photo.ToString()); 
                obj.ADD_BY = "";
                obj.EDIT_BY = "";
                obj.ADD_TIME = DateTime.Now;
                obj.EDIT_TIME = DateTime.Now;
                obj.STATUS = Convert.ToBoolean(postdata.status.ToString()); 
                ShipMasterBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }
            if (data == "GetSM")
            {
                List<SHIP_MASTER_Base> lst = new List<SHIP_MASTER_Base>();
                lst = ShipMasterBC.getdata();
                jstring = JsonConvert.SerializeObject(lst);
            }
            if (data == "GetSMC")
            {
                List<SHIP_MASTER_Base> lst = new List<SHIP_MASTER_Base>();
                int CLIENT_ID = Convert.ToInt32(postdata.client.ToString());
                lst = ShipMasterBC.getdatabyclientid(CLIENT_ID);
                jstring = JsonConvert.SerializeObject(lst);
            }
            if (data == "GetSMByID")
            {
                SHIP_MASTER_Base lst = new SHIP_MASTER_Base();
                int ShipID = Convert.ToInt32(postdata.ShipID.ToString());
                lst = ShipMasterBC.getdata(ShipID);
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