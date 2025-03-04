using Common.Models;
using Deployment;
using Manufacturing;
using Manufacturing.Gadgets;
using System.Collections.Concurrent;

var cancellationTokenSource = new CancellationTokenSource();
var producedGadgets = new BlockingCollection<HighTechGadget>();

var productionLine = new ProductionLine(producedGadgets, cancellationTokenSource);
var distribution = new Distribution();

var produceTask = Task.Run(() => productionLine.ProduceGadgets());
var distributeTask = Task.Run(() => distribution.DistributeGadgets(producedGadgets));

Console.WriteLine("Press Enter to stop...");
Console.ReadLine();

cancellationTokenSource.Cancel();
producedGadgets.CompleteAdding();

await Task.WhenAll(produceTask, distributeTask);

Console.WriteLine("Distribution completed. Press any key to exit...");
Console.ReadKey();
