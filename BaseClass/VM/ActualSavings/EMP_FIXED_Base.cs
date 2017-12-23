﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass.VM.ActualSavings
{
   public class EMP_FIXED_Base_ACS
    {  
       

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

       
    }
}
