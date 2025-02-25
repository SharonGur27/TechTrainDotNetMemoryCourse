using Deployment;

var distribution = new Distribution();
await distribution.StartDistributionAsync();

Console.WriteLine("Distribution completed. Press any key to exit...");
Console.ReadKey();