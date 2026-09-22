namespace WestcoastCars.Models;

public abstract class Vehicle
{
    public Vehicle(string regNo)
    {
        RegistrationNumber = regNo;
    }
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string RegistrationNumber { get; set; }
    public required Manufacturer Manufacturer { get; set; }
    public required VehicleModel Model { get; set; }
    public int ModelYear { get; set; }
    public int Mileage { get; set; }
    public string Color { get; set; } = "";
    public string Description { get; set; } = "";
    public double Price { get; set; }
    public bool IsSold { get; set; }
    public List<string> Equipments { get; set; } = [];
    public required Engine Engine { get; set; }

    public virtual void AddVehicle()
    {
        Console.WriteLine("Mamma lägger till ett fordon");
    }
    public virtual void UpdateVehicle()
    {
        Console.WriteLine("Mamma uppdaterar ett fordon");
    }
    public virtual void RemoveVehicle()
    {
        Console.WriteLine("Mamma tar bort ett fordon");
    }
    public override string ToString()
    {
        return $"Tillverkare: {Manufacturer.Name} Modell: {Model.Name} Årsmodell: {ModelYear}";
    }
}
