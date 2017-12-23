using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
using AutoMapper;
using BaseClass.VM.RankMaster;

namespace DataAccess.Infrastructure
{
    public class RANK_MASTERDL : COreEI
    {
        public List<RANK_MASTER_Base_RM> getdata()
        {

            List<RANK_MASTER> dr = db1.RANK_MASTER.ToList();
            List<RANK_MASTER_Base_RM> drb = generate_Base(dr);
            return drb;

        }

        public RANK_MASTER_Base_RM getdata(int id)
        {

            RANK_MASTER dr = db1.RANK_MASTER.Where(q => q.RANKID == id).Single();
            RANK_MASTER_Base_RM STM = generate_Base(dr);
            return STM;


        }

        public RANK_MASTER_Base_RM insertdata(RANK_MASTER_Base_RM dr)
        {
            int id = dr.RANKID;
            if (id != 0)
            {
                RANK_MASTER result = db1.RANK_MASTER.Where(q => q.RANKID == id).Single();
                if (result != null)
                {
                    result.RANKID = dr.RANKID;
                    result.RANK_DESC = dr.RANK_DESC;
                    result.CATEGORYID = dr.CATEGORYID;
                    result.Withheld_Perc_NRI = dr.Withheld_Perc_NRI;
                    result.Print_order = dr.Print_order;
                    result.Pf_Applicable = dr.Pf_Applicable;
                    result.Active = dr.Active;
                    
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                RANK_MASTER result = new RANK_MASTER();

                result.RANK_DESC = dr.RANK_DESC;
                result.CATEGORYID = dr.CATEGORYID;
                result.Withheld_Perc_NRI = dr.Withheld_Perc_NRI;
                result.Print_order = dr.Print_order;
                result.Pf_Applicable = dr.Pf_Applicable;
                result.Active = dr.Active;
               
                db1.RANK_MASTER.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }
       
        public static RANK_MASTER_Base_RM generate_Base(RANK_MASTER dr)
        {

            RANK_MASTER_Base_RM drb = Mapper.DynamicMap<RANK_MASTER, RANK_MASTER_Base_RM>(dr);

            //RANK_MASTER_Base_RM drb = new RANK_MASTER_Base_RM();
            //if (dr != null)
            //{
            //    drb.RANKID = dr.RANKID;
            //    drb.RANK_DESC = dr.RANK_DESC;
            //    drb.CATEGORYID = dr.CATEGORYID;
            //    drb.CATEGORY = CATEGORYDL.generate_Base(dr.CATEGORY);
            //    drb.Active = dr.Active;
            
            //}
            return drb;
        }

        public static List<RANK_MASTER_Base_RM> generate_Base(ICollection<RANK_MASTER> i)
        {

            List<RANK_MASTER_Base_RM> drbl = Mapper.DynamicMap<ICollection<RANK_MASTER>, List<RANK_MASTER_Base_RM>>(i);
            

            //List<RANK_MASTER_Base_RM> drbl = new List<RANK_MASTER_Base_RM>();
            //int x = 0;
            //foreach (RANK_MASTER dr in i)
            //{
            //    RANK_MASTER_Base_RM drb = new RANK_MASTER_Base_RM();
            //    drb.RANKID = dr.RANKID;
            //    drb.RANK_DESC = dr.RANK_DESC;
            //    drb.CATEGORYID = dr.CATEGORYID;
            //    drb.CATEGORY = CATEGORYDL.generate_Base(dr.CATEGORY);
            //    drb.Active = dr.Active;
              
            //    drbl.Add(drb);

            //    x++;
            //}
            return drbl;
        }
    }
}
