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
    
    public partial class RANK_CLASS
    {
        public RANK_CLASS()
        {
            this.EMPLOYEE_CLIENT = new HashSet<EMPLOYEE_CLIENT>();
        }
    
        public int RCID { get; set; }
        public Nullable<int> RANKID { get; set; }
        public Nullable<int> CLASSID { get; set; }
        public string Class_Type { get; set; }
    
        public virtual CLASS CLASS { get; set; }
        public virtual ICollection<EMPLOYEE_CLIENT> EMPLOYEE_CLIENT { get; set; }
        public virtual RANK_MASTER RANK_MASTER { get; set; }
    }
}