using ConsoleApp.src;
using ConsoleApp.src.Interfaces;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();

var serviceProvider = serviceCollection
    .AddTransient<ICar, Car>()
    .AddTransient<IEngine, Engine>()
    .BuildServiceProvider();

var car = serviceProvider.GetService<ICar>();

car?.StartEngine();

Console.ReadKey();