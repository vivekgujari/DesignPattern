using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class CalculatorFactoryPattern
    {
        class Add : ICalculate
        {
            public int Calculate(int a, int b)
            {
                return a + b;
            }
        }

        class Subtract : ICalculate
        {
            public int Calculate(int a, int b)
            {
                return a - b;
            }
        }

        public ICalculate Calculate(string input)
        {
            ICalculate obj = null;
            if (input.ToLower().Equals("add"))
            {
                obj = new Add();
            }
            else if (input.ToLower().Equals("subtract"))
            {
                obj = new Subtract();
            }
            return obj;
        }
    }
}
