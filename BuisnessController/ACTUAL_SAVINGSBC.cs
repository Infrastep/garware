using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.Infrastructure;
using BaseClass.VM.ActualSavings;
namespace BuisnessController
{
   public class ACTUAL_SAVINGSBC
    {
        public static ACTUAL_SAVINGS_Base_ACS insertupdateData(ACTUAL_SAVINGS_Base_ACS obj)
        {
            ACTUAL_SAVINGSDL ed = new ACTUAL_SAVINGSDL();
            return ed.insertdata(obj);
        }

        public static List<ACTUAL_SAVINGS_Base_ACS> getdata()
        {
            ACTUAL_SAVINGSDL ed = new ACTUAL_SAVINGSDL();
            return ed.getdata();
        }
        public static ACTUAL_SAVINGS_Base_ACS getdata(int id)
        {
            ACTUAL_SAVINGSDL ed = new ACTUAL_SAVINGSDL();
            return ed.getdata(id);
        }
    }
}
