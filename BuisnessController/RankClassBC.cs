using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class RankClassBC
    {

        public static RANK_CLASS_Base insertupdateData(RANK_CLASS_Base obj)
        {
            RANK_CLASSDL ed = new RANK_CLASSDL();
            return ed.insertdata(obj);
        }

        public static List<RANK_CLASS_Base> getdata()
        {
            RANK_CLASSDL ed = new RANK_CLASSDL();
            return ed.getdata();
        }

    }
}
