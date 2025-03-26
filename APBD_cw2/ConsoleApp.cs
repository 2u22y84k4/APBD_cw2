using APBD_cw2.Models.Containers;

namespace APBD_cw2;

public class ConsoleApp
{
    static void Main(string[] args)
    {
        List<ContainerShip> containerShips = new List<ContainerShip>();
        List<AContainer> containers = new List<AContainer>();
        Dictionary<int, string> actions = CreateActions();
        List<string> containerShipCreation = ContainerShipCreate();
        int counter = 0;
        string? input;
        int numberInput;

        do
        {
            Console.WriteLine("Lista kontenerowców: \n" + string.Join("\n", containerShips));
            Console.WriteLine("Lista kontenerowców: \n" + string.Join("\n", containers));
            Console.WriteLine("Możliwe akcje:");
            
            Console.WriteLine($"{actions.ElementAt(0).Key}. {actions.ElementAt(0).Value}");
            input = Console.ReadLine();
            numberInput = Convert.ToInt32(input);

            switch (numberInput)
            {
                case 1: 
                    string[] ship = new string[4];
                    for (var i = 0; i < containerShipCreation.Count; i++)
                    {
                        Console.WriteLine(containerShipCreation.ElementAt(i));
                        input = Console.ReadLine();
                    }
                    break;
            }
            
            
            
            
            
            
            
            Console.WriteLine("\n");



        } while (!numberInput.Equals(actions.ElementAt(11).Key) );
    }

    private static Dictionary<int, string> CreateActions()
    {
        Dictionary<int, string> actions = new Dictionary<int, string>()
        {
            {1, "Dodaj kontenerowiec"},
            {2, "Usuń kontenerowiec"},
            {3, "Dodaj kontener"},
            
            {4, "Dodaj kontenerowiec"},
            {5, "Dodaj kontenerowiec"},
            {6, "Dodaj kontenerowiec"},
            {7, "Dodaj kontenerowiec"},
            {8, "Dodaj kontenerowiec"},
            {9, "Dodaj kontenerowiec"},
            {10, "Dodaj kontenerowiec"},
            {11, "Dodaj kontenerowiec"},
            {12, "Zakończ"}
        };

        return actions;
    }
    
    private static List<string> ContainerShipCreate()
    {
        List<string> shipCreate = new List<string>();
        shipCreate.Add("Dodaj listę kontenerów");
        shipCreate.Add("Podaj limit prędkości statku");
        shipCreate.Add("Podaj limit kontenerów na statku");
        shipCreate.Add("Podaj limit wagi dopuszczanej na statku");

        return shipCreate;
    }
    
}