using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.EF;
using BaseClass;
namespace DataAccess.Infrastructure
{
    public class CERTIFICATE_TYPE_MASTERDL : COreEI
    {
        /// <summery>
        /// get all data from Address
        ///  returns List<Address>
        /// </summery>
        public List<CERTIFICATE_TYPE_MASTER_Base> getdata()
        {

            List<CERTIFICATE_TYPE_MASTER> dr = db1.CERTIFICATE_TYPE_MASTER.ToList();
            List<CERTIFICATE_TYPE_MASTER_Base> drb = generate_Base(dr);
            return drb;

        }

        public CERTIFICATE_TYPE_MASTER_Base getdata(int id)
        {

            CERTIFICATE_TYPE_MASTER dr = db1.CERTIFICATE_TYPE_MASTER.Where(q => q.CTID == id).Single();
            CERTIFICATE_TYPE_MASTER_Base STM = generate_Base(dr);
            return STM;


        }
        
        public CERTIFICATE_TYPE_MASTER_Base insertdata(CERTIFICATE_TYPE_MASTER_Base dr)
        {
            int id = dr.CTID;
            if (id != 0)
            {
                CERTIFICATE_TYPE_MASTER result = db1.CERTIFICATE_TYPE_MASTER.Where(q => q.CTID == id).Single();
                if (result != null)
                {
                    result.CTID = dr.CTID;
                    result.CT_DESC = dr.CT_DESC;
                    result.STATUS = dr.STATUS;
                  
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                CERTIFICATE_TYPE_MASTER result = new CERTIFICATE_TYPE_MASTER();

                result.CT_DESC = dr.CT_DESC;
                result.STATUS = dr.STATUS;
                db1.CERTIFICATE_TYPE_MASTER.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static CERTIFICATE_TYPE_MASTER_Base generate_Base(CERTIFICATE_TYPE_MASTER dr)
        {

            CERTIFICATE_TYPE_MASTER_Base drb = new CERTIFICATE_TYPE_MASTER_Base();
            if (dr != null)
            {
                drb.CTID = dr.CTID;
                drb.CT_DESC = dr.CT_DESC;
                drb.STATUS = dr.STATUS;

            }
            return drb;
        }

        public static List<CERTIFICATE_TYPE_MASTER_Base> generate_Base(ICollection<CERTIFICATE_TYPE_MASTER> i)
        {
            List<CERTIFICATE_TYPE_MASTER_Base> drbl = new List<CERTIFICATE_TYPE_MASTER_Base>();
            int x = 0;
            foreach (CERTIFICATE_TYPE_MASTER dr in i)
            {
                CERTIFICATE_TYPE_MASTER_Base drb = new CERTIFICATE_TYPE_MASTER_Base();
                drb.CTID = dr.CTID;
                drb.CT_DESC = dr.CT_DESC;
                drb.STATUS = dr.STATUS;

                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
