using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{

    class Program
    {
        static void Main(string[] args)
        {
            OurAddress a;
            a.houseNo = 11;
            a.roadNo = 101;
            a.postalCode = 7400;
            a.district= " jessore";
            Console.WriteLine("House No: {0}", a.houseNo);
            Console.WriteLine("Road No: {0}", a.roadNo);
            Console.WriteLine("Postal Code: {0}", a.postalCode);
            Console.WriteLine("District: {0}", a.district);

            Console.WriteLine();

            OurAddress a1 = new OurAddress();
            a1.houseNo = 11;
            a1.roadNo = 101;
            a1.postalCode = 7400;
            a1.district = "Jessore";
            a1.ShowAddress();

            Console.WriteLine();

            /*OurAddress a2 = new OurAddress(10,102,7500,"Dhaka");
            a2.ShowAddress();*/
        }
    }
}
