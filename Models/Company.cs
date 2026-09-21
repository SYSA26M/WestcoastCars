namespace WestcoastCars;

public class Company : Customer
{
    public string OrganizationNumber { get; set; } = "";
    public string Name { get; set; } = "";
    public required List<Address> Addresses { get; set; }
}
