//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class COMPANY_PARAMETER
    {
        public COMPANY_PARAMETER()
        {
            this.ADDRESSEE_MASTER = new HashSet<ADDRESSEE_MASTER>();
            this.COMPANY_BRANCH = new HashSet<COMPANY_BRANCH>();
        }
    
        public int COMPANYID { get; set; }
        public string COMPANY_NAME { get; set; }
        public string PHONE { get; set; }
        public string FAX_NO { get; set; }
        public string EMAIL { get; set; }
        public string SERVICE_TAX_NO { get; set; }
        public string PAN_NO { get; set; }
        public string COMPANY_LOGO { get; set; }
        public Nullable<bool> STATUS { get; set; }
    
        public virtual ICollection<ADDRESSEE_MASTER> ADDRESSEE_MASTER { get; set; }
        public virtual ICollection<COMPANY_BRANCH> COMPANY_BRANCH { get; set; }
    }
}