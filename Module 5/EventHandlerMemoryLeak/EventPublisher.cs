namespace EventHandlerMemoryLeak
{
    internal class EventPublisher
    {
        public event Action MyEvent = delegate { };
    }
}