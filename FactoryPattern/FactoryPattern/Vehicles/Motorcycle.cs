namespace FactoryPattern.Vehicles;

public class Motorcycle: IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a motorcycle");
    }
}