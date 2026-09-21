using WestcoastCars.Models;

namespace WestcoastCars;

class Program
{
    static void Main()
    {
        Car car = new()
        {
            Engine = new Engine() { EngineEffect = 1700, EngineVolume = 3.0, FuelType = "Bensin", HorsePower = 250 },
            Manufacturer = new Manufacturer() { Name = "Volvo" },
            Model = new VehicleModel() { Name = "XC60" },
            Mileage = 155000,
            ModelYear = 2016,
            Color = "Gray Metallic",
            Description = "Bra skick, körd långa sträckor",
            Equipments = ["Navigator", "Business paket"],
            Price = 235500,
            RegistrationNumber = "ABC123",
            TransmissionType = "Automat",
        };

        Console.WriteLine(car);

        Bike bike = new()
        {
            Manufacturer = new() { Name = "Kawasaki" },
            Model = new() { Name = "Z900" },
            BikeType = "SuperNaked",
            Engine = new() { EngineEffect = 70, EngineVolume = 948, FuelType = "Bensin", HorsePower = 0 },
            Mileage = 100,
            ModelYear = 2027,
            Color = "Green and silver",
            Description = "Denna Z900 supernaked markerar den mest utvecklade versionen av Sugomi och kombinerar en radikal streetfighter-attityd med premiumfunktioner",
            Price = 111400
        };

        Console.WriteLine(bike);

        Truck truck = new()
        {
            Manufacturer = new() { Name = "Fiat" },
            Model = new() { Name = "Ducato 2.3" },
            Engine = new() { EngineEffect = 96, EngineVolume = 2287, FuelType = "Diesel", HorsePower = 130 },
            Mileage = 330000,
            ModelYear = 2017,
            Color = "Vit",
            Description = "Fiat ducato 2.3 Skåpbil BAKGAVELLYFT Automat Värmare Sidodörr",
            Price = 229800,
            Equipments = ["Dieselvärmare", "AC", "Motorvärmare", "Bakgavellyft", "Navigator"],
            RegistrationNumber = "HKJ001",
            TailLift = true,
            MaxLoad = 3500,
            TransmissionType = "Automat"
        };

        Console.WriteLine(truck);

        // Polyformism...
        List<Vehicle> vehicles = [car, truck, bike];

        Console.WriteLine("");
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("foreach loopen");
        Console.ResetColor();

        foreach (Vehicle vehicle in vehicles)
        {
            Console.WriteLine(vehicle);
        }
    }
}
