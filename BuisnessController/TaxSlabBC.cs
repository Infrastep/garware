using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class TaxSlabBC
    {

        public static TAX_SLAB_Base insertupdateData(TAX_SLAB_Base obj)
        {
            TAX_SLABDL ed = new TAX_SLABDL();
            return ed.insertdata(obj);
        }

        public static List<TAX_SLAB_Base> getdata()
        {
            TAX_SLABDL ed = new TAX_SLABDL();
            return ed.getdata();
        }



    }
}
