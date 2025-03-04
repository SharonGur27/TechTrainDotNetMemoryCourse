using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryLeaksExercise
{
    class PotionEventSource
    {
        public event EventHandler Event;

        public void RaiseEvent()
        {
            Event?.Invoke(this, EventArgs.Empty);
        }
    }
}
