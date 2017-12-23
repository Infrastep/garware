using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
using BaseClass.VM.RankMaster;
namespace BuisnessController
{
    public class RankMasterBC
    {

        public static RANK_MASTER_Base_RM insertupdateData(RANK_MASTER_Base_RM obj)
        {
            RANK_MASTERDL ed = new RANK_MASTERDL();
            return ed.insertdata(obj);
        }

        public static List<RANK_MASTER_Base_RM> getdata()
        {
            RANK_MASTERDL ed = new RANK_MASTERDL();
            return ed.getdata();
        }
        public static RANK_MASTER_Base_RM getdata(int id)
        {
            RANK_MASTERDL ed = new RANK_MASTERDL();
            return ed.getdata(id);
        }

    }
}
