namespace MemoryLeakExamples
{
    internal class PerpetualThread
    {
        public PerpetualThread()
        {
            Timer timer = new Timer(HandleTick!);
            timer.Change(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(5));
        }

        private void HandleTick(object state)
        {
            // do something
        }
    }
}
