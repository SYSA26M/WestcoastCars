namespace WestcoastCars;

public class Customer
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Email { get; set; } = "";
    public string Phone { get; set; } = "";
    public void AddCustomer() { }
    public void UpdateCustomer() { }
    public void RemoveCustomer() { }
}
