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
    
    public partial class PAGE_MASTER
    {
        public PAGE_MASTER()
        {
            this.PAGE_PERMISSION = new HashSet<PAGE_PERMISSION>();
        }
    
        public int PAGEID { get; set; }
        public string PAGENAME { get; set; }
    
        public virtual ICollection<PAGE_PERMISSION> PAGE_PERMISSION { get; set; }
    }
}
