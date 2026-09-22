using WestcoastCars.Enums;
using WestcoastCars.Models;

namespace WestcoastCars;

class Program
{
    static void Main()
    {
        // Car car = new("ABC123")
        // {
        //     Engine = new Engine() { EngineEffect = 1700, EngineVolume = 3.0, FuelType = FuelTypeEnum.Bensin, HorsePower = 250 },
        //     Manufacturer = new Manufacturer() { Name = "Volvo" },
        //     Model = new VehicleModel() { Name = "XC60" },
        //     Mileage = 155000,
        //     ModelYear = 2016,
        //     Color = "Gray Metallic",
        //     Description = "Bra skick, körd långa sträckor",
        //     Equipments = ["Navigator", "Business paket"],
        //     Price = 235500,
        //     // RegistrationNumber = "ABC123",
        //     TransmissionType = TransmissionTypeEnum.Automat,
        // };

        // Console.WriteLine(car);

        // Bike bike = new("")
        // {
        //     Manufacturer = new() { Name = "Kawasaki" },
        //     Model = new() { Name = "Z900" },
        //     BikeType = "SuperNaked",
        //     Engine = new() { EngineEffect = 70, EngineVolume = 948, FuelType = FuelTypeEnum.Bensin, HorsePower = 0 },
        //     Mileage = 100,
        //     ModelYear = 2027,
        //     Color = "Green and silver",
        //     Description = "Denna Z900 supernaked markerar den mest utvecklade versionen av Sugomi och kombinerar en radikal streetfighter-attityd med premiumfunktioner",
        //     Price = 111400
        // };

        // Console.WriteLine(bike);

        // Truck truck = new("HKJ001")
        // {
        //     Manufacturer = new() { Name = "Fiat" },
        //     Model = new() { Name = "Ducato 2.3" },
        //     Engine = new() { EngineEffect = 96, EngineVolume = 2287, FuelType = FuelTypeEnum.Diesel, HorsePower = 130 },
        //     Mileage = 330000,
        //     ModelYear = 2017,
        //     Color = "Vit",
        //     Description = "Fiat ducato 2.3 Skåpbil BAKGAVELLYFT Automat Värmare Sidodörr",
        //     Price = 229800,
        //     Equipments = ["Dieselvärmare", "AC", "Motorvärmare", "Bakgavellyft", "Navigator"],
        //     TailLift = true,
        //     MaxLoad = 3500,
        //     TransmissionType = TransmissionTypeEnum.Automat
        // };

        // Console.WriteLine(truck);

        // // Polyformism...
        // List<Vehicle> vehicles = [car, truck, bike];

        // Console.WriteLine("");
        // Console.ForegroundColor = ConsoleColor.Yellow;
        // Console.WriteLine("foreach loopen");
        // Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        // Console.ForegroundColor = ConsoleColor.Blue;

        // Console.ForegroundColor = ConsoleColor.Green;
        // foreach (Vehicle vehicle in vehicles)
        // {
        //     Console.WriteLine(vehicle);
        // }
        // Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        // Console.WriteLine("");
        // Console.ForegroundColor = ConsoleColor.Yellow;
        // Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        // Console.ResetColor();

        // Private person = new("Eva", "Olsson")
        // {
        //     Address = new()
        //     {
        //         AddressLine = "Västergårdsvägen 1",
        //         PostalCode = "123 45",
        //         City = "Storstaden",
        //         AddressType = AddressTypeEnum.Hem
        //     }
        // };


        // Console.WriteLine("Privatkund");
        // Console.ForegroundColor = ConsoleColor.Yellow;
        // Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        // Console.ForegroundColor = ConsoleColor.Magenta;
        // Console.WriteLine(person);
        // Console.ForegroundColor = ConsoleColor.Yellow;
        // Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        // Console.WriteLine("");
        // Console.ResetColor();

        // Company company = new("Bluff & Båg AB", "551245-8976");

        // company.Addresses.Add(new Address() { AddressLine = "Gatan 2", PostalCode = "456 78", City = "Staden", AddressType = AddressTypeEnum.Faktura });
        // company.Addresses.Add(new Address() { AddressLine = "Box 2", PostalCode = "456 78", City = "Staden", AddressType = AddressTypeEnum.Leverans });


        // Console.WriteLine("Företagskund");
        // Console.ForegroundColor = ConsoleColor.Yellow;
        // Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        // Console.ForegroundColor = ConsoleColor.DarkBlue;
        // Console.WriteLine(company);
        // Console.ForegroundColor = ConsoleColor.Yellow;
        // Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        // Console.ResetColor();

    }
}
