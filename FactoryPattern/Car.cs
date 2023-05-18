using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Car : IVehicle
    {
         

        public void Drive()
        {
            FactoryLog.VehBuilder();
            Console.WriteLine($"{GetType().Name} is driving down the street.");
        }
    }
}
