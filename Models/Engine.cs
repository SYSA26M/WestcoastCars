using WestcoastCars.Enums;

namespace WestcoastCars.Models;

public class Engine
{
    public int HorsePower { get; set; }
    public int EngineEffect { get; set; }
    public double EngineVolume { get; set; }
    public FuelTypeEnum FuelType { get; set; }
}
