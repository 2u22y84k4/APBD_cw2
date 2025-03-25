using APBD_cw2.Models.Exceptions;
using APBD_cw2.Models.Interfaces;
using APBD_cw2.Models.SerialNumbers;

namespace APBD_cw2.Models.Containers;

public class GasContainer : AContainer, IHazardNotifier
{
    public GasContainer(double pressure, double maxCapacity, double cargoMass) : base(maxCapacity, cargoMass)
    {
        this.Pressure = pressure;
        SerialNumber = new SerialNumber(this).ToString();
    }
    
    private double Pressure { get; set; }

    public override string TypeOfContainer()
    {
        return "G";
    }

    public override void EmptyTheCargo()
    {
        CargoMass *= 0.05;
    }

    public override void LoadTheCargo(double cargoToLoad)
    {
        if (CargoMass + cargoToLoad > MaxCargoMass)
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
        return $"Kontener: {SerialNumber} zawiera ładunek ważący {CargoMass}";
    }
}