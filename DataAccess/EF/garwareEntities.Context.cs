﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class thesynaxis123_garwareEntities : DbContext
    {
        public thesynaxis123_garwareEntities()
            : base("name=thesynaxis123_garwareEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADDRESSEE_MASTER> ADDRESSEE_MASTER { get; set; }
        public virtual DbSet<AREA_OPERATION_MASTER> AREA_OPERATION_MASTER { get; set; }
        public virtual DbSet<aspnet_UsersInRoles> aspnet_UsersInRoles { get; set; }
        public virtual DbSet<BANK_MASTER> BANK_MASTER { get; set; }
        public virtual DbSet<BRANCH_DETAILS> BRANCH_DETAILS { get; set; }
        public virtual DbSet<CATEGORY> CATEGORies { get; set; }
        public virtual DbSet<CERTIFICATE_MASTER> CERTIFICATE_MASTER { get; set; }
        public virtual DbSet<CERTIFICATE_TYPE_MASTER> CERTIFICATE_TYPE_MASTER { get; set; }
        public virtual DbSet<CLASS> CLASSes { get; set; }
        public virtual DbSet<CLIENT_COMMENT> CLIENT_COMMENT { get; set; }
        public virtual DbSet<CLIENT_USER> CLIENT_USER { get; set; }
        public virtual DbSet<COMMENT> COMMENTs { get; set; }
        public virtual DbSet<COMPANY_BRANCH> COMPANY_BRANCH { get; set; }
        public virtual DbSet<COMPANY_PARAMETER> COMPANY_PARAMETER { get; set; }
        public virtual DbSet<CURRENCY_MASTER> CURRENCY_MASTER { get; set; }
        public virtual DbSet<DG_CERTIFIED_DOCTORS> DG_CERTIFIED_DOCTORS { get; set; }
        public virtual DbSet<DOCUMENTS_MASTER> DOCUMENTS_MASTER { get; set; }
        public virtual DbSet<DOCUMENTS_TYPE> DOCUMENTS_TYPE { get; set; }
        public virtual DbSet<DUTY_TYPE_MASTER> DUTY_TYPE_MASTER { get; set; }
        public virtual DbSet<EMP_BRANCH> EMP_BRANCH { get; set; }
        public virtual DbSet<EMP_EXPERIENCE> EMP_EXPERIENCE { get; set; }
        public virtual DbSet<EMP_FIXED> EMP_FIXED { get; set; }
        public virtual DbSet<EMPLOYEE_CLIENT> EMPLOYEE_CLIENT { get; set; }
        public virtual DbSet<EMPLOYEE_STATUS> EMPLOYEE_STATUS { get; set; }
        public virtual DbSet<KIN_DETAILS> KIN_DETAILS { get; set; }
        public virtual DbSet<MARITIME_HOLIDAY> MARITIME_HOLIDAY { get; set; }
        public virtual DbSet<OTHER_INCOME> OTHER_INCOME { get; set; }
        public virtual DbSet<PERSONNEL_MASTER> PERSONNEL_MASTER { get; set; }
        public virtual DbSet<PORT_MASTER> PORT_MASTER { get; set; }
        public virtual DbSet<RANK_CLASS> RANK_CLASS { get; set; }
        public virtual DbSet<RELATIONSHIP_MASTER> RELATIONSHIP_MASTER { get; set; }
        public virtual DbSet<RELIGION> RELIGIONs { get; set; }
        public virtual DbSet<SALUTATION> SALUTATIONs { get; set; }
        public virtual DbSet<SECTION_LIMIT> SECTION_LIMIT { get; set; }
        public virtual DbSet<SELECTION_STATUS_MASTER> SELECTION_STATUS_MASTER { get; set; }
        public virtual DbSet<SHIP_MASTER> SHIP_MASTER { get; set; }
        public virtual DbSet<SHIP_MOVEMENT> SHIP_MOVEMENT { get; set; }
        public virtual DbSet<SHIP_TYPE_MASTER> SHIP_TYPE_MASTER { get; set; }
        public virtual DbSet<ShipAgreement> ShipAgreements { get; set; }
        public virtual DbSet<SHORE_PASS_MASTER> SHORE_PASS_MASTER { get; set; }
        public virtual DbSet<TAX_CODE> TAX_CODE { get; set; }
        public virtual DbSet<TAX_SLAB> TAX_SLAB { get; set; }
        public virtual DbSet<vw_EmployeeDetails> vw_EmployeeDetails { get; set; }
        public virtual DbSet<vw_UserDetails> vw_UserDetails { get; set; }
        public virtual DbSet<vw_UserRoleDetails> vw_UserRoleDetails { get; set; }
        public virtual DbSet<CLIENT_MASTER> CLIENT_MASTER { get; set; }
        public virtual DbSet<COUNTRY_MASTER> COUNTRY_MASTER { get; set; }
        public virtual DbSet<ACCOUNT_MASTER> ACCOUNT_MASTER { get; set; }
        public virtual DbSet<EARNING_DEDUCTION_MASTER> EARNING_DEDUCTION_MASTER { get; set; }
        public virtual DbSet<RULE1> RULE1 { get; set; }
        public virtual DbSet<RULE0> RULE0 { get; set; }
        public virtual DbSet<RULE2> RULE2 { get; set; }
        public virtual DbSet<RULE3> RULE3 { get; set; }
        public virtual DbSet<RULE4> RULE4 { get; set; }
        public virtual DbSet<RULE5> RULE5 { get; set; }
        public virtual DbSet<RULE6> RULE6 { get; set; }
        public virtual DbSet<RULE7> RULE7 { get; set; }
        public virtual DbSet<RULE8> RULE8 { get; set; }
        public virtual DbSet<RULE9> RULE9 { get; set; }
        public virtual DbSet<MAIN_TABLE> MAIN_TABLE { get; set; }
        public virtual DbSet<PAGE_MASTER> PAGE_MASTER { get; set; }
        public virtual DbSet<PAGE_PERMISSION> PAGE_PERMISSION { get; set; }
        public virtual DbSet<NON_RECOVERY> NON_RECOVERY { get; set; }
        public virtual DbSet<SHIP_MOVEMENT_REGISTER> SHIP_MOVEMENT_REGISTER { get; set; }
        public virtual DbSet<WITHHELD_REFUND> WITHHELD_REFUND { get; set; }
        public virtual DbSet<ACTUAL_SAVINGS> ACTUAL_SAVINGS { get; set; }
        public virtual DbSet<GRATUITY_REMIT> GRATUITY_REMIT { get; set; }
        public virtual DbSet<MISC_TAXABLE_INCOME> MISC_TAXABLE_INCOME { get; set; }
        public virtual DbSet<PF_REMIT> PF_REMIT { get; set; }
        public virtual DbSet<WITHHELD_TRANSFER> WITHHELD_TRANSFER { get; set; }
        public virtual DbSet<AGREEMENT_DETAILS> AGREEMENT_DETAILS { get; set; }
        public virtual DbSet<AEDCODE> AEDCODEs { get; set; }
        public virtual DbSet<RANK_MASTER> RANK_MASTER { get; set; }
    
        public virtual ObjectResult<sp_GetUserIdForMailsend_Result> sp_GetUserIdForMailsend(Nullable<int> empID)
        {
            var empIDParameter = empID.HasValue ?
                new ObjectParameter("EmpID", empID) :
                new ObjectParameter("EmpID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetUserIdForMailsend_Result>("sp_GetUserIdForMailsend", empIDParameter);
        }
    }
}
