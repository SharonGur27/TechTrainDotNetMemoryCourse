using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryLeak
{
    internal class ManufacturerFactory
    {
        public static IManufacturer GetManufacturerA() 
        {
            return new ManufacturerA();
        }
    }
}
