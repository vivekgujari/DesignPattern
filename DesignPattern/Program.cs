using System;

namespace DesignPattern
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Do you want to add or subtract");
            string input = Console.ReadLine();
            CalculatorFactoryPattern factory = new CalculatorFactoryPattern();
            ICalculate obj = factory.Calculate(input);
            Console.WriteLine("The {0} of {1} and {2} is {3}", input, a, b, obj.Calculate(a, b));
            Console.WriteLine("End of main program");
        }
    }
}
