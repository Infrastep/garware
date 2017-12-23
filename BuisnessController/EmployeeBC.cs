using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
namespace BuisnessController
{
    public class EmployeeBC
    {

        public static EMP_FIXED_Base insertupdateData(EMP_FIXED_Base obj)
        {
            EMP_FIXEDDL ed = new EMP_FIXEDDL();
            return ed.insertdata(obj);
        }
        public static List<EMP_FIXED_Base> getdataNotIn()
        {
            EMP_FIXEDDL ed = new EMP_FIXEDDL();
            return ed.getdataNotIn();
        }
        public static List<EMP_FIXED_Base> getdata()
        {
            EMP_FIXEDDL ed = new EMP_FIXEDDL();
            return ed.getdata();
        }
        public static List<EMP_FIXED_Base> getdatanew()
        {
            EMP_FIXEDDL ed = new EMP_FIXEDDL();
            return ed.getdatanew();
        }
        public static List<EMP_FIXED_Base> getSubscriber()
        {
            EMP_FIXEDDL ed = new EMP_FIXEDDL();
            return ed.getSubscriber();
        }
        public static EMP_FIXED_Base getdata(int id)
        {
            EMP_FIXEDDL ed = new EMP_FIXEDDL();
            return ed.getdata(id);
        }
        public static EMP_FIXED_Base getEmpIDByGuid(Guid id)
        {
            EMP_FIXEDDL ed = new EMP_FIXEDDL();
            return ed.getEmpIDByGuid(id);
        }
        public static int VerifyEMP(int id,string text,string status)
        {
            EMP_FIXEDDL ed = new EMP_FIXEDDL();
            return ed.VerifyEMP(id, text, status);
        }
      
        public static List<EMP_FIXED_Base> getUserForMailsend(int id)
        {
            EMP_FIXEDDL ed = new EMP_FIXEDDL();
            return ed.getUserForMailsend(id);
        }
        public static int UpdateStatus(int id, int status)
        {
            EMP_FIXEDDL ed = new EMP_FIXEDDL();
            return ed.UpdateStatus(id, status);
        }
        public static int UpdateImage(int id, string path)
        {
            EMP_FIXEDDL ed = new EMP_FIXEDDL();
            return ed.UpdateImage(id, path);
        }
        public static List<EMP_FIXED_Base> getdataforClient()
        {
            EMP_FIXEDDL ed = new EMP_FIXEDDL();
            return ed.getdataforClient();
        }
    }
}
