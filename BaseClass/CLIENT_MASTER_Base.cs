using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class CLIENT_MASTER_Base
    {
       
        public int CLIENTID { get; set; }
        public string CLIENT_NAME { get; set; }
        public string DATABASE_NAME { get; set; }
        public string DATABASE_HOST { get; set; }
        public string DATABASE_UID { get; set; }
        public string DATABASE_PASS { get; set; }
        public string ADDRESS { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string PIN { get; set; }
        public string PHONE { get; set; }
        public string FAX_NO { get; set; }
        public string EMAIL { get; set; }
        public string SERVICE_TAX_NO { get; set; }
        public string PICTURE { get; set; }

        public Nullable<int> COUNTRY_ID { get; set; }
        public string CIN_NO { get; set; }
        public string PAN { get; set; }
        public string TAN { get; set; }
        public string WEBSITE { get; set; }
        public string DESCRIPTION { get; set; }
        public string CLIENT_LOGO { get; set; }
        public Nullable<bool> STATUS { get; set; }

        public virtual COUNTRY_MASTER_Base COUNTRY_MASTER { get; set; }
       
    }
}
