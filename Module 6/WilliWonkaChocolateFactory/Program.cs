using WilliWonkaChocolateFactory;


var factory = new CandyFactory();

while (!Console.KeyAvailable)
{
    factory.StartProduction();

    Task.Delay(100).Wait();

    factory.StopProduction();

    factory.DisplayProducedCandies();
}

Console.WriteLine("Candy production completed. Press any key to exit...");

