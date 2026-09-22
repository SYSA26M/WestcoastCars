namespace WestcoastCars.Models;

public abstract class Customer
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Email { get; set; } = "";
    public string Phone { get; set; } = "";
    public virtual void AddCustomer() { }
    public virtual void UpdateCustomer() { }
    public virtual void RemoveCustomer() { }

    public override string ToString()
    {
        return $"E-Post: {Email} Telefon: {Phone}";
    }
}
