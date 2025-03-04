using MemoryLeaksExercise;
using System.Threading;

// Create a CancellationTokenSource
var cts = new CancellationTokenSource();
CancellationToken token = cts.Token;

// Example 1: Event Handler Leak
PotionEventSource source = new();
Task eventHandlingTask = PotionEventHandling(source, token);

// Example 2: Static Reference Leak
PotionStorage storage = new();
Task storageTask = PotionStorage(storage, token);

// Example 3: Closure in Anonymous Methods
Task mixingTask = PotionMixing(token);

// Run all tasks simultaneously
Task allTasks = Task.WhenAll(eventHandlingTask, storageTask, mixingTask);

Console.WriteLine("Potion brewing examples are running. Press any key to exit...");
Console.ReadKey();

// Signal cancellation
cts.Cancel();

try
{
    await allTasks;
}
catch (OperationCanceledException)
{
    Console.WriteLine("Tasks were cancelled.");
}

static async Task PotionEventHandling(PotionEventSource source, CancellationToken token)
{
    while (!token.IsCancellationRequested)
    {
        var handler = new PotionEventHandler();
        handler.Handle(source);
        await Task.Delay(10, token);
    }
}

static async Task PotionStorage(PotionStorage storage, CancellationToken token)
{
    while (!token.IsCancellationRequested)
    {
        storage.Store();
        await Task.Delay(10, token);
    }
}

static async Task PotionMixing(CancellationToken token)
{
    while (!token.IsCancellationRequested)
    {
        var mixer = new PotionMixer();
        await mixer.MixAsync();
        await Task.Delay(10, token);
    }
}