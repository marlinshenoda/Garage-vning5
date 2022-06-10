using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GarageÖvning5.Car;

namespace GarageÖvning5
{
    internal class UI
    {
        public static void ShowMainMeny()
        {
            Console.WriteLine("0: quit");
            Console.WriteLine("1: Park a vehicle");
            Console.WriteLine("2: Unpark a vehicle");
            Console.WriteLine("3: Print all vehicles");
            Console.WriteLine("4: search for a vehicle");
        }
        public static void Meny()
        {
            Console.WriteLine("which way do you want search by:\n");
            Console.WriteLine("0: search by color\n");
            Console.WriteLine("1: search by name of vehicle\n");
            Console.WriteLine("2: search by registration number\n");
        }


        public static Vehicle SetInputVehicle()
        {
            do
            {
                Console.WriteLine("\nRegister Number?");
                var regnr = Console.ReadLine();

                Console.WriteLine("\nColor?");
                var color = Console.ReadLine();

                Console.WriteLine("\nNumber of wheels?");
                var nrOfWheels = uint.Parse(Console.ReadLine()!);
                Console.WriteLine("Which type of vehicle do you want set in parking?");
                Console.WriteLine("Airplane , Car , Buss , Boat or Motorcycle");
                string type = Console.ReadLine()!;
                switch (type)
                {
                    case "car":

                        Console.WriteLine("Which fuel type as using ?");
                        var fuel= Console.ReadLine();
                        return new Car(regnr!, color!, nrOfWheels, fuel!);

                    case "airplane":
                        Console.WriteLine("What is the hull type ?");
                        var hull= Console.ReadLine();
                        return new Airplane(regnr!, color!, nrOfWheels, hull!);

                    case "buss":
                        Console.WriteLine("How many number of seats ?");
                        var seats = uint.Parse(Console.ReadLine()!);
                        return new Buss(regnr!, color!, nrOfWheels, seats);

                    case "boat":
                        return new Boat(regnr!, color!, nrOfWheels);

                    case "motorcycle":
                        return new Motorcycle(regnr!, color!, nrOfWheels);


                }

            } while(true);
        }

        public static string GetID()
        {
            Console.WriteLine("Enter registration number:\n");
            return Console.ReadLine()!;
        }
        //public static void GetData(string x,int y)
        //{
        //    Console.WriteLine("Search by color:\n");
        //     x = Console.ReadLine()!;
        //    y=int.Parse(Console.ReadLine()!);
        //}
       
    }
}
