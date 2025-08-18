using FactoryPattern.Vehicles;
using Microsoft.Extensions.Hosting;

namespace FactoryPattern;

public class VehicleService(VehicleFactory vehicleFactory) : BackgroundService
{
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        IVehicle car = vehicleFactory.CreateVehicle("car");
        car.Drive();

        IVehicle truck = vehicleFactory.CreateVehicle("truck");
        truck.Drive();

        IVehicle motorcycle = vehicleFactory.CreateVehicle("motorcycle");
        motorcycle.Drive();

        return Task.CompletedTask;
    }
}

