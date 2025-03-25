using APBD_cw2.Models.Containers;

namespace APBD_cw2.Models.SerialNumbers;

public readonly struct SerialNumber(AContainer container)
{
    private const string FirstPart = "KON";
    private readonly string _secondPart = container.TypeOfContainer();
    private readonly string _lastPart = Guid.NewGuid()
                                                    .ToString()
                                                    .Split("-")[0];

    public override string ToString() => $"{FirstPart}-{_secondPart}-{_lastPart}";
}