using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryLeaksExercise
{
    class PotionEventHandler
    {
        public void Handle(PotionEventSource source)
        {
            source.Event += OnPotionEvent;
        }

        private void OnPotionEvent(object sender, EventArgs e)
        {
            // Event handler logic
        }
    }
}
