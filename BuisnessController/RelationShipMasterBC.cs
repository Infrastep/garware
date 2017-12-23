using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class RelationShipMasterBC
    {

        public static RELATIONSHIP_MASTER_Base insertupdateData(RELATIONSHIP_MASTER_Base obj)
        {
            RELATIONSHIP_MASTERDL ed = new RELATIONSHIP_MASTERDL();
            return ed.insertdata(obj);
        }

        public static List<RELATIONSHIP_MASTER_Base> getdata()
        {
            RELATIONSHIP_MASTERDL ed = new RELATIONSHIP_MASTERDL();
            return ed.getdata();
        }

    }
}
