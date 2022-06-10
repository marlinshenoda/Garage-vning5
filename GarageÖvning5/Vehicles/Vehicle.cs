using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageÖvning5
{
    public class Vehicle : IVehicle
    {
       
        public string RegisterNumber { get;  init; }
        public string Color { get; set; }
        public uint NumberOfWheels { get; set; }

        public Vehicle(string registerNumber, string color, uint numberOfWheels)
        {
            RegisterNumber = registerNumber;
            Color = color;
            NumberOfWheels = numberOfWheels;
        }
        public virtual string Stats()
        {
            return $"Type: {GetType().Name}, RegisterNumber: {RegisterNumber}, Color: {Color}, Number of wheels: {NumberOfWheels}, ";
        }
    }
    internal class Motorcycle : Vehicle
    {
        public Motorcycle(string registerNumber, string color, uint numberOfWheels) : base(registerNumber, color, numberOfWheels)
        {
        }
        public override string Stats()
        {
            return $"Type: {GetType().Name}, RegisterNumber: {RegisterNumber}, Color: {Color}, Number of wheels: {NumberOfWheels}, ";
        }
    }
    internal class Car : Vehicle
    {
        public String FuelType { get; set; }
        
        public Car(string registerNumber, string color, uint numberOfWheels, string ft) : base(registerNumber, color, numberOfWheels)
        {
            FuelType = ft;
        }
        public override string Stats()
        {
            return $"Type: {GetType().Name}, Register Number : {RegisterNumber}, Color: {Color}, Number of wheels: {NumberOfWheels}, Current Fuel Type: {FuelType}";
        }
    }
    internal class Buss : Vehicle
    {
        public uint NumbersOfSeats { get; set; }
        public Buss(string registerNumber, string color, uint numberOfWheels, uint numOfSeats) : base(registerNumber, color, numberOfWheels)
        {
            NumbersOfSeats = numOfSeats;
        }
        public override string Stats()
        {
            return $"Type: {GetType().Name}, RegisterNumber: {RegisterNumber}, Color: {Color}, Number of wheels: {NumberOfWheels}, Numbers Of Seats: {NumbersOfSeats} ";
        }
    }
    internal class Boat : Vehicle
    {
        public Boat(string registerNumber, string color, uint numberOfWheels) : base(registerNumber, color, numberOfWheels)
        {

        }
        public override string Stats()
        {
            return base.Stats();
        }
        
    }
    internal class Airplane : Vehicle
    {
        public string HullType { get; set; }
        public Airplane(string registerNumber, string color, uint numberOfWheels, string hullType) : base(registerNumber, color, numberOfWheels)
        {
            HullType = hullType;
        }
        public override string Stats()
        {
            return $"Type: {GetType().Name}, RegisterNumber: {RegisterNumber}, Color: {Color}, Number of wheels: {NumberOfWheels}, Hull Type: {HullType}";
        }
    }
}
