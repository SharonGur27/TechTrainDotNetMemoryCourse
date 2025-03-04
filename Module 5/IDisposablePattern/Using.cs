using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposablePattern
{
    class Using
    {
        public static void UsingMethod()
        {
            using (var example = new Example())
            {
                Console.WriteLine("Inside using block");
            } // Dispose is called here
        }
    }
}
