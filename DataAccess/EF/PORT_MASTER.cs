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
    
    public partial class PORT_MASTER
    {
        public int PID { get; set; }
        public string PortName { get; set; }
        public string CCODE { get; set; }
        public Nullable<int> Country { get; set; }
        public string addby { get; set; }
        public string editby { get; set; }
        public Nullable<System.DateTime> addtime { get; set; }
        public Nullable<System.DateTime> editime { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public Nullable<bool> status { get; set; }
    
        public virtual COUNTRY_MASTER COUNTRY_MASTER { get; set; }
    }
}
