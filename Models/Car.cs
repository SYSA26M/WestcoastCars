using WestcoastCars.Enums;

namespace WestcoastCars.Models;

public class Car : Vehicle
{
    public TransmissionTypeEnum TransmissionType { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()} Växellåda: {TransmissionType}";
    }
}
