namespace WestcoastCars.Models;

public class Bike(string regNo) : Vehicle(regNo)
{
    public string BikeType { get; set; } = "";

    public override string ToString()
    {
        return $"{base.ToString()} Typ: {BikeType}";
    }

    public override void UpdateVehicle()
    {
        Console.WriteLine("Uppdaterar motorcykeln");
    }
}
