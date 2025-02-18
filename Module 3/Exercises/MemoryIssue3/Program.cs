
Console.WriteLine("Press any key to stop the application...");

while (!Console.KeyAvailable)
{
    // Allocate and deallocate memory in a loop
    for (int i = 0; i < 1000; i++)
    {
        byte[] memoryChunk = new byte[1024 * 1024]; // 1 MB
    }

    // Simulate some work
    Thread.Sleep(100);

    // Print the current memory usage
    Console.WriteLine($"Allocated memory: {GC.GetTotalMemory(false) / (1024 * 1024)} MB");
}

Console.WriteLine("Application stopped.");

