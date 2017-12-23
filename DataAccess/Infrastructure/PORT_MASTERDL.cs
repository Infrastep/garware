using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
namespace DataAccess.Infrastructure
{
    public class PORT_MASTERDL : COreEI
    {
        public List<PORT_MASTER_Base> getdata()
        {

            List<PORT_MASTER> dr = db1.PORT_MASTER.ToList();
            List<PORT_MASTER_Base> drb = generate_Base(dr);
            return drb;

        }

        public PORT_MASTER_Base getdata(int id)
        {

            PORT_MASTER dr = db1.PORT_MASTER.Where(q => q.PID == id).Single();
            PORT_MASTER_Base STM = generate_Base(dr);
            return STM;


        }

        public PORT_MASTER_Base insertdata(PORT_MASTER_Base dr)
        {
            int id = dr.PID;
            if (id != 0)
            {
                PORT_MASTER result = db1.PORT_MASTER.Where(q => q.PID == id).Single();
                if (result != null)
                {
                    result.PID = dr.PID;
                    result.Country = dr.Country;
                    result.PortName = dr.PortName;
                    result.CCODE = dr.CCODE;
                    result.addby = dr.addby;
                    result.editby = dr.editby;
                    result.addtime = dr.addtime;
                    result.editime = dr.editime;
                    result.Latitude = dr.Latitude;
                    result.Longitude = dr.Longitude;
                    result.status = dr.status;
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                PORT_MASTER result = new PORT_MASTER();

                result.Country = dr.Country;
                result.PortName = dr.PortName;
                result.CCODE = dr.CCODE;
                result.addby = dr.addby;
                result.editby = dr.editby;
                result.addtime = dr.addtime;
                result.editime = dr.editime;
                result.Latitude = dr.Latitude;
                result.Longitude = dr.Longitude;
                result.status = dr.status;
                db1.PORT_MASTER.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static PORT_MASTER_Base generate_Base(PORT_MASTER dr)
        {

            PORT_MASTER_Base drb = new PORT_MASTER_Base();
            COUNTRY_MASTERDL CM = new COUNTRY_MASTERDL();
            drb.PID = dr.PID;
            drb.Country = dr.Country;
            drb.PortName = dr.PortName;
            drb.CCODE = dr.CCODE;
            drb.addby = dr.addby;
            drb.editby = dr.editby;
            drb.addtime = dr.addtime;
            drb.editime = dr.editime;
            drb.Latitude = dr.Latitude;
            drb.Longitude = dr.Longitude;
            drb.status = dr.status;
            drb.COUNTRY_MASTER = CM.getdata(Convert.ToInt32(dr.Country));
            //drb.COUNTRY_MASTER = COUNTRY_MASTERDL.generate_Base(dr.COUNTRY_MASTER);
            return drb;
        }

        public static List<PORT_MASTER_Base> generate_Base(ICollection<PORT_MASTER> i)
        {
            List<PORT_MASTER_Base> drbl = new List<PORT_MASTER_Base>();
            int x = 0;
            foreach (PORT_MASTER dr in i)
            {
                PORT_MASTER_Base drb = new PORT_MASTER_Base();
                COUNTRY_MASTERDL CM = new COUNTRY_MASTERDL();
                drb.PID = dr.PID;
                drb.Country = dr.Country;
                drb.PortName = dr.PortName;
                drb.CCODE = dr.CCODE;
                drb.addby = dr.addby;
                drb.editby = dr.editby;
                drb.addtime = dr.addtime;
                drb.editime = dr.editime;
                drb.Latitude = dr.Latitude;
                drb.Longitude = dr.Longitude;
                drb.status = dr.status;
                drb.COUNTRY_MASTER = CM.getdata(Convert.ToInt32(dr.Country));
                drbl.Add(drb);

                x++;
            }
            return drbl;
        }
    }
}
