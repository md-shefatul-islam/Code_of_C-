using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consturctor
{
    class Parent
    {
        internal Parent()
        {
            Console.WriteLine("PDM");
        }
        internal Parent(int y)  //1
        {
            Console.WriteLine("vPPM : {0}", +y);
        }
    }
    class Child : Parent
    {
        internal Child() : base(100) //2
        {
            Console.WriteLine("CDM");
        }
        /* internal Child(int y)
         {
             Console.WriteLine("vPDM : {0}", +y);
         }*/

        internal Child(int y) : base(y) //3
        {
            Console.WriteLine("vCPM : {0}", +y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Child p = new Child();
            // 1st parent DM will be called then child DM will be called
            //2. 1st parent vPPM will be called then child CDm will be called

            Child p1 = new Child(5);
            //1.Always call parent default 1st, then call child parameterized constructor
            //3 . 1st parent vPPM will be called then child vCPM will be called
        }
    }
}
