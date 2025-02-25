using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Manufacturing.Gadgets;

namespace Manufacturing
{
    public class ProductionLine
    {
        private List<HighTechGadget> _gadgets = new List<HighTechGadget>();
        private AssemblyLineWorker _assemblyLineWorker = new AssemblyLineWorker();
        private List<Action> _productionReports = new List<Action>();
        private List<byte[]> _productionLogs = new List<byte[]>(); // List to hold large objects representing production logs

        public async Task StartProductionAsync()
        {
            _assemblyLineWorker.StartWorker();

            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(100);
                Console.WriteLine($"Producing gadget batch {i}");

                // Create different types of gadgets
                var ironManSuit = new IronManSuit();
                var arcReactor = new ArcReactor();

                // Introduce memory issues
                _gadgets.Add(ironManSuit);
                _gadgets.Add(arcReactor);

                // Closure memory leak
                var productionLog = new byte[1024 * 1024]; // 1MB array representing a production log
                _productionLogs.Add(productionLog); // Retain large objects to increase memory pressure
                Action productionReport = () => Console.WriteLine($"Gadget {i} produced with production log size: {productionLog.Length}");
                _productionReports.Add(productionReport);

                ironManSuit.OnProduced += (sender, args) => productionReport();
                arcReactor.OnProduced += (sender, args) => productionReport();
            }
        }

        public void StopProduction()
        {
            _assemblyLineWorker.StopWorker();
        }
    }
}