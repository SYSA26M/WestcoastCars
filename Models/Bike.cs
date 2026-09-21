namespace WestcoastCars.Models;

public class Bike : Vehicle
{
    public string BikeType { get; set; } = "";

    public override string ToString()
    {
        return $"{base.ToString()} Typ: {BikeType}";
    }
}
