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
    
    public partial class SHIP_MOVEMENT
    {
        public int ID { get; set; }
        public Nullable<int> SHIP_ID { get; set; }
        public Nullable<int> COUNTRY_ID { get; set; }
        public Nullable<System.DateTime> START_DATE { get; set; }
        public Nullable<System.DateTime> END_DATE { get; set; }
    
        public virtual SHIP_MASTER SHIP_MASTER { get; set; }
        public virtual COUNTRY_MASTER COUNTRY_MASTER { get; set; }
    }
}