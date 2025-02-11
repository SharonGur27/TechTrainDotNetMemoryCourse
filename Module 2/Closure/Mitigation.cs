using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closure
{
    internal class Mitigation
    {
        // Avoid capturing variables from the enclosing scope.
        // Instead, pass the variables as parameters to the closure if possible.
        public void Example()
        {
            int capturedVariable = 42;
            Action<int> closure = (value) => Console.WriteLine(value);
            closure(capturedVariable);
        }
    }
}
