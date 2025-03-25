using APBD_cw2.Models;
using APBD_cw2.Models.Containers;

namespace APBD_cw2;

class Program
{
    static void Main(string[] args)
    {
        LiquidContainer liquidContainerA = new LiquidContainer(true, 100, 5);
        liquidContainerA.LoadTheCargo(40);
        LiquidContainer liquidContainerB = new LiquidContainer(false, 1000, 600);
        liquidContainerB.LoadTheCargo(40);
        
        LiquidContainer liquidContainerC = new LiquidContainer(false, 300, 400);
        
        List<AContainer> liquids = new List<AContainer>();
        liquids.Add(liquidContainerA);
        liquids.Add(liquidContainerB);

        
        GasContainer gasContainer = new GasContainer(2.7, 100, 12);
        gasContainer.LoadTheCargo(40);
        
        List<AContainer> gases = new List<AContainer>();
        gases.Add(gasContainer);
        

        CoolingContainer coolingContainer = new CoolingContainer("bananas", 14, 100, 20);
        coolingContainer.LoadTheCargo(40);
        
        

        ContainerShip shipA = new ContainerShip(liquids, 200, 300, 10000);
        shipA.LoadIntoShip(liquidContainerC);
        shipA.RemoveFromShip(liquidContainerA);
        Console.WriteLine(shipA.ToString());
        
        ContainerShip shipB = new ContainerShip(gases, 200, 300, 10000);
        shipB.TransferContainerTo(shipA, gasContainer, liquidContainerC);
        Console.WriteLine(shipB.ToString());
        Console.WriteLine(shipA.ToString());





    }
}