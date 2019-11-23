using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork20191114
{
    class Program
    {
        static void PrintVehcicle(Vehicle v)
        {
            Console.WriteLine(v);
        }
        static void PrintVehcicles(Vehicle[] vehicles)
        {
            foreach (Vehicle item in vehicles)
                PrintVehcicle(item);
        }
        static void Main(string[] args)
        {
            Car volga = new Car("Volga", 4,4);
            Car niva = new Car("Nuva", 4, 3);
            Motorcycle java = new Motorcycle("Java", 2, 1);
            Motorcycle ural = new Motorcycle("Ural", 2, 2);
            Vehicle[] vehicles = new Vehicle[4];
            vehicles[0] = volga;
            vehicles[1] =java;
            vehicles[2] = ural;
            vehicles[3] = niva;

            PrintVehcicles(vehicles);

          
            Carrier cars = new Carrier();
            cars.v = new Vehicle[2];
            cars.v[0] = volga;
            cars.v[1] = ural;
            Console.WriteLine(cars);
            Console.ReadLine();


        }
    }
}
