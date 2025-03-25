using APBD_cw2.Models.Exceptions;
using APBD_cw2.Models.Interfaces;
using APBD_cw2.Models.SerialNumbers;

namespace APBD_cw2.Models.Containers;

public class CoolingContainer : AContainer
{
    public CoolingContainer(string productType, double temperature, double maxCapacity, double cargoMass) : base(maxCapacity, cargoMass)
    {
        ProductType = productType;
        Temperature = temperature;
    }
    private string ProductType { get; set; }
    private double Temperature { get; set; }

    private Dictionary<string, double> ProductToTemperature { get; set; } = new Dictionary<string, double>()
    {
        { "bananas", 13.3 },
        { "chocolate", 18 },
        { "fish", 2 },
        { "meat", -15 },
        { "ice cream", -18 },
        { "frozen pizza", -30 },
        { "cheese", 7.2 },
        { "sausages", 5 },
        { "butter", 20.5 },
        { "eggs", 19 }
    };
        
    
    public override string TypeOfContainer()
    {
        return "C";
    }

    public override void EmptyTheCargo()
    {
        CargoMass = 0;
    }

    public override void LoadTheCargo(double cargoToLoad)
    {
        if (CargoMass + cargoToLoad > MaxCargoMass)
        {
            throw new OverfillException("Masa ładunku większa niż pojemność kontenera");
        }
        else if (!ProductToTemperature.ContainsKey(ProductType))
        {
            Console.WriteLine("produktu nie ma w systemie");
            return;
        }
        else if (ProductToTemperature[ProductType] > Temperature)
        {
            Console.WriteLine("temperatura kontenera nie może być niższa niż temperatura wymagana przez dany rodzaj produktu");
            Temperature = ProductToTemperature[ProductType];
        }
        
        CargoMass += cargoToLoad;
    }
    
    public override string ToString()
    {
        return $"Kontener: {SerialNumber} zawiera w ładunku {ProductType}, waga: {CargoMass}";
    }

}

