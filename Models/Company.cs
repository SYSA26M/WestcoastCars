namespace WestcoastCars.Models;

public class Company(string name, string orgNo) : Customer
{
    public string OrganizationNumber { get; set; } = orgNo;
    public string Name { get; set; } = name;
    public List<Address> Addresses { get; set; } = [];

    public override string ToString()
    {
        string addresses = "";
        foreach (Address address in Addresses)
        {
            addresses += string.Concat(address, "\n");
        }
        return $"Namn: {Name} {base.ToString()} \n{addresses}";
    }
}
