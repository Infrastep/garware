using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class helper
    {
        private int _draw;

        public int draw
        {
            get { return _draw; }
            set { _draw = value; }
        }

        private int _recordsTotal;

        public int recordsTotal
        {
            get { return _recordsTotal; }
            set { _recordsTotal = value; }
        }

        private int _recordsFiltered;

        public int recordsFiltered
        {
            get { return _recordsFiltered; }
            set { _recordsFiltered = value; }
        }

        private List<EMP_FIXED_Base> _data = new List<EMP_FIXED_Base>();

        public List<EMP_FIXED_Base> data
        {
            get { return _data; }
            set { _data = value; }
        }

        
       
    }
}
