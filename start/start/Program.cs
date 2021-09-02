using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to c#");
            Console.Write("welcome to summer\n");

            int a = 1, b = 2, c = 3;
            float f = 10.5f;
            decimal m = 11.5m;
            double d = 12.5;
            Console.WriteLine("a: {1}, b: {0}, c: {2}, d : {3}, e: {4}", a, b, c, f , m , d);
            Console.WriteLine("a: " + a + " b: " + b + " c: " + c);

            string ourText;
            int i, v;
            double x;

            /*ourText=Console.ReadLine();
            Console.WriteLine(ourText);*/

            /* i = Convert.ToInt32(ourText);*//*
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(i);*/
            /*v = Int32.Parse(Console.ReadLine());
            Console.WriteLine(v);*/
            /*x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(x);*/

            int n1, n2;
            double n3 = 4.5, n4;
            short n5, n6;

            n2 = (int)n3; //explicit type casting 
            Console.WriteLine(n2);
            n6 = (short)n2;  //inplicit type casting
            Console.WriteLine(n6);
        }
    }
}
