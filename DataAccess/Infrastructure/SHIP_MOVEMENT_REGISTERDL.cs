using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.EF;
using AutoMapper;
using BaseClass.VM.ShipMovementRegister;
namespace DataAccess.Infrastructure
{
    public class SHIP_MOVEMENT_REGISTERDL : COreEI
   {
        public List<SHIP_MOVEMENT_REGISTER_Base_SMR> getdata()
       {

           List<SHIP_MOVEMENT_REGISTER> dr = db1.SHIP_MOVEMENT_REGISTER.ToList();
           List<SHIP_MOVEMENT_REGISTER_Base_SMR> drb = generate_Base(dr);
           return drb;

       }

       public SHIP_MOVEMENT_REGISTER_Base_SMR getdata(int id)
       {

           SHIP_MOVEMENT_REGISTER dr = db1.SHIP_MOVEMENT_REGISTER.Where(q => q.ID == id).Single();
           SHIP_MOVEMENT_REGISTER_Base_SMR STM = generate_Base(dr);
           return STM;


       }

       public SHIP_MOVEMENT_REGISTER_Base_SMR insertdata(SHIP_MOVEMENT_REGISTER_Base_SMR dr)
       {
           try
           {
               int id = dr.ID;
               if (id != 0)
               {
                   SHIP_MOVEMENT_REGISTER result = db1.SHIP_MOVEMENT_REGISTER.Where(q => q.ID == id).Single();
                   if (result != null)
                   {
                       result.ID = dr.ID;
                       result.SHIPCODE = dr.SHIPCODE;
                       result.WATER = dr.WATER;
                       result.FROM_DATE = dr.FROM_DATE;
                       result.TO_DATE = dr.TO_DATE;



                       CommitChanges();
                      
                   }
                   return generate_Base(result);
               }
               else
               {
                   SHIP_MOVEMENT_REGISTER result = new SHIP_MOVEMENT_REGISTER();

                   result.SHIPCODE = dr.SHIPCODE;
                   result.WATER = dr.WATER;
                   result.FROM_DATE = dr.FROM_DATE;
                   result.TO_DATE = dr.TO_DATE;
                   db1.SHIP_MOVEMENT_REGISTER.Add(result);
                   CommitChanges();
                   
                   return generate_Base(result);
               }
           }
           catch (Exception ex)
           {
               
               return dr;
           }

       }

       public static SHIP_MOVEMENT_REGISTER_Base_SMR generate_Base(SHIP_MOVEMENT_REGISTER dr)
       {

           SHIP_MOVEMENT_REGISTER_Base_SMR drb = Mapper.DynamicMap<SHIP_MOVEMENT_REGISTER, SHIP_MOVEMENT_REGISTER_Base_SMR>(dr);

           return drb;
       }

       public static List<SHIP_MOVEMENT_REGISTER_Base_SMR> generate_Base(ICollection<SHIP_MOVEMENT_REGISTER> i)
       {
           List<SHIP_MOVEMENT_REGISTER_Base_SMR> drbl = new List<SHIP_MOVEMENT_REGISTER_Base_SMR>();
           try
           {
               drbl = Mapper.DynamicMap<ICollection<SHIP_MOVEMENT_REGISTER>, List<SHIP_MOVEMENT_REGISTER_Base_SMR>>(i);

           }
           catch (Exception ex)
           { }
           return drbl;
       }
    }
}
