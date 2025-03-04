using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalization
{
    public class FinalizableClass
    {
        public int Value1;
        public int Value2;
        public int Value3;
        public int Value4;
        ~FinalizableClass()
        {
        }
    }
}
