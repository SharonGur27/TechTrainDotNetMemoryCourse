using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Common.Models;
using Manufacturing.Gadgets;

namespace Manufacturing
{
    public class ProductionLine
    {
        private readonly BlockingCollection<HighTechGadget> _producedGadgets;
        private AssemblyLineWorker _assemblyLineWorker = new AssemblyLineWorker();
        private CancellationTokenSource _cancellationTokenSource;

        public ProductionLine(BlockingCollection<HighTechGadget> producedGadgets, CancellationTokenSource cancellationTokenSource)
        {
            _cancellationTokenSource = cancellationTokenSource;
            _producedGadgets = producedGadgets;
            _assemblyLineWorker.StartWorker(cancellationTokenSource);
        }

        public void ProduceGadgets()
        {
            while (!_cancellationTokenSource.Token.IsCancellationRequested)
            {
                var gadget = CreateRandomGadget();
                _producedGadgets.Add(gadget);
                Console.WriteLine($"Produced gadget: {gadget.Name} of type {gadget.Model}");
            }
        }

        private HighTechGadget CreateRandomGadget()
        {
            var random = new Random();
            switch (random.Next(2))
            {
                case 0:
                    return new ArcReactor();
                case 1:
                    return new IronManSuit();
                default:
                    return new ArcReactor();
            }
        }
    }
}