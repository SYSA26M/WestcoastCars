namespace WestcoastCars.Models;

public class Private : Customer
{
    public string PersonalNumber { get; set; } = "";
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public required Address Address { get; set; }
}
