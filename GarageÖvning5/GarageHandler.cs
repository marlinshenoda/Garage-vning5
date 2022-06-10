using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageÖvning5
{
    internal class GarageHandler
    {
        private Garage<Vehicle>? garage;
        public GarageHandler(int capacity)
        {
            garage = new Garage<Vehicle>(capacity);
        }
        public void SeedData()
        {
            garage!.Park(new Car("Abc123","white",4,"Diesel"));
            garage!.Park(new Buss("ABc123","Orange",4,1));
            garage!.Park(new Boat("ABC123","Black",1));
            garage!.Park(new Airplane("abc123","Node",4,"HJ"));
            garage!.Park(new Motorcycle("abC123","Yellow",1));
            Console.WriteLine("Successfully seeded data");

        }
        public void PrintVehicle()
        {
            foreach (var Vehicle in garage!)
            {
                Console.WriteLine(Vehicle.Stats());
            }
        }
        public bool FindByRegNo(string regnr)
        {
            foreach (var vehicle in garage!)
            {
                if (vehicle.RegisterNumber == regnr)
                {
                    Console.WriteLine(vehicle.Stats());
                    return true;
                }
                else if (vehicle.Color == regnr)
                {
                    Console.WriteLine(vehicle.Stats());
                }
               
            }
            Console.WriteLine("Your vehicle is founded!");
            return false;
        }

        internal IEnumerable<Vehicle> GetVehicles()
        {
            return garage!.ToList();
        }

        public Vehicle AddVehicle(Vehicle  vehicle)
        {
          //  var vehicle = new Vehicle();

            if (garage!.Park(vehicle))
            {
                Console.WriteLine();
                Console.WriteLine($"Parked Successfully : {vehicle.Stats()}");
                Console.WriteLine("-----------------------------------");

            }

            else
            {
                Console.WriteLine("THERE IS NO PLACE");

            }
            return vehicle;
        }
        public void RemovePark(string regnr)
        {
            if(garage!.UnPark( regnr))
            {
            }
        }
    }
}
