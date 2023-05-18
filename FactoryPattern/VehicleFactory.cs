using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelCount)
        {
           
            switch (wheelCount)
            {
                case 0:
                  return null;
                   
                    case 1:
                    return new Unicycle();
                    case 2:
                    return new Motorcycle();
                    case 3:
                    return new Tricycle();
                    case 4:
                    return new Car();
                default:
                    return new Car();

            }
        }
    }
}
