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
    
    public partial class CLASS
    {
        public CLASS()
        {
            this.RANK_CLASS = new HashSet<RANK_CLASS>();
        }
    
        public int CLASSID { get; set; }
        public string CLASS_NAME { get; set; }
        public Nullable<bool> ACTIVE { get; set; }
        public string CLASS_TYPE { get; set; }
        public Nullable<bool> COST_TO_COMP { get; set; }
        public Nullable<short> CATEGORYID { get; set; }
    
        public virtual ICollection<RANK_CLASS> RANK_CLASS { get; set; }
        public virtual CLASS CLASS1 { get; set; }
        public virtual CLASS CLASS2 { get; set; }
    }
}
