using MemoryLeaksExercise;


// Example 1: Event Handler Leak
PotionEventHandling();

// Example 2: Static Reference Leak
PotionStorage();

// Example 3: Closure in Anonymous Methods
await PotionMixing();

Console.WriteLine("Potion brewing examples are running. Press any key to exit...");
Console.ReadKey();

static void PotionEventHandling()
{
    for (int i = 0; i < 1000000; i++)
    {
        var handler = new PotionEventHandler();
        handler.Handle();
        Task.Delay(1000);
    }
}

static void PotionStorage()
{
    for (int i = 0; i < 1000000; i++)
    {
        var storage = new PotionStorage();
        storage.Store();
        Task.Delay(1000);
    }
}

static async Task PotionMixing()
{
    for (int i = 0; i < 1000000; i++)
    {
        var mixer = new PotionMixer();
        await mixer.MixAsync();
        Task.Delay(1000);
    }
}