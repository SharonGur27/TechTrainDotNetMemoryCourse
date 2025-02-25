using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposablePattern
{
    internal class Example : IDisposable
    {
        private bool _disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Put here code required only in case of explicit Dispose call
                }

                // Common cleanup - including unmanaged resources

                _disposed = true;
            }
        }

        ~Example()
        {
            Dispose(false);
        }
    }
}
