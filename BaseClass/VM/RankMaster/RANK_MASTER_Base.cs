﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass.VM.RankMaster
{
    public class RANK_MASTER_Base_RM
    {
        public RANK_MASTER_Base_RM()
        {
            this.RANK_CLASS = new HashSet<RANK_CLASS_Base_RM>();
        }

        public int RANKID { get; set; }
        public string RANK_DESC { get; set; }
        public Nullable<int> CATEGORYID { get; set; }
        public Nullable<bool> Active { get; set; }
        public string Withheld_Perc_NRI { get; set; }
        public string Print_order { get; set; }
        public Nullable<bool> Pf_Applicable { get; set; }
        public string RANK_CODE { get; set; }

        public virtual CATEGORY_Base_RM CATEGORY { get; set; }
        public virtual ICollection<RANK_CLASS_Base_RM> RANK_CLASS { get; set; }
    }
}
