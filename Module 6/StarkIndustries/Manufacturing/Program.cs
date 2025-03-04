using Manufacturing;
using Manufacturing.Gadgets;
using System.Collections.Concurrent;

var cancellationTokenSource = new CancellationTokenSource();
var gadgets = new BlockingCollection<HighTechGadget>();
var productionLine = new ProductionLine(gadgets, cancellationTokenSource);

productionLine.ProduceGadgets();

// Keep the console open
Console.ReadKey();

cancellationTokenSource.Cancel();

Console.WriteLine("Production completed. Press any key to exit...");

