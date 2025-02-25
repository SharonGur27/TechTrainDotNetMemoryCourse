
using System.Runtime;

Console.WriteLine("Fragmented Memory Example");
Console.ReadLine();

int iterations64 = 100000000;
int byteArraySize64 = 100000;

Console.WriteLine("Start Allocating");

// Create a list to hold onto our byte arrays
List<byte[]?> arrays = [];
int lastArrayRemovalIndex = 0;

for (int i = 0; i < iterations64; i++)
{
    // Allocate a 100,000 byte array (which will go into the LOH)
    byte[] largeArray = new byte[byteArraySize64];
    arrays.Add(largeArray);

    // Occasionally, remove both even and odd-indexed arrays
    // This will leave "holes" in the LOH
    if (i % 100 == 0)
    {
        for (int j = lastArrayRemovalIndex; j < i; j += 2)
        {
            arrays[j] = null;
        }

        lastArrayRemovalIndex = i;
    }
}


try
{
    // At this point, the LOH is fragmented
    // Now, try to allocate a large array that requires a contiguous block of memory
    // This will fail with an OutOfMemoryException if the LOH is too fragmented
    byte[] veryLargeArray = new byte[byteArraySize64 * 10];
}
catch (OutOfMemoryException)
{
    Console.WriteLine("Failed to allocate a large array due to fragmentation");
}

Console.WriteLine("Exiting...");


/*
 * **** GC Compaction Mode  *******
    GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;
    GC.Collect();
*/

/***** GC Latency Mode ******
       // Set SustainedLowLatency mode
        GCSettings.LatencyMode = GCLatencyMode.SustainedLowLatency;

        // Your time-sensitive operations go here

        // Return to the default mode (if needed)
        GCSettings.LatencyMode = GCLatencyMode.Interactive;

 */