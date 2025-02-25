using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CausingGC
{
    internal class BytesAllocator
    {
        internal static Task AllocateBytes()
        {
            List<byte[]> memoryHolder = [];

            for (int i = 0; i < 100000; i++)
            {
                byte[] buffer = new byte[1000];
                memoryHolder.Add(buffer);
            }

            return Task.CompletedTask;
        }
    }
}
