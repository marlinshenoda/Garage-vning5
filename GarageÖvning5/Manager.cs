using GarageÖvning5;

internal class Manager
{
   GarageHandler garage = new GarageHandler(10);
   // Garage<T> GAG = new Garage<T>(10);
    internal void Run()
    { 
        Console.Clear(); 
        do
        {
            UI.ShowMainMeny();
            string input = Console.ReadLine()!;

            switch (input)
            {
                case "0":
                    Environment.Exit(0);
                    break;

                case "1":
                    garage!.AddVehicle(UI.SetInputVehicle());
                    Console.ReadLine();
                    break;
                case "2":
                    garage.RemovePark(UI.GetID());
                    Console.ReadLine();
                    break;
                case "3":
                    garage.PrintVehicle();
                    Console.ReadLine();
                    break;
                case "4":
                    garage.FindByRegNo(UI.GetID());
                    Console.ReadLine();
                    break;
                case "5":
                //  garage.FindVehicle();
                    Console.ReadLine();
                    break;
                default:
                      break;

            }
        }
        while (true);
    }


}