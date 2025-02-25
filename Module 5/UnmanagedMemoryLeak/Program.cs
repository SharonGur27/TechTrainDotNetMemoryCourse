using System.Drawing;

Console.ReadLine();

while (!Console.KeyAvailable)
{
    await CreateMemoryLeakAsync();
}


static Task CreateMemoryLeakAsync()
{
    Bitmap bitmap = new Bitmap(1000, 1000);
    // The Bitmap object is discarded here, but because it's an unmanaged resource and we didn't call Dispose,
    // the memory it occupies won't be released, causing a memory leak.

    return Task.CompletedTask;
}