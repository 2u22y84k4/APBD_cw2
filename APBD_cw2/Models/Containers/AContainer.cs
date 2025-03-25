using APBD_cw2.Models.Exceptions;

namespace APBD_cw2.Models.Containers;

public abstract class AContainer
{
    public AContainer(double maxCapacity, double cargoMass)
    {
        MaxCargoMass = maxCapacity;
        CargoMass = cargoMass;
    }
    protected double CargoMass { get; set; }
    protected uint Height { get; init; }
    protected double SelfWeight { get; init; }
    protected double Depth { get; init; }
    protected string SerialNumber { get; init; } = null!;
    protected double MaxCargoMass { get; set; }
    
    public abstract string TypeOfContainer();

    public abstract void EmptyTheCargo();
    
    public abstract void LoadTheCargo(double cargoToLoad);
    
}