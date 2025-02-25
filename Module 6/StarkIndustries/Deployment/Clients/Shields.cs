using System;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using Common.Models;

namespace Deployment.Clients
{
    public class Shield : Client
    {
        private IntPtr _unmanagedMemory;

        public Shield()
        {
            Name = "S.H.I.E.L.D.";
            Location = "Washington, D.C.";
            _unmanagedMemory = Marshal.AllocHGlobal(1024 * 1024); // Allocate 1MB
            // Intentionally not freeing the unmanaged memory
            RaiseReceivedEvent();
        }

        ~Shield()
        {
            // Destructor to free unmanaged memory (not implemented) (Finalizer Issues)
        }

        public override string GetDescription()
        {
            return $"{Name} - Located in {Location}";
        }
    }
}