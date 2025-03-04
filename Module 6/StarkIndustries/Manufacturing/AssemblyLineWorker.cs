using System;
using System.Reflection;
using System.Threading;

namespace Manufacturing
{
    public class AssemblyLineWorker
    {
        private Thread _workerThread;
        private Thread _removeThread;

        private CancellationTokenSource _cancellationTokenSource;
        private List<byte[]?> _largeObjects = new List<byte[]?>(); // List to hold large objects

        public void StartWorker(CancellationTokenSource cancellationTokenSource)
        {
            _cancellationTokenSource = cancellationTokenSource;
            _workerThread = new Thread(AllocateLargeObjects);
            _workerThread.Start();
            _removeThread = new Thread(DiscardLargeObjects);
            _removeThread.Start();
        }

        private void AllocateLargeObjects()
        {
            // Allocate large objects
            while (!_cancellationTokenSource.IsCancellationRequested)
            {
                _largeObjects.Add(new byte[1024 * 1024]); // Allocate 1MB
            }
        }

        private void DiscardLargeObjects()
        {
            Task.Delay(3000).Wait(); // Wait for 1 second before starting to discard objects

            int i = 0;
            while (!_cancellationTokenSource.IsCancellationRequested)
            {
                if (i < _largeObjects.Count && i % 3 == 0)
                {
                    _largeObjects[i] = null;
                }

                i++;
            }
        }
    }
}