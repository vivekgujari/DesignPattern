using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public interface ICar
    {
        public string getType();
    }

    public class SedanCar : ICar
    {
        public string getType()
        {
            return "This is a Sedan car";
        }
    }

    public class SportsCar : ICar
    {
        public string getType()
        {
            return "This is a sports car";
        }
    }
}
