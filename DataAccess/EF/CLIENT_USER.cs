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
    
    public partial class CLIENT_USER
    {
        public int CLIENTUSERID { get; set; }
        public Nullable<int> CLIENTID { get; set; }
        public Nullable<int> USERID { get; set; }
    
        public virtual EMP_FIXED EMP_FIXED { get; set; }
        public virtual CLIENT_MASTER CLIENT_MASTER { get; set; }
    }
}
