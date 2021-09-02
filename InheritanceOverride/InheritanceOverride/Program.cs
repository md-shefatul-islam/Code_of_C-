using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOverride
{
    internal class Parent
    {
        internal virtual void M1()
        {
            Console.WriteLine("pm1");
        }
        internal virtual void M2()
        {
            Console.WriteLine("pm1");
        }
    }
    internal class Child : Parent
    {
        internal override void M1()
        {
            Console.WriteLine("cm1");
        }
        internal new void M2()
            //new means it has no relation with parent
        {
            Console.WriteLine("cm2");
        }
        internal void M3()
        {
            Console.WriteLine("cm3");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Parent p = new Parent();
            Child c = new Child();*/

            Child c = new Child();
            Parent p2 = c; //**same

            Parent p1 = new Child();  //**same
            //parent type = hold child type. polymorfic object
            //parent type can hold both its own and child instance
            //run time polymorphism will occur when polymorfic object will call.
            //parent is bigger than child type. it is implicit casting

            p1.M1();
            p1.M2();
            //p1.M3(); //not possible, coz parent cna not acesss method of child

            //if we want to give the parents thing in child than explicit casting
            Child c1 = (Child)p1;
            
            
        }
    }
}
 