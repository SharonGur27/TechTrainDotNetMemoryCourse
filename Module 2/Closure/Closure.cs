using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closure
{
    internal class Closure
    {
        public void Example()
        {
            int _capturedVariable = 42;

            Action _closure = () => Console.WriteLine(_capturedVariable);
        }
    }
}
