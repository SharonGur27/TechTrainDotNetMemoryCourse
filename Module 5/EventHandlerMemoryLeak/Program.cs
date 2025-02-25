using EventHandlerMemoryLeak;

EventPublisher publisher = new EventPublisher();

Console.ReadLine();

while (!Console.KeyAvailable)
{
    EventSubscriber subscriber = new EventSubscriber(publisher);
    // The subscriber object is discarded here, but because it's still attached to the event,
    // it won't be garbage collected, causing a memory leak.
}