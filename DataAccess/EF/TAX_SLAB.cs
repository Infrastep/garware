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
    
    public partial class TAX_SLAB
    {
        public int ID { get; set; }
        public string TYPE { get; set; }
        public string FINANCIAL_YEAR { get; set; }
        public Nullable<decimal> FROM_AMT { get; set; }
        public Nullable<decimal> TO_AMT { get; set; }
        public Nullable<decimal> TAX_PER { get; set; }
        public Nullable<decimal> TAX_AMT { get; set; }
        public Nullable<bool> STATUS { get; set; }
    }
}
