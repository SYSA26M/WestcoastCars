namespace WestcoastCars;

public class Vehicle
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string RegistrationNumber { get; set; } = "";
    public string Manufacturer { get; set; } = "";
    public string Model { get; set; } = "";
    public int ModelYear { get; set; }
    public int Mileage { get; set; }
    public string Color { get; set; } = "";
    public string Description { get; set; } = "";
    public double Price { get; set; }
    public bool IsSold { get; set; }
    public List<string> Equipments { get; set; } = [];

    public void AddVehicle() { }
    public void UpdateVehicle() { }
    public void RemoveVehicle() { }
}
