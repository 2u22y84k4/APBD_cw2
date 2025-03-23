namespace APBD_cw2;

public abstract class AContainer
{
    /// <summary>
    /// This class represents a container object
    /// </summary>
    /// 
    public double CargoMass { get; set; } //kg ładunku
    public uint Height { get; set; } //cm
    public double Weight { get; set; } //kg waga samego kontenera
    public uint Depth { get; set; } //cm
    public uint SerialNumber { get; set; } // = "KON-C-1"
    public uint MaxCapacity { get; set; } //kg

    public abstract void EmptyTheCargo();

    public abstract void LoadTheCargo(double loadmass);
}