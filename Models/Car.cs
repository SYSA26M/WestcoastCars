using WestcoastCars.Enums;

namespace WestcoastCars.Models;

public class Car(string registrationNumber) : Vehicle(registrationNumber)
{
    public TransmissionTypeEnum TransmissionType { get; set; }
    public override void AddVehicle()
    {
        Console.WriteLine("Car lägger till ett fordon");
    }

    public override string ToString()
    {
        return $"{base.ToString()} Växellåda: {TransmissionType}";
    }

    public override void UpdateVehicle()
    {
        Console.WriteLine("Uppdaterar bilen");
    }
}
