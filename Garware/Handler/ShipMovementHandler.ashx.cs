using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseClass.VM.ShipMovement;
using BuisnessController;
using Newtonsoft.Json;

namespace Garware.Handler
{
    /// <summary>
    /// Summary description for ShipAgreementMasterHandler
    /// </summary>
    public class ShipMovementHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            switch (data)
            {
                case "InsertUpdate":

                    SHIP_MOVEMENT_Base_SM obj = new SHIP_MOVEMENT_Base_SM();
                    obj.ID = Convert.ToInt32(postdata.id.ToString());
                    obj.COUNTRY_ID = Convert.ToInt32(postdata.CountryId.ToString());
                    obj.START_DATE  = Convert.ToDateTime(postdata.Startdate.ToString());
                    obj.END_DATE = Convert.ToDateTime(postdata.Enddate.ToString());
                    obj.SHIP_ID  = Convert.ToInt16(postdata.ShipId.ToString());



                    jstring = JsonConvert.SerializeObject(SHIP_MOVEMENTBC.insertupdateData(obj));
                    break;

                case "Getdata":

                    jstring = JsonConvert.SerializeObject(SHIP_MOVEMENTBC.getdata());
                    break;
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