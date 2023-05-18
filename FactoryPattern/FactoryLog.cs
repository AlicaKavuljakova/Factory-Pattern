using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class FactoryLog
    {
        public static void VehBuilder()
        {
            Console.WriteLine("Gathering tools...");
            Thread.Sleep(1000);
            Console.WriteLine("Starting to build...");
        }
    }
}
