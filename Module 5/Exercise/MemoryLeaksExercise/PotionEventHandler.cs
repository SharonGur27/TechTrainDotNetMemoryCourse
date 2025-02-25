using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryLeaksExercise
{
    class PotionEventHandler
    {
        public event EventHandler PotionEvent;

        public void Handle()
        {
            var source = new PotionEventSource();
            source.Event += OnPotionEvent;
        }

        private void OnPotionEvent(object sender, EventArgs e)
        {
            // Event handler logic
        }
    }
}
