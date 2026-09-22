namespace WestcoastCars.Models;

public class Address
{
    public string AddressLine { get; set; } = "";
    public string PostalCode { get; set; } = "";
    public string City { get; set; } = "";
    public string Country { get; set; } = "Sverige";
    public required AddressTypeEnum AddressType { get; set; }

    public override string ToString()
    {
        return $"Adresstyp: {AddressType} - {AddressLine}, {PostalCode}, {City} {Country.ToUpper()}";
    }
}
