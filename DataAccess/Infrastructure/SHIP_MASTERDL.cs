using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
   public class SHIP_MASTERDL :COreEI
    {
       public List<SHIP_MASTER_Base> getdata()
        {

            List<SHIP_MASTER> dr = db1.SHIP_MASTER.ToList();
            List<SHIP_MASTER_Base> drb = generate_Base(dr);
            return drb;

        }

        public SHIP_MASTER_Base getdata(int id)
        {

            SHIP_MASTER dr = db1.SHIP_MASTER.Where(q => q.SMID == id).Single();
            SHIP_MASTER_Base STM = generate_Base(dr);
            return STM;


        }
        public List<SHIP_MASTER_Base> getdatabyclientid(int comid)
        {

            List<SHIP_MASTER> dr = db1.SHIP_MASTER.Where(q=>q.CLIENT_ID==comid).ToList();
            List<SHIP_MASTER_Base> drb = generate_Base(dr);
            return drb;

        }
        public SHIP_MASTER_Base insertdata(SHIP_MASTER_Base dr)
        {
            int id = dr.SMID;
            if (id != 0)
            {
                SHIP_MASTER result = db1.SHIP_MASTER.Where(q => q.SMID == id).Single();
                if (result != null)
                {
                    result.SMID = dr.SMID;
                    result.VNAME = dr.VNAME;
                    result.OFF_IMO_NO = dr.OFF_IMO_NO;
                    result.PORT_REG_TRADE = dr.PORT_REG_TRADE;
                    result.GT_POWER = dr.GT_POWER;
                    result.NO_OF_CREW = dr.NO_OF_CREW;
                    result.ADD_BY = dr.ADD_BY;
                    result.EDIT_BY = dr.EDIT_BY;
                    result.ADD_TIME = dr.ADD_TIME;
                    result.EDIT_TIME = dr.ADD_TIME;
                    result.NRT = dr.NRT;
                    if(dr.PHOTO ==null || dr.PHOTO =="")
                    { result.PHOTO = result.PHOTO; }
                    else
                    { result.PHOTO = dr.PHOTO; }
                   
                    result.AREA_OF_OPERATION = dr.AREA_OF_OPERATION;
                    result.OFFICIAL_NO = dr.OFFICIAL_NO;
                    result.POWER_KW_BHP = dr.POWER_KW_BHP;
                    result.CLIENT_ID = dr.CLIENT_ID;
                    result.COUNTRY_FLAG = dr.COUNTRY_FLAG;
                    result.TYPEID = dr.TYPEID;
                    result.STATUS = dr.STATUS;
                    result.CALL_SIGN =dr.CALL_SIGN;
                    result.DWT = dr.DWT;
                    result.ABS_NO = dr.ABS_NO;
                    result.MMSI_NO = dr.MMSI_NO;
                    result.SAT_C_ID = dr.SAT_C_ID;
                    result.MOBILE_NO = dr.MOBILE_NO;
                    result.EMAIL = dr.EMAIL;
                    result.VSAT_NO = dr.VSAT_NO;
    


                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                SHIP_MASTER result = new SHIP_MASTER();
               
                result.VNAME = dr.VNAME;
                result.OFF_IMO_NO = dr.OFF_IMO_NO;
                result.PORT_REG_TRADE = dr.PORT_REG_TRADE;
                result.GT_POWER = dr.GT_POWER;
                result.NO_OF_CREW = dr.NO_OF_CREW;
                result.ADD_BY = dr.ADD_BY;
                result.EDIT_BY = dr.EDIT_BY;
                result.ADD_TIME = dr.ADD_TIME;
                result.EDIT_TIME = dr.ADD_TIME;
                result.NRT = dr.NRT;
                
                result.AREA_OF_OPERATION = dr.AREA_OF_OPERATION;
                result.OFFICIAL_NO = dr.OFFICIAL_NO;
                result.POWER_KW_BHP = dr.POWER_KW_BHP;
                result.CLIENT_ID = dr.CLIENT_ID;
                result.COUNTRY_FLAG = dr.COUNTRY_FLAG;
                result.TYPEID = dr.TYPEID;
                result.PHOTO = dr.PHOTO;
                result.STATUS = dr.STATUS;
                result.CALL_SIGN = dr.CALL_SIGN;
                result.DWT = dr.DWT;
                result.ABS_NO = dr.ABS_NO;
                result.MMSI_NO = dr.MMSI_NO;
                result.SAT_C_ID = dr.SAT_C_ID;
                result.MOBILE_NO = dr.MOBILE_NO;
                result.EMAIL = dr.EMAIL;
                result.VSAT_NO = dr.VSAT_NO;
    
                db1.SHIP_MASTER.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static SHIP_MASTER_Base generate_Base(SHIP_MASTER dr)
        {

            SHIP_MASTER_Base drb = new SHIP_MASTER_Base();
            if (dr != null)
            {
                drb.SMID = dr.SMID;
                drb.VNAME = dr.VNAME;
                drb.OFF_IMO_NO = dr.OFF_IMO_NO;
                drb.PORT_REG_TRADE = dr.PORT_REG_TRADE;
                drb.GT_POWER = dr.GT_POWER;
                drb.NO_OF_CREW = dr.NO_OF_CREW;
                drb.ADD_BY = dr.ADD_BY;
                drb.EDIT_BY = dr.EDIT_BY;
                drb.ADD_TIME = dr.ADD_TIME;
                drb.EDIT_TIME = dr.ADD_TIME;
                drb.NRT = dr.NRT;
               
                drb.AREA_OF_OPERATION = dr.AREA_OF_OPERATION;
                drb.OFFICIAL_NO = dr.OFFICIAL_NO;
                drb.POWER_KW_BHP = dr.POWER_KW_BHP;
                drb.CLIENT_ID = dr.CLIENT_ID;
                drb.COUNTRY_FLAG = dr.COUNTRY_FLAG;
                drb.TYPEID = dr.TYPEID;
                if (dr.PHOTO != null && dr.PHOTO != "")
                { drb.PHOTO = UTILITYDL.GetImage(dr.PHOTO, "client"); }
                else
                { drb.PHOTO = "/uploads/cruise.jpg"; }
                drb.STATUS = dr.STATUS;
                drb.CALL_SIGN = dr.CALL_SIGN;
                drb.DWT = dr.DWT;
                drb.ABS_NO = dr.ABS_NO;
                drb.MMSI_NO = dr.MMSI_NO;
                drb.SAT_C_ID = dr.SAT_C_ID;
                drb.MOBILE_NO = dr.MOBILE_NO;
                drb.EMAIL = dr.EMAIL;
                drb.VSAT_NO = dr.VSAT_NO;
    

                //drb.CLIENT_MASTER = CLIENT_MASTERDL.generate_Base(dr.CLIENT_MASTER);
                drb.COUNTRY_MASTER = COUNTRY_MASTERDL.generate_Base(dr.COUNTRY_MASTER);
                drb.SHIP_TYPE_MASTER = SHIP_TYPE_MASTERDL.generate_Base(dr.SHIP_TYPE_MASTER);
            }
            return drb;
        }

        public static List<SHIP_MASTER_Base> generate_Base(ICollection<SHIP_MASTER> i)
        {
            List<SHIP_MASTER_Base> drbl = new List<SHIP_MASTER_Base>();
            int x = 0;
            foreach (SHIP_MASTER dr in i)
            {
                SHIP_MASTER_Base drb = new SHIP_MASTER_Base();
                drb.SMID = dr.SMID;
                drb.VNAME = dr.VNAME;
                drb.OFF_IMO_NO = dr.OFF_IMO_NO;
                drb.PORT_REG_TRADE = dr.PORT_REG_TRADE;
                drb.GT_POWER = dr.GT_POWER;
                drb.NO_OF_CREW = dr.NO_OF_CREW;
                drb.ADD_BY = dr.ADD_BY;
                drb.EDIT_BY = dr.EDIT_BY;
                drb.ADD_TIME = dr.ADD_TIME;
                drb.EDIT_TIME = dr.ADD_TIME;
                drb.NRT = dr.NRT;
               
                drb.AREA_OF_OPERATION = dr.AREA_OF_OPERATION;
                drb.OFFICIAL_NO = dr.OFFICIAL_NO;
                drb.POWER_KW_BHP = dr.POWER_KW_BHP;
                drb.CLIENT_ID = dr.CLIENT_ID;
                drb.COUNTRY_FLAG = dr.COUNTRY_FLAG;
                drb.TYPEID = dr.TYPEID;
                if (dr.PHOTO != null && dr.PHOTO != "")
                { drb.PHOTO = UTILITYDL.GetImage(dr.PHOTO, "client"); }
                else
                { drb.PHOTO = "/uploads/cruise.jpg"; }
                //drb.PHOTO = dr.PHOTO;
                drb.STATUS = dr.STATUS;
                drb.CALL_SIGN = dr.CALL_SIGN;
                drb.DWT = dr.DWT;
                drb.ABS_NO = dr.ABS_NO;
                drb.MMSI_NO = dr.MMSI_NO;
                drb.SAT_C_ID = dr.SAT_C_ID;
                drb.MOBILE_NO = dr.MOBILE_NO;
                drb.EMAIL = dr.EMAIL;
                drb.VSAT_NO = dr.VSAT_NO;
               // drb.CLIENT_MASTER = CLIENT_MASTERDL.generate_Base(dr.CLIENT_MASTER);
                drb.COUNTRY_MASTER = COUNTRY_MASTERDL.generate_Base(dr.COUNTRY_MASTER);
                drb.SHIP_TYPE_MASTER = SHIP_TYPE_MASTERDL.generate_Base(dr.SHIP_TYPE_MASTER);

                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
