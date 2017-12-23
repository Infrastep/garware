using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseClass;
using BuisnessController;
using Newtonsoft.Json;
using BaseClass.VM.ShipMovementRegister;
namespace Garware.Handler
{
    /// <summary>
    /// Summary description for ShipMovementRegisterHandler
    /// </summary>
    public class ShipMovementRegisterHandler : IHttpHandler
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

                    SHIP_MOVEMENT_REGISTER_Base_SMR obj = new SHIP_MOVEMENT_REGISTER_Base_SMR();
                    obj.ID = Convert.ToInt32(postdata.ID.ToString());
                    obj.SHIPCODE = Convert.ToInt32(postdata.SHIPCODE.ToString());
                    obj.WATER = Convert.ToString(postdata.WATER.ToString());
                    obj.FROM_DATE = Convert.ToDateTime(postdata.FROM_DATE.ToString());
                    obj.TO_DATE = Convert.ToDateTime(postdata.TO_DATE.ToString());
                   
                    SHIP_MOVEMENT_REGISTERBC.insertupdateData(obj);

                    jstring = JsonConvert.SerializeObject("Success");
                    break;

                case "Getdata":

                    jstring = JsonConvert.SerializeObject(SHIP_MOVEMENT_REGISTERBC.getdata());
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