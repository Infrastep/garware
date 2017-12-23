using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class TaxCodeBC
    {

        public static TAX_CODE_Base insertupdateData(TAX_CODE_Base obj)
        {
            TAX_CODEDL ed = new TAX_CODEDL();
            return ed.insertdata(obj);
        }

        public static List<TAX_CODE_Base> getdata()
        {
            TAX_CODEDL ed = new TAX_CODEDL();
            return ed.getdata();
        }

    }
}
