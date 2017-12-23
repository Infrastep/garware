using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
    public class ASPNET_USER_Base
    {
        public ASPNET_USER_Base()
        {
            this.EMP_FIXED = new HashSet<EMP_FIXED_Base>();
            this.aspnet_Roles = new HashSet<ASPNET_ROLES_Base>();
        }
    
        public System.Guid ApplicationId { get; set; }
        public System.Guid UserId { get; set; }
        public string UserName { get; set; }
        public string LoweredUserName { get; set; }
        public string MobileAlias { get; set; }
        public bool IsAnonymous { get; set; }
        public System.DateTime LastActivityDate { get; set; }

        public virtual ICollection<EMP_FIXED_Base> EMP_FIXED { get; set; }
        public virtual ICollection<ASPNET_ROLES_Base> aspnet_Roles { get; set; }
    }
}
