namespace WestcoastCars.Models;

public class Manufacturer
{
    public required string Name { get; set; }
    List<VehicleModel> Models { get; set; } = [];
}
