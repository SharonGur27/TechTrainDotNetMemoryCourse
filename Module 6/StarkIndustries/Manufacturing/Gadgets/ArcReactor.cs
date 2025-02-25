using System;
using System.Runtime.InteropServices;

namespace Manufacturing.Gadgets
{
    public class ArcReactor : HighTechGadget
    {
        private IntPtr _unmanagedMemory;

        public ArcReactor()
        {
            Name = "Arc Reactor";
            Model = "Palladium";
            Weight = 2000; // 2 kg
            _unmanagedMemory = Marshal.AllocHGlobal(1024 * 1024); // Allocate 1MB (LOH Fragmentation)
            // Intentionally not freeing the unmanaged memory
            RaiseProducedEvent();
        }

        ~ArcReactor()
        {
            // Destructor to free unmanaged memory (not implemented) (Finalizer Issues)
        }

        public override string GetDescription()
        {
            return $"{Name} - {Model} model, {Weight} grams";
        }
    }
}