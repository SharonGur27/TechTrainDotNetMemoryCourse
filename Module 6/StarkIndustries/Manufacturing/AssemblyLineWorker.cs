using System;
using System.Threading;

namespace Manufacturing
{
    public class AssemblyLineWorker
    {
        private Thread _workerThread;

        public void StartWorker()
        {
            _workerThread = new Thread(WorkerMethod);
            _workerThread.Start();
        }

        private void WorkerMethod()
        {
            while (true)
            {
                // Simulate some work
                Thread.Sleep(1000);
            }
        }

        public void StopWorker()
        {
            // Intentionally not stopping the thread properly
        }
    }
}