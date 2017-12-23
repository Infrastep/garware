using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
    public class BANK_MASTERDL : COreEI
    {
        /// <summery>
        /// get all data from Address
        ///  returns List<Address>
        /// </summery>
        public List<BANK_MASTER_Base> getdata()
        {

            List<BANK_MASTER> dr = db1.BANK_MASTER.ToList();
            List<BANK_MASTER_Base> drb = generate_Base(dr);
            return drb;

        }

        public BANK_MASTER_Base getdata(int id)
        {

            BANK_MASTER dr = db1.BANK_MASTER.Where(q => q.BANKID == id).Single();
            BANK_MASTER_Base STM = generate_Base(dr);
            return STM;


        }

        public BANK_MASTER_Base insertdata(BANK_MASTER_Base dr)
        {
            int id = dr.BANKID;
            if (id != 0)
            {
                BANK_MASTER result = db1.BANK_MASTER.Where(q => q.BANKID == id).Single();
                if (result != null)
                {
                    result.BANKID = dr.BANKID;
                    result.BANK_NAME = dr.BANK_NAME;
                  
                    result.BANK_CODE = dr.BANK_CODE;
                    result.ACTIVE_BANK = dr.ACTIVE_BANK;
                    result.ADD_BY = dr.ADD_BY;
                    result.ADD_TIME = dr.ADD_TIME;
                    result.EDIT_BY = dr.EDIT_BY;
                    result.EDIT_TIME = dr.EDIT_TIME;
                    


                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                BANK_MASTER result = new BANK_MASTER();

                result.BANK_NAME = dr.BANK_NAME;
               
                result.BANK_CODE = dr.BANK_CODE;
                result.ACTIVE_BANK = dr.ACTIVE_BANK;
                result.ADD_BY = dr.ADD_BY;
                result.ADD_TIME = dr.ADD_TIME;
                result.EDIT_BY = dr.EDIT_BY;
                result.EDIT_TIME = dr.EDIT_TIME;
               
                db1.BANK_MASTER.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static BANK_MASTER_Base generate_Base(BANK_MASTER dr)
        {

            BANK_MASTER_Base drb = new BANK_MASTER_Base();
            if (dr != null)
            {
                drb.BANKID = dr.BANKID;
                drb.BANK_NAME = dr.BANK_NAME;
               
                drb.BANK_CODE = dr.BANK_CODE;
                drb.ACTIVE_BANK = dr.ACTIVE_BANK;
                drb.ADD_BY = dr.ADD_BY;
                drb.ADD_TIME = dr.ADD_TIME;
                drb.EDIT_BY = dr.EDIT_BY;
                drb.EDIT_TIME = dr.EDIT_TIME;
                
            }
            return drb;
        }

        public static List<BANK_MASTER_Base> generate_Base(ICollection<BANK_MASTER> i)
        {
            List<BANK_MASTER_Base> drbl = new List<BANK_MASTER_Base>();
            int x = 0;
            foreach (BANK_MASTER dr in i)
            {
                BANK_MASTER_Base drb = new BANK_MASTER_Base();
                drb.BANKID = dr.BANKID;
                drb.BANK_NAME = dr.BANK_NAME;
               
                drb.BANK_CODE = dr.BANK_CODE;
                drb.ACTIVE_BANK = dr.ACTIVE_BANK;
                drb.ADD_BY = dr.ADD_BY;
                drb.ADD_TIME = dr.ADD_TIME;
                drb.EDIT_BY = dr.EDIT_BY;
                drb.EDIT_TIME = dr.EDIT_TIME;
                

                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
