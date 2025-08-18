namespace FactoryPattern.Vehicles;

public class Truck: IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a truck");
    }
}