using Manufacturing;

var productionLine = new ProductionLine();
await productionLine.StartProductionAsync();

Console.WriteLine("Production completed. Press any key to exit...");
Console.ReadKey();
