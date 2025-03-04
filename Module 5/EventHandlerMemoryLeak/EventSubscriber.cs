namespace EventHandlerMemoryLeak
{
    internal class EventSubscriber
    {
        private EventPublisher _publisher;

        public EventSubscriber(EventPublisher publisher)
        {
            _publisher = publisher;
            _publisher.MyEvent += HandleEvent;
        }

        private void HandleEvent()
        {
            // Handle the event here.
        }
    }
}