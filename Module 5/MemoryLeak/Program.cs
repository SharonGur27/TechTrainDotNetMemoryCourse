using MemoryLeak;

List<Product> products = [];

while (true)
{
    var product = new Product { Id = Guid.NewGuid(), Manufacturer = ManufacturerFactory.GetManufacturerA() };
    products.Add(product);
}

