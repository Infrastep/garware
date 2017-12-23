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
  public  class RULE8DL :COreEI
  {
      public List<RULE8_Base> getdata()
      {

          List<RULE8> dr = db1.RULE8.ToList();
          List<RULE8_Base> drb = generate_Base(dr);
          return drb;

      }

      public RULE8_Base getdata(int id)
      {

          RULE8 dr = db1.RULE8.Where(q => q.RULE8ID == id).Single();
          RULE8_Base STM = generate_Base(dr);
          return STM;


      }

      public RULE8_Base insertdata(RULE8_Base dr)
      {
          int id = dr.RULE8ID;
          if (id != 0)
          {
              RULE8 result = db1.RULE8.Where(q => q.RULE8ID == id).Single();
              if (result != null)
              {
                  result.RULE8ID = dr.RULE8ID;
                  result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
                  result.EMPL_CLASS = dr.EMPL_CLASS;
                  result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
                  result.SHIP_CODE = dr.SHIP_CODE;
                  result.PROLONG_FROM_MONTH = dr.PROLONG_FROM_MONTH;
                  result.PROLONG_TO_MONTH = dr.PROLONG_TO_MONTH;
                  result.PRCNT_IN_FIRST_PERIOD = dr.PRCNT_IN_FIRST_PERIOD;
                  result.PRCNT_IN_SECOND_PERIOD = dr.PRCNT_IN_SECOND_PERIOD;
                  result.PRCNT_IN_THIRD_PERIOD = dr.PRCNT_IN_THIRD_PERIOD;
                  result.SECONDARY_EARN_DEDN_CODE = dr.SECONDARY_EARN_DEDN_CODE;
                  result.ADD_BY = dr.ADD_BY;
                  result.ADD_TIME = dr.ADD_TIME;
                  result.EDIT_BY = dr.EDIT_BY;
                  result.EDIT_TIME = dr.EDIT_TIME;


                  CommitChanges();
              }
              return generate_Base(result);
          }
          else
          {
              RULE8 result = new RULE8();

              result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
              result.EMPL_CLASS = dr.EMPL_CLASS;
              result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
              result.SHIP_CODE = dr.SHIP_CODE;
              result.PROLONG_FROM_MONTH = dr.PROLONG_FROM_MONTH;
              result.PROLONG_TO_MONTH = dr.PROLONG_TO_MONTH;
              result.PRCNT_IN_FIRST_PERIOD = dr.PRCNT_IN_FIRST_PERIOD;
              result.PRCNT_IN_SECOND_PERIOD = dr.PRCNT_IN_SECOND_PERIOD;
              result.PRCNT_IN_THIRD_PERIOD = dr.PRCNT_IN_THIRD_PERIOD;
              result.SECONDARY_EARN_DEDN_CODE = dr.SECONDARY_EARN_DEDN_CODE;
              result.ADD_BY = dr.ADD_BY;
              result.ADD_TIME = dr.ADD_TIME;
              result.EDIT_BY = dr.EDIT_BY;
              result.EDIT_TIME = dr.EDIT_TIME;

              db1.RULE8.Add(result);
              CommitChanges();
              return generate_Base(result);
          }
      }

      public static RULE8_Base generate_Base(RULE8 dr)
      {

          RULE8_Base drb = Mapper.DynamicMap<RULE8, RULE8_Base>(dr);

          return drb;
      }

      public static List<RULE8_Base> generate_Base(ICollection<RULE8> i)
      {
          List<RULE8_Base> drbl = Mapper.DynamicMap<ICollection<RULE8>, List<RULE8_Base>>(i);

          return drbl;
      }
    }
}
