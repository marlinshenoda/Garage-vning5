using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageÖvning5
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private List<T>? vehicles;
        private int capacity;
        public int Count => vehicles!.Count;
        public bool IsFull => capacity <= Count;
        public T this[int index] => vehicles![index]; 
       // public T this[string input] => vehicles![input]; 
        public Garage(int capacity)
        {
            this.capacity = Math.Max(capacity, 20);
            vehicles = new List<T>(this.capacity);
        }

        public virtual bool Park(T vehicle)
        {
            ArgumentNullException.ThrowIfNull(vehicle, "Vehicle");

            if (IsFull)
            {

                return false;

            }
            else
            {
                vehicles!.Add(vehicle);
                return true;
               
            }


        }
        public bool UnPark(string regnr)
        {
            {
                foreach (var item in vehicles!)
                {


                    if (item != null && item.RegisterNumber == regnr)
                    {
                        Console.WriteLine($"Successfully unparked vehicle with licence plate: {regnr}.");

                        return true;
                    }
                }
            }

            return false;
        }
       
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var vehicle in vehicles!)
            {
                
                yield return vehicle;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

      
    }
}
