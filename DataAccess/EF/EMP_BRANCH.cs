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
    
    public partial class EMP_BRANCH
    {
        public int EBID { get; set; }
        public Nullable<int> BRANCHID { get; set; }
        public Nullable<int> EMPID { get; set; }
        public string BANK_AC_NO_NRE { get; set; }
        public string BANK_NAME_NRE { get; set; }
        public string BANK_ADDRESS_NRE { get; set; }
        public string CHEQUE_NAME { get; set; }
        public string IFSC_CODE_NRE { get; set; }
        public Nullable<bool> NOT_PF { get; set; }
    
        public virtual BRANCH_DETAILS BRANCH_DETAILS { get; set; }
        public virtual EMP_FIXED EMP_FIXED { get; set; }
    }
}