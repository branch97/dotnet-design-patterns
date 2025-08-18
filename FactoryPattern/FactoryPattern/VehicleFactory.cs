using FactoryPattern.Vehicles;

namespace FactoryPattern;

public class VehicleFactory
{
    public IVehicle CreateVehicle(string type)
    {
        return type.ToLower() switch
        {
            "car" => new Car(),
            "truck" => new Truck(),
            "motorcycle" => new Motorcycle(),
            _ => throw new ArgumentException("Unknown vehicle type")
        };
    }
}
