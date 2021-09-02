using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Hellow.b);

            // Hellow h = new Hellow();
            //or
            //new Hellow().c = 50; // is error

            // Console.WriteLine(h.c);
            Console.WriteLine(new Hellow().c);
        }
    }
}
