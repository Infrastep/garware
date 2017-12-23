using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass.VM.ShipMovement ;
using DataAccess.EF;
using AutoMapper;

namespace DataAccess.Infrastructure
{
    public class SHIP_MOVEMENTDL : COreEI
    {
        public List<SHIP_MOVEMENT_Base_SM> getdata()
        {

            List<SHIP_MOVEMENT> dr = db1.SHIP_MOVEMENT.ToList();
            List<SHIP_MOVEMENT_Base_SM> drb = generate_Base(dr);
            return drb;

        }

        public SHIP_MOVEMENT_Base_SM getdata(int id)
        {

            SHIP_MOVEMENT dr = db1.SHIP_MOVEMENT.Where(q => q.ID == id).Single();
            SHIP_MOVEMENT_Base_SM STM = generate_Base(dr);
            return STM;


        }

        public SHIP_MOVEMENT_Base_SM insertdata(SHIP_MOVEMENT_Base_SM dr)
        {
            try
            {
                int id = dr.ID;
                if (id != 0)
                {
                    SHIP_MOVEMENT result = db1.SHIP_MOVEMENT.Where(q => q.ID == id).Single();
                    if (result != null)
                    {
                        result.ID = dr.ID;
                        result.SHIP_ID = dr.SHIP_ID;
                        result.COUNTRY_ID = dr.COUNTRY_ID;
                        result.START_DATE = dr.START_DATE;
                        result.END_DATE = dr.END_DATE;



                        CommitChanges();
                        dr.EXP.Msg = "Successfully Updated ";
                        dr.EXP.Type = "success";
                    }
                    return generate_Base(result);
                }
                else
                {
                    SHIP_MOVEMENT result = new SHIP_MOVEMENT();

                    result.SHIP_ID = dr.SHIP_ID;
                    result.COUNTRY_ID = dr.COUNTRY_ID;
                    result.START_DATE = dr.START_DATE;
                    result.END_DATE = dr.END_DATE;
                    db1.SHIP_MOVEMENT.Add(result);
                    CommitChanges();
                    dr.EXP.Msg = "Successfully Saved ";
                    dr.EXP.Type = "success";
                    return generate_Base(result);
                }
            }
            catch (Exception ex)
            {
                dr.EXP.Msg = ex.Message ;
                dr.EXP.Type = "error";
                return dr;
            }

        }

        public static SHIP_MOVEMENT_Base_SM generate_Base(SHIP_MOVEMENT dr)
        {

            SHIP_MOVEMENT_Base_SM drb = Mapper.DynamicMap<SHIP_MOVEMENT, SHIP_MOVEMENT_Base_SM>(dr);

            return drb;
        }

        public static List<SHIP_MOVEMENT_Base_SM> generate_Base(ICollection<SHIP_MOVEMENT> i)
        {
            List<SHIP_MOVEMENT_Base_SM> drbl = new List<SHIP_MOVEMENT_Base_SM>();
            try
            {
                drbl = Mapper.DynamicMap<ICollection<SHIP_MOVEMENT>, List<SHIP_MOVEMENT_Base_SM>>(i);
           
            }
            catch(Exception ex) 
            { }
            return drbl;
        }
    }
}
