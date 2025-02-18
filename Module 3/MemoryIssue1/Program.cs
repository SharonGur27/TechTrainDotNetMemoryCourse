
List<byte[]> memoryLeakList = [];
Console.WriteLine("Press any key to stop the application...");

while (!Console.KeyAvailable)
{
    // Allocate 10 MB of memory and add it to the list
    byte[] memoryChunk = new byte[10 * 1024 * 1024];
    memoryLeakList.Add(memoryChunk);

    // Simulate some work
    Thread.Sleep(100);

    // Print the current memory usage
    Console.WriteLine($"Allocated memory: {GC.GetTotalMemory(false) / (1024 * 1024)} MB");
}

Console.WriteLine("Application stopped.");
