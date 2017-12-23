using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class SectionLimitBC
    {

        public static SECTION_LIMIT_Base insertupdateData(SECTION_LIMIT_Base obj)
        {
            SECTION_LIMITDL ed = new SECTION_LIMITDL();
            return ed.insertdata(obj);
        }

        public static List<SECTION_LIMIT_Base> getdata()
        {
            SECTION_LIMITDL ed = new SECTION_LIMITDL();
            return ed.getdata();
        }

    }
}
