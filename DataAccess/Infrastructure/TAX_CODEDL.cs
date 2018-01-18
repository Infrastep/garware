﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
using AutoMapper;
namespace DataAccess.Infrastructure
{
   public class TAX_CODEDL :COreEI
    {
        public List<TAX_CODE_Base> getdata()
        {

            List<TAX_CODE> dr = db1.TAX_CODE.ToList();
            List<TAX_CODE_Base> drb = generate_Base(dr);
            return drb;

        }

        public TAX_CODE_Base getdata(int id)
        {

            TAX_CODE dr = db1.TAX_CODE.Where(q => q.ID == id).Single();
            TAX_CODE_Base STM = generate_Base(dr);
            return STM;


        }

        public TAX_CODE_Base insertdata(TAX_CODE_Base dr)
        {
            int id = dr.ID;
            if (id != 0)
            {
                TAX_CODE result = db1.TAX_CODE.Where(q => q.ID == id).Single();
                if (result != null)
                {
                    result.ID = dr.ID;
                    result.DESCRIPTIONS = dr.DESCRIPTIONS;
                    result.UNDER_SECTION = dr.UNDER_SECTION;
                    result.INCOME_TYPE = dr.INCOME_TYPE;
                    result.SAVINGS_TYPE = dr.SAVINGS_TYPE;

                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                TAX_CODE result = new TAX_CODE();
                
                result.DESCRIPTIONS = dr.DESCRIPTIONS;
                result.UNDER_SECTION = dr.UNDER_SECTION;
                result.INCOME_TYPE = dr.INCOME_TYPE;
                result.SAVINGS_TYPE = dr.SAVINGS_TYPE;
                db1.TAX_CODE.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static TAX_CODE_Base generate_Base(TAX_CODE dr)
        {
            TAX_CODE_Base drb = Mapper.DynamicMap<TAX_CODE, TAX_CODE_Base>(dr);

            return drb;

       
        }

        public static List<TAX_CODE_Base> generate_Base(ICollection<TAX_CODE> i)
        {
            List<TAX_CODE_Base> drbl = Mapper.DynamicMap<ICollection<TAX_CODE>, List<TAX_CODE_Base>>(i);

            return drbl;
        
        }
    }
}
