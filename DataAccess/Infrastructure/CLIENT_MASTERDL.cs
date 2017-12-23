using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
using AutoMapper;
namespace DataAccess.Infrastructure
{
    public class CLIENT_MASTERDL :COreEI
    {
        public List<CLIENT_MASTER_Base> getdata()
        {

            List<CLIENT_MASTER> dr = db1.CLIENT_MASTER.ToList();
            List<CLIENT_MASTER_Base> drb = generate_Base(dr);
            return drb;

        }

        public CLIENT_MASTER_Base getdata(int id)
        {

            CLIENT_MASTER dr = db1.CLIENT_MASTER.Where(q => q.CLIENTID == id).Single();
            CLIENT_MASTER_Base STM = generate_Base(dr);
            return STM;


        }

        public CLIENT_MASTER_Base insertdata(CLIENT_MASTER_Base dr)
        {
            int id = dr.CLIENTID;
            if (id != 0)
            {
                CLIENT_MASTER result = db1.CLIENT_MASTER.Where(q => q.CLIENTID == id).Single();
                if (result != null)
                {
                    result.CLIENTID = dr.CLIENTID;
                    result.CLIENT_NAME = dr.CLIENT_NAME;
                    //result.DATABASE_NAME = dr.DATABASE_NAME;
                    //result.DATABASE_HOST = dr.DATABASE_HOST;
                    //result.DATABASE_PASS = dr.DATABASE_PASS;
                    //result.DATABASE_UID = dr.DATABASE_UID;
                    result.PIN = dr.PIN;
                    result.EMAIL = dr.EMAIL;
                    result.ADDRESS = dr.ADDRESS;
                    result.CITY = dr.CITY;
                    result.STATE = dr.STATE;
                    result.PHONE = dr.PHONE;
                    result.FAX_NO = dr.FAX_NO;
                    result.SERVICE_TAX_NO = dr.SERVICE_TAX_NO;
                    if (dr.PICTURE != "")
                    {
                        result.PICTURE = dr.PICTURE;
                    }
                   
                    result.STATUS = dr.STATUS;
                    result.CIN_NO = dr.CIN_NO;
                    result.PAN = dr.PAN;
                    result.TAN = dr.TAN;
                    result.WEBSITE = dr.WEBSITE;
                    result.COUNTRY_ID = dr.COUNTRY_ID;
                    result.DESCRIPTION = dr.DESCRIPTION;
                    result.CLIENT_LOGO = dr.CLIENT_LOGO;
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                CLIENT_MASTER result = new CLIENT_MASTER();
                
                result.CLIENT_NAME = dr.CLIENT_NAME;
                //result.DATABASE_NAME = dr.DATABASE_NAME;
                //result.DATABASE_HOST = dr.DATABASE_HOST;
                //result.DATABASE_PASS = dr.DATABASE_PASS;
                //result.DATABASE_UID = dr.DATABASE_UID;
                result.PIN = dr.PIN;
                result.EMAIL = dr.EMAIL;
                result.ADDRESS = dr.ADDRESS;
                result.CITY = dr.CITY;
                result.STATE = dr.STATE;
                result.PHONE = dr.PHONE;
                result.FAX_NO = dr.FAX_NO;
                result.SERVICE_TAX_NO = dr.SERVICE_TAX_NO;
                result.PICTURE = dr.PICTURE;
                result.STATUS = dr.STATUS;
                result.CIN_NO = dr.CIN_NO;
                result.PAN = dr.PAN;
                result.TAN = dr.TAN;
                result.WEBSITE = dr.WEBSITE;
                result.COUNTRY_ID = dr.COUNTRY_ID;
                result.DESCRIPTION = dr.DESCRIPTION;
                result.CLIENT_LOGO = dr.CLIENT_LOGO;
                db1.CLIENT_MASTER.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static CLIENT_MASTER_Base generate_Base(CLIENT_MASTER dr)
        {

            CLIENT_MASTER_Base drb = Mapper.DynamicMap<CLIENT_MASTER, CLIENT_MASTER_Base>(dr);

            if (dr.PICTURE != null && dr.PICTURE != "")
            { drb.PICTURE = UTILITYDL.GetImage(dr.PICTURE, "client"); }
            else
            { drb.PICTURE = "/uploads/cruise.jpg"; }
                       
            return drb;
        }

        public static List<CLIENT_MASTER_Base> generate_Base(ICollection<CLIENT_MASTER> i)
        {
            List<CLIENT_MASTER_Base> drbl = Mapper.DynamicMap<ICollection<CLIENT_MASTER>, List<CLIENT_MASTER_Base>>(i);
            int x = 0;
            foreach (CLIENT_MASTER_Base dr in drbl)
            {
                if (dr.PICTURE != null && dr.PICTURE != "")
                { dr.PICTURE = UTILITYDL.GetImage(dr.PICTURE, "client"); }
                else
                { dr.PICTURE = "/uploads/cruise.jpg"; }
                x++;
            }
                        
            return drbl;
        }
    }
}
