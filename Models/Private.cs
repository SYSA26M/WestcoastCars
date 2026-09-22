namespace WestcoastCars.Models;

public class Private(string firstName, string lastName) : Customer
{
    public string? PersonalNumber { get; set; }
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public required Address Address { get; set; }

    public override string ToString()
    {
        return $"Namn: {FirstName} {LastName} {base.ToString()} {Address}";
    }
}
