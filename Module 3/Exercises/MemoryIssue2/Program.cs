// Import the GlobalAlloc function from kernel32.dll
using System.Runtime.InteropServices;

namespace MemoryIssue2
{
    class Program
    {
        // Import the GlobalAlloc function from kernel32.dll
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GlobalAlloc(uint uFlags, UIntPtr dwBytes);

        // Import the GlobalFree function from kernel32.dll
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GlobalFree(IntPtr hMem);

        // Constants for memory allocation
        private const uint GMEM_FIXED = 0x0000;
        private const int ALLOCATION_SIZE = 10 * 1024 * 1024; // 10 MB

        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to stop the application...");

            while (!Console.KeyAvailable)
            {
                // Allocate unmanaged memory
                IntPtr unmanagedMemory = GlobalAlloc(GMEM_FIXED, (UIntPtr)ALLOCATION_SIZE);

                // Simulate some work
                Thread.Sleep(100);

                // Print the current memory usage
                Console.WriteLine($"Allocated unmanaged memory: {ALLOCATION_SIZE / (1024 * 1024)} MB");

                // Note: We are not freeing the allocated memory, causing an unmanaged memory leak
            }

            Console.WriteLine("Application stopped.");
        }
    }
}