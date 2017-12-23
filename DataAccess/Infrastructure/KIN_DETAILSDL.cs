using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
    public class KIN_DETAILSDL : COreEI
    {
        public List<KIN_DETAILS_Base> getdata()
        {

            List<KIN_DETAILS> dr = db1.KIN_DETAILS.ToList();
            List<KIN_DETAILS_Base> drb = generate_Base(dr);
            return drb;

        }

        public KIN_DETAILS_Base getdata(int id)
        {

            KIN_DETAILS dr = db1.KIN_DETAILS.Where(q => q.KINID == id).Single();
            KIN_DETAILS_Base STM = generate_Base(dr);
            return STM;


        }
        public List<KIN_DETAILS_Base> getdatabyEmpId(int id)
        {
            List<KIN_DETAILS> dr = new List<KIN_DETAILS>();
            var lst = db1.KIN_DETAILS.Where(q => q.EMP_FIXED.EMPID == id).ToList();

            if (lst.Count > 0)
            {
                dr = db1.KIN_DETAILS.Where(q => q.EMP_FIXED.EMPID == id).ToList();

            }

            return generate_Base(dr);


        }

        public KIN_DETAILS_Base insertdata(KIN_DETAILS_Base dr)
        {
            int id = dr.KINID;
            if (id != 0)
            {
                KIN_DETAILS result = db1.KIN_DETAILS.Where(q => q.KINID == id).Single();
                if (result != null)
                {
                    result.KINID = dr.KINID;
                    result.NAME = dr.NAME;
                    result.DOB = dr.DOB;
                    result.ADDRESS1 = dr.ADDRESS1;
                    result.ADDRESS2 = dr.ADDRESS2;
                    result.PHONE = dr.PHONE;
                    result.CITY = dr.CITY;
                    result.STATE = dr.STATE;
                    result.PIN = dr.PIN;
                    result.EMAIL = dr.EMAIL;
                    result.GENDER = dr.GENDER;
                    result.COUNTRYID = dr.COUNTRYID;
                    result.EMPID = dr.EMPID;
                    result.RELATIONSHIPID = dr.RELATIONSHIPID;
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                KIN_DETAILS result = new KIN_DETAILS();

                result.NAME = dr.NAME;
                result.DOB = dr.DOB;
                result.ADDRESS1 = dr.ADDRESS1;
                result.ADDRESS2 = dr.ADDRESS2;
                result.PHONE = dr.PHONE;
                result.CITY = dr.CITY;
                result.STATE = dr.STATE;
                result.PIN = dr.PIN;
                result.EMAIL = dr.EMAIL;
                result.GENDER = dr.GENDER;
                result.COUNTRYID = dr.COUNTRYID;
                result.EMPID = dr.EMPID;
                result.RELATIONSHIPID = dr.RELATIONSHIPID;
                db1.KIN_DETAILS.Add(result);

                CommitChanges();
                return generate_Base(result);
            }
        }

        public static KIN_DETAILS_Base generate_Base(KIN_DETAILS dr)
        {

            KIN_DETAILS_Base drb = new KIN_DETAILS_Base();
            if (dr != null)
            {
                drb.KINID = dr.KINID;
                drb.NAME = dr.NAME;
                drb.DOB = dr.DOB;
                drb.ADDRESS1 = dr.ADDRESS1;
                drb.ADDRESS2 = dr.ADDRESS2;
                drb.PHONE = dr.PHONE;
                drb.CITY = dr.CITY;
                drb.STATE = dr.STATE;
                drb.PIN = dr.PIN;
                drb.EMAIL = dr.EMAIL;
                drb.GENDER = dr.GENDER;
                drb.COUNTRYID = dr.COUNTRYID;
                drb.EMPID = dr.EMPID;
                drb.RELATIONSHIPID = dr.RELATIONSHIPID;
                drb.COUNTRY_MASTER = COUNTRY_MASTERDL.generate_Base(dr.COUNTRY_MASTER);
                drb.EMP_FIXED = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED);
                drb.RELATIONSHIP_MASTER = RELATIONSHIP_MASTERDL.generate_Base(dr.RELATIONSHIP_MASTER);

            }
            return drb;
        }

        public static List<KIN_DETAILS_Base> generate_Base(ICollection<KIN_DETAILS> i)
        {
            List<KIN_DETAILS_Base> drbl = new List<KIN_DETAILS_Base>();
            int x = 0;
            foreach (KIN_DETAILS dr in i)
            {
                KIN_DETAILS_Base drb = new KIN_DETAILS_Base();
                drb.KINID = dr.KINID;
                drb.NAME = dr.NAME;
                drb.DOB = dr.DOB;
                drb.ADDRESS1 = dr.ADDRESS1;
                drb.ADDRESS2 = dr.ADDRESS2;
                drb.PHONE = dr.PHONE;
                drb.CITY = dr.CITY;
                drb.STATE = dr.STATE;
                drb.PIN = dr.PIN;
                drb.EMAIL = dr.EMAIL;
                drb.GENDER = dr.GENDER;
                drb.COUNTRYID = dr.COUNTRYID;
                drb.EMPID = dr.EMPID;
                drb.RELATIONSHIPID = dr.RELATIONSHIPID;
                drb.COUNTRY_MASTER = COUNTRY_MASTERDL.generate_Base(dr.COUNTRY_MASTER);
                drb.EMP_FIXED = EMP_FIXEDDL.generate_Base(dr.EMP_FIXED);
                drb.RELATIONSHIP_MASTER = RELATIONSHIP_MASTERDL.generate_Base(dr.RELATIONSHIP_MASTER);
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
