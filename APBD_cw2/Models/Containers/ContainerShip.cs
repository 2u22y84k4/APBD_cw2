namespace APBD_cw2.Models.Containers;

public class ContainerShip(List<AContainer> containers, uint speedLimit, uint limitOfContainers, uint limitOfWeight)
{
    private List<AContainer> Containers { get; set; } = containers;
    private uint SpeedLimit { get; set; } = speedLimit;
    private uint LimitOfContainers { get; set; } = limitOfContainers;
    private uint LimitOfWeight { get; set; } = limitOfWeight;

    public void LoadIntoShip(AContainer container)
    {
        Containers.Add(container);
    }

    public void LoadIntoShip(List<AContainer> containers)
    {
        Containers.AddRange(containers);
    }

    public void RemoveFromShip(AContainer container)
    {
        Containers.Remove(container);
    }

    public void SwitchContainers(AContainer firstContainer, AContainer secondContainer)
    {
        var index = Containers.IndexOf(firstContainer);
        Containers[index] = secondContainer;
    }
    
    public void TransferContainerTo(ContainerShip otherShip, AContainer firstContainer, AContainer secondContainer)
    {
        if (this.Containers.Contains(firstContainer) && otherShip.Containers.Contains(secondContainer))
        {
            this.Containers.Remove(firstContainer);
            this.LoadIntoShip(secondContainer);

            otherShip.Containers.Remove(secondContainer);
            otherShip.LoadIntoShip(firstContainer);
            
            Console.WriteLine("przeniesiono kontenery");
            return;
        }
        
        Console.WriteLine("nie udało się przenieść kontenerów");
       
      
    }
    
    
    public override string ToString()
    {
        return "Na statku znajduje się " + Containers.Count.ToString() + " kontener/y. Są to: " + string.Join(", ", Containers);
    }
    
}