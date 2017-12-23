using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass.VM.ShipAgreement ;
using DataAccess.EF;
using AutoMapper;

namespace DataAccess.Infrastructure
{
    public class SHIP_AGREEMENTDL : COreEI
    {
        public List<SHIP_AGREEMENT_Base_SA> getdata()
        {

            List<ShipAgreement> dr = db1.ShipAgreements.ToList();
            List<SHIP_AGREEMENT_Base_SA> drb = generate_Base(dr);
            return drb;

        }

        public SHIP_AGREEMENT_Base_SA getdata(int id)
        {

            ShipAgreement dr = db1.ShipAgreements.Where(q => q.Id == id).Single();
            SHIP_AGREEMENT_Base_SA STM = generate_Base(dr);
            return STM;


        }

        public SHIP_AGREEMENT_Base_SA insertdata(SHIP_AGREEMENT_Base_SA dr)
        {
            try
            {
                int id = dr.Id;
                if (id != 0)
                {
                    ShipAgreement result = db1.ShipAgreements.Where(q => q.Id == id).Single();
                    if (result != null)
                    {
                        result.Id = dr.Id;
                        result.ClientId = dr.ClientId;
                        result.AgreementType = dr.AgreementType;
                        result.Startdate = dr.Startdate;
                        result.Enddate = dr.Enddate;
                        result.ShipId = dr.ShipId;



                        CommitChanges();
                        dr.Msg = "Successfully Updated ";
                        dr.Event = "success";
                    }
                    return generate_Base(result);
                }
                else
                {
                    ShipAgreement result = new ShipAgreement();

                    result.ClientId = dr.ClientId;
                    result.AgreementType = dr.AgreementType;
                    result.Startdate = dr.Startdate;
                    result.Enddate = dr.Enddate;
                    result.ShipId = dr.ShipId;
                    db1.ShipAgreements.Add(result);
                    CommitChanges();
                    dr.Msg = "Successfully Saved ";
                    dr.Event = "success";
                    return generate_Base(result);
                }
            }
            catch (Exception ex)
            {
                dr.Msg =ex.Message;
                dr.Event = "error";
                return dr;
            }

        }

        public static SHIP_AGREEMENT_Base_SA generate_Base(ShipAgreement dr)
        {

            SHIP_AGREEMENT_Base_SA drb = Mapper.DynamicMap<ShipAgreement, SHIP_AGREEMENT_Base_SA>(dr);

            return drb;
        }

        public static List<SHIP_AGREEMENT_Base_SA> generate_Base(ICollection<ShipAgreement> i)
        {
            List<SHIP_AGREEMENT_Base_SA> drbl = new List<SHIP_AGREEMENT_Base_SA>();
            try
            {
                drbl = Mapper.DynamicMap<ICollection<ShipAgreement>, List<SHIP_AGREEMENT_Base_SA>>(i);
           
            }
            catch(Exception ex) 
            { }
            return drbl;
        }
    }
}
