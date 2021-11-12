using System;

namespace DesignPattern
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Honda honda = new Honda();
            VehicleAbstractPattern vehicle = new VehicleAbstractPattern(honda, "Sedan");
            ICar hondacar = vehicle.Car;
            Console.WriteLine(hondacar.getType());
            Console.WriteLine("End of main program");
        }
    }
}
