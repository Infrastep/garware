using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class EMP_FIXED_Base
    {
       public EMP_FIXED_Base()
        {
            this.CERTIFICATE_MASTER = new HashSet<CERTIFICATE_MASTER_Base>();
            this.DOCUMENTS_MASTER = new HashSet<DOCUMENTS_MASTER_Base>();
            this.EMP_BRANCH = new HashSet<EMP_BRANCH_Base>();
            this.EMP_EXPERIENCE = new HashSet<EMP_EXPERIENCE_Base>();
            this.CLIENT_COMMENT = new HashSet<CLIENT_COMMENT_Base>();
            this.CLIENT_COMMENT1 = new HashSet<CLIENT_COMMENT_Base>();
            this.CLIENT_COMMENT2 = new HashSet<CLIENT_COMMENT_Base>();
            this.CLIENT_USER = new HashSet<CLIENT_USER_Base>();
            this.COMMENTs = new HashSet<COMMENT_Base>();
            this.COMMENTs1 = new HashSet<COMMENT_Base>();
            this.COMMENTs2 = new HashSet<COMMENT_Base>();
            this.EMPLOYEE_CLIENT = new HashSet<EMPLOYEE_CLIENT_Base>();
            this.EMPLOYEE_STATUS = new HashSet<EMPLOYEE_STATUS_Base>();
            this.EMPLOYEE_STATUS1 = new HashSet<EMPLOYEE_STATUS_Base>();
            this.KIN_DETAILS = new HashSet<KIN_DETAILS_Base>();
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

       public virtual ASPNET_USER_Base aspnet_Users { get; set; }
       public virtual ICollection<CERTIFICATE_MASTER_Base> CERTIFICATE_MASTER { get; set; }
       public virtual COUNTRY_MASTER_Base COUNTRY_MASTER { get; set; }
       public virtual ICollection<DOCUMENTS_MASTER_Base> DOCUMENTS_MASTER { get; set; }
       public virtual ICollection<EMP_BRANCH_Base> EMP_BRANCH { get; set; }
       public virtual ICollection<EMP_EXPERIENCE_Base> EMP_EXPERIENCE { get; set; }
       public virtual ICollection<CLIENT_COMMENT_Base> CLIENT_COMMENT { get; set; }
       public virtual ICollection<CLIENT_COMMENT_Base> CLIENT_COMMENT1 { get; set; }
       public virtual ICollection<CLIENT_COMMENT_Base> CLIENT_COMMENT2 { get; set; }
       public virtual ICollection<CLIENT_USER_Base> CLIENT_USER { get; set; }
       public virtual ICollection<COMMENT_Base> COMMENTs { get; set; }
       public virtual ICollection<COMMENT_Base> COMMENTs1 { get; set; }
       public virtual ICollection<COMMENT_Base> COMMENTs2 { get; set; }
       public virtual RELIGION_Base RELIGION { get; set; }
       public virtual SELECTION_STATUS_MASTER_Base SELECTION_STATUS_MASTER { get; set; }
       public virtual ICollection<EMPLOYEE_CLIENT_Base> EMPLOYEE_CLIENT { get; set; }
       public virtual ICollection<EMPLOYEE_STATUS_Base> EMPLOYEE_STATUS { get; set; }
       public virtual ICollection<EMPLOYEE_STATUS_Base> EMPLOYEE_STATUS1 { get; set; }
       public virtual ICollection<KIN_DETAILS_Base> KIN_DETAILS { get; set; }
    }
}
