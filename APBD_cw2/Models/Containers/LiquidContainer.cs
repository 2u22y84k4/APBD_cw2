using APBD_cw2.Models.Exceptions;
using APBD_cw2.Models.Interfaces;
using APBD_cw2.Models.SerialNumbers;

namespace APBD_cw2.Models.Containers;

public class LiquidContainer : AContainer, IHazardNotifier
{
    public LiquidContainer(bool isDangerous, double maxCapacity, double cargoMass) : base(maxCapacity, cargoMass)
    {
        IsDangerous = isDangerous;
        SerialNumber = new SerialNumber(this).ToString();
    }
    private bool IsDangerous { get; set; }
    
    public override string TypeOfContainer()
    {
        return "L";
    }

    public override void EmptyTheCargo()
    { 
        CargoMass = 0;
    }

    public override void LoadTheCargo(double cargoToLoad)
    {
        var permissibleWeight = MaxCargoMass * (IsDangerous ?  0.5 :  0.9);

        if (CargoMass + cargoToLoad > permissibleWeight)
        {
            SendNotification();
            throw new OverfillException("Masa ładunku większa niż pojemność kontenera");
        }

        CargoMass += cargoToLoad;
    }
    

    public void SendNotification()
    {
        Console.Error.WriteLine($"NIEBEZPIECZEŃSTWO: {SerialNumber}");
    }

    public override string ToString()
    {
        var typeOfLoad = IsDangerous ? "niebezpieczny" : "bezpieczny";
        return $"Kontener: {SerialNumber} zawiera {typeOfLoad} ładunek ważący {CargoMass}";
    }
}