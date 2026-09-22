namespace WestcoastCars.Models;

public class Truck(string regNo) : Car(regNo)
{
    public bool TailLift { get; set; }
    public int MaxLoad { get; set; }
    public int Tara { get; set; }

    public override string ToString()
    {
        string tailLift;
        // if (TailLift == true)
        //     tailLift = "Ja";
        // else
        //     tailLift = "Nej";

        tailLift = TailLift == true ? "Ja" : "Nej";
        return $"{base.ToString()} Bakgavellyft: {tailLift}";
    }
}
