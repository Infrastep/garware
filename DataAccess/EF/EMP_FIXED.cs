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
    
    public partial class EMP_FIXED
    {
        public EMP_FIXED()
        {
            this.CERTIFICATE_MASTER = new HashSet<CERTIFICATE_MASTER>();
            this.CLIENT_COMMENT = new HashSet<CLIENT_COMMENT>();
            this.CLIENT_COMMENT1 = new HashSet<CLIENT_COMMENT>();
            this.CLIENT_COMMENT2 = new HashSet<CLIENT_COMMENT>();
            this.CLIENT_USER = new HashSet<CLIENT_USER>();
            this.COMMENTs = new HashSet<COMMENT>();
            this.COMMENTs1 = new HashSet<COMMENT>();
            this.COMMENTs2 = new HashSet<COMMENT>();
            this.DOCUMENTS_MASTER = new HashSet<DOCUMENTS_MASTER>();
            this.EMP_BRANCH = new HashSet<EMP_BRANCH>();
            this.EMP_EXPERIENCE = new HashSet<EMP_EXPERIENCE>();
            this.EMPLOYEE_CLIENT = new HashSet<EMPLOYEE_CLIENT>();
            this.EMPLOYEE_STATUS = new HashSet<EMPLOYEE_STATUS>();
            this.EMPLOYEE_STATUS1 = new HashSet<EMPLOYEE_STATUS>();
            this.KIN_DETAILS = new HashSet<KIN_DETAILS>();
            this.NON_RECOVERY = new HashSet<NON_RECOVERY>();
            this.WITHHELD_REFUND = new HashSet<WITHHELD_REFUND>();
            this.ACTUAL_SAVINGS = new HashSet<ACTUAL_SAVINGS>();
            this.MISC_TAXABLE_INCOME = new HashSet<MISC_TAXABLE_INCOME>();
            this.WITHHELD_TRANSFER = new HashSet<WITHHELD_TRANSFER>();
            this.AGREEMENT_DETAILS = new HashSet<AGREEMENT_DETAILS>();
        }
    
        public int EMPID { get; set; }
        public Nullable<int> STATUS { get; set; }
        public Nullable<bool> SR_CITIZEN { get; set; }
        public string EMP_CODE { get; set; }
        public string EMP_NAME { get; set; }
        public string NAME_PREFIX { get; set; }
        public string ADDR_PRMNT1 { get; set; }
        public string ADDR_PRMNT2 { get; set; }
        public string ADDR_PRMNT3 { get; set; }
        public string TELEPHONE_PRMNT { get; set; }
        public string ADDR_PRESENT1 { get; set; }
        public string ADDR_PRESENT2 { get; set; }
        public string ADDR_PRESENT3 { get; set; }
        public string TELEPHONE_PRESENT { get; set; }
        public string FATHER_NAME { get; set; }
        public string SEX { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string BIRTH_PLACE { get; set; }
        public Nullable<int> NATIONALITY { get; set; }
        public string FAX { get; set; }
        public string MOBILE { get; set; }
        public string EMAIL { get; set; }
        public Nullable<int> RELIGIONID { get; set; }
        public string PHOTO { get; set; }
        public Nullable<System.Guid> ASP_USER_DETAILS { get; set; }
        public Nullable<bool> ALEVELVERIFY { get; set; }
        public Nullable<bool> BLEVELVERIFY { get; set; }
        public Nullable<bool> CLEVELVERIFY { get; set; }
        public Nullable<bool> SIGNINGAUTH { get; set; }
        public string DESIGNATION { get; set; }
    
        public virtual ICollection<CERTIFICATE_MASTER> CERTIFICATE_MASTER { get; set; }
        public virtual ICollection<CLIENT_COMMENT> CLIENT_COMMENT { get; set; }
        public virtual ICollection<CLIENT_COMMENT> CLIENT_COMMENT1 { get; set; }
        public virtual ICollection<CLIENT_COMMENT> CLIENT_COMMENT2 { get; set; }
        public virtual ICollection<CLIENT_USER> CLIENT_USER { get; set; }
        public virtual ICollection<COMMENT> COMMENTs { get; set; }
        public virtual ICollection<COMMENT> COMMENTs1 { get; set; }
        public virtual ICollection<COMMENT> COMMENTs2 { get; set; }
        public virtual ICollection<DOCUMENTS_MASTER> DOCUMENTS_MASTER { get; set; }
        public virtual ICollection<EMP_BRANCH> EMP_BRANCH { get; set; }
        public virtual ICollection<EMP_EXPERIENCE> EMP_EXPERIENCE { get; set; }
        public virtual RELIGION RELIGION { get; set; }
        public virtual SELECTION_STATUS_MASTER SELECTION_STATUS_MASTER { get; set; }
        public virtual ICollection<EMPLOYEE_CLIENT> EMPLOYEE_CLIENT { get; set; }
        public virtual ICollection<EMPLOYEE_STATUS> EMPLOYEE_STATUS { get; set; }
        public virtual ICollection<EMPLOYEE_STATUS> EMPLOYEE_STATUS1 { get; set; }
        public virtual ICollection<KIN_DETAILS> KIN_DETAILS { get; set; }
        public virtual COUNTRY_MASTER COUNTRY_MASTER { get; set; }
        public virtual ICollection<NON_RECOVERY> NON_RECOVERY { get; set; }
        public virtual ICollection<WITHHELD_REFUND> WITHHELD_REFUND { get; set; }
        public virtual ICollection<ACTUAL_SAVINGS> ACTUAL_SAVINGS { get; set; }
        public virtual ICollection<MISC_TAXABLE_INCOME> MISC_TAXABLE_INCOME { get; set; }
        public virtual ICollection<WITHHELD_TRANSFER> WITHHELD_TRANSFER { get; set; }
        public virtual ICollection<AGREEMENT_DETAILS> AGREEMENT_DETAILS { get; set; }
    }
}