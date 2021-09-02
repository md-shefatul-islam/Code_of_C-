using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Demo
    {
        internal int i;
        internal static int i1;
        internal void M1()
        {
            this.i = 30;
            //this.i1 = 50;
            //this represent current object,but static donot belog any object
            i1 = 30; 

        }
        internal static void M2()
        {
            //this.i = 30;
            //this is not static
            i1 = 30;

            int j = 50;
            j++;
            //local variable can be used 

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            Demo d1 = new Demo();

            //d.i1 = 230;
            //errror coz it is static
            Demo.i1 = 50;
            DateTime dt = new DateTime(2019,7,23,16,45,56);
            Console.WriteLine(dt);
            Console.WriteLine(DateTime.Now); //current time

        }
    }
}
