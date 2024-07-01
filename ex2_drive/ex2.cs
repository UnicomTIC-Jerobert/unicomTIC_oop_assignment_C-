using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_JUNE_Drive
{
    interface IEngine
    {
        void RunEngine();
    }

    interface IDrivable
    {
        void Drive();
    }

    class Bike : IDrivable, IEngine
    {
        public void Drive()
        {
            Console.WriteLine("Im Driving by 2 wheels");
        }

        public void RunEngine()
        {
            Console.WriteLine("My Engine Works on 1 cylinder engine");
        }
    }

    class Car : IDrivable, IEngine
    {
        public void Drive()
        {
            Console.WriteLine("Im Driving by 4 wheels");
        }

        public void RunEngine()
        {
            Console.WriteLine("My Engine Works on 4 cylinder engine");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Bike bikeObj = new Bike();
            bikeObj.Drive();
            bikeObj.RunEngine();

            Car carObj = new Car();
            carObj.Drive();
            carObj.RunEngine();

            IDrivable obj1 = new Bike();
            obj1.Drive();
            // Error
            obj1.RunEngine();

            IEngine obj2 = new Car();
            obj2.Drive();
            // Error
            obj2.RunEngine();


            Console.ReadLine();
        }
    }
}