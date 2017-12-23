using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
    public class DG_CERTIFIED_DOCTORSDL : COreEI
    {
        public List<DG_CERTIFIED_DOCTORS_Base> getdata()
        {

            List<DG_CERTIFIED_DOCTORS> dr = db1.DG_CERTIFIED_DOCTORS.ToList();
            List<DG_CERTIFIED_DOCTORS_Base> drb = generate_Base(dr);
            return drb;

        }

        public DG_CERTIFIED_DOCTORS_Base getdata(int id)
        {

            DG_CERTIFIED_DOCTORS dr = db1.DG_CERTIFIED_DOCTORS.Where(q => q.DGCDID == id).Single();
            DG_CERTIFIED_DOCTORS_Base STM = generate_Base(dr);
            return STM;


        }

        public DG_CERTIFIED_DOCTORS_Base insertdata(DG_CERTIFIED_DOCTORS_Base dr)
        {
            int id = dr.DGCDID;
            if (id != 0)
            {
                DG_CERTIFIED_DOCTORS result = db1.DG_CERTIFIED_DOCTORS.Where(q => q.DGCDID == id).Single();
                if (result != null)
                {
                    result.DGCDID = dr.DGCDID;
                    result.COUNTRYID = dr.COUNTRYID;
                    result.DOCTOR_NAME = dr.DOCTOR_NAME;
                    result.CLINIC = dr.CLINIC;
                    result.ADDRESS1 = dr.ADDRESS1;
                    result.ADDRESS2 = dr.ADDRESS2;
                    result.CITY = dr.CITY;
                    result.STATE = dr.STATE;
                    result.PIN = dr.PIN;
                    result.STATUS = dr.STATUS;
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                DG_CERTIFIED_DOCTORS result = new DG_CERTIFIED_DOCTORS();
               
                result.COUNTRYID = dr.COUNTRYID;
                result.DOCTOR_NAME = dr.DOCTOR_NAME;
                result.CLINIC = dr.CLINIC;
                result.ADDRESS1 = dr.ADDRESS1;
                result.ADDRESS2 = dr.ADDRESS2;
                result.CITY = dr.CITY;
                result.STATE = dr.STATE;
                result.PIN = dr.PIN;
                result.STATUS = dr.STATUS;
                db1.DG_CERTIFIED_DOCTORS.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static DG_CERTIFIED_DOCTORS_Base generate_Base(DG_CERTIFIED_DOCTORS dr)
        {

            DG_CERTIFIED_DOCTORS_Base drb = new DG_CERTIFIED_DOCTORS_Base();

            drb.DGCDID = dr.DGCDID;
            drb.COUNTRYID = dr.COUNTRYID;
            drb.DOCTOR_NAME = dr.DOCTOR_NAME;
            drb.CLINIC = dr.CLINIC;
            drb.ADDRESS1 = dr.ADDRESS1;
            drb.ADDRESS2 = dr.ADDRESS2;
            drb.CITY = dr.CITY;
            drb.STATE = dr.STATE;
            drb.PIN = dr.PIN;
            drb.STATUS = dr.STATUS;
            drb.COUNTRY_MASTER = COUNTRY_MASTERDL.generate_Base(dr.COUNTRY_MASTER);
            return drb;
        }

        public static List<DG_CERTIFIED_DOCTORS_Base> generate_Base(ICollection<DG_CERTIFIED_DOCTORS> i)
        {
            List<DG_CERTIFIED_DOCTORS_Base> drbl = new List<DG_CERTIFIED_DOCTORS_Base>();
            int x = 0;
            foreach (DG_CERTIFIED_DOCTORS dr in i)
            {
                DG_CERTIFIED_DOCTORS_Base drb = new DG_CERTIFIED_DOCTORS_Base();
                drb.DGCDID = dr.DGCDID;
                drb.COUNTRYID = dr.COUNTRYID;
                drb.DOCTOR_NAME = dr.DOCTOR_NAME;
                drb.CLINIC = dr.CLINIC;
                drb.ADDRESS1 = dr.ADDRESS1;
                drb.ADDRESS2 = dr.ADDRESS2;
                drb.CITY = dr.CITY;
                drb.STATE = dr.STATE;
                drb.PIN = dr.PIN;
                drb.STATUS = dr.STATUS;
                drb.COUNTRY_MASTER = COUNTRY_MASTERDL.generate_Base(dr.COUNTRY_MASTER);
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
