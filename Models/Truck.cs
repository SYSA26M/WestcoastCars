namespace WestcoastCars.Models;

public class Truck : Car
{
    public bool TailLift { get; set; }
    public int MaxLoad { get; set; }
    public int Tara { get; set; }

    public override string ToString()
    {
        string tailLift = TailLift == true ? "Ja" : "Nej";
        return $"{base.ToString()} Bakgavellyft: {tailLift}";
    }
}
