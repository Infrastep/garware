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
    
    public partial class COMPANY_BRANCH
    {
        public int CBID { get; set; }
        public Nullable<int> BRANCHID { get; set; }
        public Nullable<int> COMPANYID { get; set; }
        public string CHEQUE_NAME { get; set; }
    
        public virtual BRANCH_DETAILS BRANCH_DETAILS { get; set; }
        public virtual COMPANY_PARAMETER COMPANY_PARAMETER { get; set; }
    }
}
