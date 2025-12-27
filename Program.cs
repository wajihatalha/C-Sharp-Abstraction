using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    interface IDrive
    {
        void Drive();
    }
    abstract class Vehicle
    {
        public string Name;

        public Vehicle(string name)
        {
            Name = name;
        }

        public void ShowName()
        {
            Console.WriteLine("Vehicle: " + Name);
        }

        public abstract void Start();
    }
    class Car : Vehicle, IDrive
    {
        public Car(string name) : base(name)
        {

        }
        public override void Start()
        {
            Console.WriteLine("Car engine starts with key.");
        }
        public void Drive()
        {
            Console.WriteLine("Car is driving on the road.");
        }
    }
    class Bike : Vehicle, IDrive
    {
        public Bike(string name) : base(name)
        {

        }

        public override void Start()
        {
            Console.WriteLine("Bike starts with self-start.");
        }
        public void Drive()
        {
            Console.WriteLine("Bike is riding on the road.");
        }
    }
    class Program
    {
        static void Main()
        {
            Vehicle v1 = new Car("Honda City");
            IDrive d1 = (IDrive)v1;

            v1.ShowName();
            v1.Start();
            d1.Drive();

            Console.WriteLine();

            Vehicle v2 = new Bike("Yamaha");
            IDrive d2 = (IDrive)v2;

            v2.ShowName();
            v2.Start();
            d2.Drive();
        }
    }
}
