using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck t = new Truck(123, 2);
            t.ShowInfo();
            

            Console.WriteLine();

            Bus b = new Bus(1234, 50);
            b.ShowInfo();
            b.CalculatedFare(100);

        }
    }
}
