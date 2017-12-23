using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class ReligionMasterBC
    {


        public static RELIGION_Base insertupdateData(RELIGION_Base obj)
        {
            RELIGIONDL ed = new RELIGIONDL();
            return ed.insertdata(obj);
        }

        public static List<RELIGION_Base> getdata()
        {
            RELIGIONDL ed = new RELIGIONDL();
            return ed.getdata();
        }



    }
}
