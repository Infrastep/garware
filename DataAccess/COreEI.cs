using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.EF;

namespace DataAccess
{
    public class COreEI : IDisposable
    {
        protected thesynaxis123_garwareEntities db1 { get; set; }
        public COreEI()
        {
            db1 = new thesynaxis123_garwareEntities();         

        }
        public void CommitChanges()
        {
            try
            {
                db1.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
