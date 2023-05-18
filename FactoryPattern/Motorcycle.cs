using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Motorcycle:IVehicle
    {
        public void Drive()
        {
            FactoryLog.VehBuilder();
            Console.WriteLine($"{GetType().Name} is driving down the street.");
        }
    }
}
