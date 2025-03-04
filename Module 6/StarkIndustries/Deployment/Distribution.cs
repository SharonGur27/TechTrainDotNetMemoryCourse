using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Models;
using Manufacturing;
using Manufacturing.Gadgets;

namespace Deployment
{
    public class Distribution
    {
        private List<HighTechGadget> _distributedGadgets = new ();

        public void DistributeGadgets(BlockingCollection<HighTechGadget> highTechGadgets)
        {
            foreach (var gadget in highTechGadgets.GetConsumingEnumerable())
            {
                _distributedGadgets.Add(gadget);
                Console.WriteLine($"Distributed gadget: {gadget.Name} of type {gadget.Model}");
            }
        }
    }
}