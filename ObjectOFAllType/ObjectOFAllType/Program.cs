using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOFAllType
{
    internal class Test
    {

    }
    internal enum Days
    {
       Sat,
       Sun,
       Mon
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 50;
            object o1 = i; 
            object o2 = 50;
            object o3 = 30.78;
            object o4 = " me";
            object o5 = new Test();
            //this object is the parent of all type class and custom define class
            // implicit custing is hapening
            //this is callwd common type system
            int y = (int)o2;

            o1.ToString();
            //Equals, GetHashCode,GetType,ToString is the 4 public method of object class
            Console.WriteLine(o2.GetType());
            Console.WriteLine(o3.GetType());
            Console.WriteLine(o4.GetType());
            Console.WriteLine(o5.GetType());

            //anonymous type
            var a = 10;
            var b = 10.7;
            var c = "m3";
            var d = new Test();

            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(c.GetType());
            Console.WriteLine(d.GetType());

            dynamic x = 10;
            dynamic z = "string";
            dynamic e = new Test();
            //e.fake();

            //Nullable type

            int? h = null;

            int d1 =(int) Days.Sat;
            Console.WriteLine(d1);

        }
    }
}
