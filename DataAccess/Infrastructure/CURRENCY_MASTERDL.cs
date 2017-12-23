using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
    public class CURRENCY_MASTERDL :COreEI
    {
        public List<CURRENCY_MASTER_Base> getdata()
        {

            List<CURRENCY_MASTER> dr = db1.CURRENCY_MASTER.ToList();
            List<CURRENCY_MASTER_Base> drb = generate_Base(dr);
            return drb;

        }

        public CURRENCY_MASTER_Base getdata(int id)
        {

            CURRENCY_MASTER dr = db1.CURRENCY_MASTER.Where(q => q.Currency_id == id).Single();
            CURRENCY_MASTER_Base STM = generate_Base(dr);
            return STM;


        }

        public CURRENCY_MASTER_Base insertdata(CURRENCY_MASTER_Base dr)
        {
            int id = dr.Currency_id;
            if (id != 0)
            {
                CURRENCY_MASTER result = db1.CURRENCY_MASTER.Where(q => q.Currency_id == id).Single();
                if (result != null)
                {
                    result.Currency_id = dr.Currency_id;
                    result.title = dr.title;
                    result.code = dr.code;
                    result.symbol_left = dr.symbol_left;
                    result.symbol_right = dr.symbol_right;
                    result.decimal_place = dr.decimal_place;
                    result.value = dr.value;
                    result.status = dr.status;

                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                CURRENCY_MASTER result = new CURRENCY_MASTER();
                result.title = dr.title;
                result.code = dr.code;
                result.symbol_left = dr.symbol_left;
                result.symbol_right = dr.symbol_right;
                result.decimal_place = dr.decimal_place;
                result.value = dr.value;
                result.status = dr.status;
                db1.CURRENCY_MASTER.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static CURRENCY_MASTER_Base generate_Base(CURRENCY_MASTER dr)
        {

            CURRENCY_MASTER_Base drb = new CURRENCY_MASTER_Base();
            drb.Currency_id = dr.Currency_id;
            drb.title = dr.title;
            drb.code = dr.code;
            drb.symbol_left = dr.symbol_left;
            drb.symbol_right = dr.symbol_right;
            drb.decimal_place = dr.decimal_place;
            drb.value = dr.value;
            drb.status = dr.status;
            return drb;
        }

        public static List<CURRENCY_MASTER_Base> generate_Base(ICollection<CURRENCY_MASTER> i)
        {
            List<CURRENCY_MASTER_Base> drbl = new List<CURRENCY_MASTER_Base>();
            int x = 0;
            foreach (CURRENCY_MASTER dr in i)
            {
                CURRENCY_MASTER_Base drb = new CURRENCY_MASTER_Base();
                drb.Currency_id = dr.Currency_id;
                drb.title = dr.title;
                drb.code = dr.code;
                drb.symbol_left = dr.symbol_left;
                drb.symbol_right = dr.symbol_right;
                drb.decimal_place = dr.decimal_place;
                drb.value = dr.value;
                drb.status = dr.status;
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
