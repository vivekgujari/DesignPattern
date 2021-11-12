using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public interface IVehicle
    {
        public ICar getCar(string carType); 
    }

    public class Honda : IVehicle
    {
        public ICar getCar(string carType)
        {
            ICar obj = null;
            if (carType.ToLower().Equals("sedan"))
            {
                obj = new SedanCar();
            }
            else if (carType.ToLower().Equals("Sports"))
            {
                obj = new SportsCar();
            }
            return obj;
        }
    }
}
