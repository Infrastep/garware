using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaseClass
{
   public class RANK_MASTER_Base
    {

       public RANK_MASTER_Base()
        {
            this.RANK_CLASS = new HashSet<RANK_CLASS_Base>();
        }

       public int RANKID { get; set; }
       public string RANK_DESC { get; set; }
       public Nullable<int> CATEGORYID { get; set; }
       public Nullable<bool> Active { get; set; }
       public string Withheld_Perc_NRI { get; set; }
       public Nullable<int> Print_order { get; set; }
       public Nullable<bool> Pf_Applicable { get; set; }
    
       public virtual CATEGORY_Base CATEGORY { get; set; }
       public virtual ICollection<RANK_CLASS_Base> RANK_CLASS { get; set; }


    }
}
