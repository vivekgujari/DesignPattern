using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class VehicleAbstractPattern
    {
        public ICar Car { get; set; }
        public VehicleAbstractPattern(IVehicle factory, string type)
        {
            Car = factory.getCar(type);
        }
        public string CarType()
        {
            return Car.getType();
        }

    }

    
    
}
