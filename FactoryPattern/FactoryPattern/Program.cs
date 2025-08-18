using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using FactoryPattern;

var host = Host.CreateApplicationBuilder(args);

host.Services.AddSingleton<VehicleFactory>();
host.Services.AddHostedService<VehicleService>();

await host.Build().RunAsync();