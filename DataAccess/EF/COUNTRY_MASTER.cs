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
    
    public partial class COUNTRY_MASTER
    {
        public COUNTRY_MASTER()
        {
            this.ADDRESSEE_MASTER = new HashSet<ADDRESSEE_MASTER>();
            this.BRANCH_DETAILS = new HashSet<BRANCH_DETAILS>();
            this.CERTIFICATE_MASTER = new HashSet<CERTIFICATE_MASTER>();
            this.DG_CERTIFIED_DOCTORS = new HashSet<DG_CERTIFIED_DOCTORS>();
            this.DOCUMENTS_MASTER = new HashSet<DOCUMENTS_MASTER>();
            this.EMP_FIXED = new HashSet<EMP_FIXED>();
            this.KIN_DETAILS = new HashSet<KIN_DETAILS>();
            this.PORT_MASTER = new HashSet<PORT_MASTER>();
            this.SHIP_MASTER = new HashSet<SHIP_MASTER>();
            this.SHIP_MOVEMENT = new HashSet<SHIP_MOVEMENT>();
            this.CLIENT_MASTER = new HashSet<CLIENT_MASTER>();
        }
    
        public int CID { get; set; }
        public string C_Name { get; set; }
        public string CCODE { get; set; }
        public string add_by { get; set; }
        public Nullable<System.DateTime> add_time { get; set; }
        public string Edit_by { get; set; }
        public Nullable<System.DateTime> Edit_time { get; set; }
        public Nullable<bool> status { get; set; }
    
        public virtual ICollection<ADDRESSEE_MASTER> ADDRESSEE_MASTER { get; set; }
        public virtual ICollection<BRANCH_DETAILS> BRANCH_DETAILS { get; set; }
        public virtual ICollection<CERTIFICATE_MASTER> CERTIFICATE_MASTER { get; set; }
        public virtual ICollection<DG_CERTIFIED_DOCTORS> DG_CERTIFIED_DOCTORS { get; set; }
        public virtual ICollection<DOCUMENTS_MASTER> DOCUMENTS_MASTER { get; set; }
        public virtual ICollection<EMP_FIXED> EMP_FIXED { get; set; }
        public virtual ICollection<KIN_DETAILS> KIN_DETAILS { get; set; }
        public virtual ICollection<PORT_MASTER> PORT_MASTER { get; set; }
        public virtual ICollection<SHIP_MASTER> SHIP_MASTER { get; set; }
        public virtual ICollection<SHIP_MOVEMENT> SHIP_MOVEMENT { get; set; }
        public virtual ICollection<CLIENT_MASTER> CLIENT_MASTER { get; set; }
    }
}
