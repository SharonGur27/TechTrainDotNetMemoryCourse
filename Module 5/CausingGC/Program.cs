// A program that allocates memory in order to show GC behavior in the Allocation Profiler

using CausingGC;

for (int i = 0; i < 100000; i++)
{
    await BytesAllocator.AllocateBytes();
}

Console.ReadKey();