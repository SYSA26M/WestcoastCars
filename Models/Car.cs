namespace WestcoastCars.Models;

public class Car : Vehicle
{
    public string TransmissionType { get; set; } = "";

    public override string ToString()
    {
        return $"{base.ToString()} Växellåda: {TransmissionType}";
    }
}
