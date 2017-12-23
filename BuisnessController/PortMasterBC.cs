using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class PortMasterBC
    {

        public static PORT_MASTER_Base insertupdateData(PORT_MASTER_Base obj)
        {
            PORT_MASTERDL ed = new PORT_MASTERDL();
            return ed.insertdata(obj);
        }

        public static List<PORT_MASTER_Base> getdata()
        {
            PORT_MASTERDL ed = new PORT_MASTERDL();
            return ed.getdata();
        }


    }
}
