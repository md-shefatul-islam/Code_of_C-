using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelOfInheritance
{
    internal abstract class Parent
    {
    internal virtual void M1()
        {
            Console.WriteLine("PCM1");
        }
        internal virtual void M2()
        {
            Console.WriteLine("PCM2");
        }
        internal abstract void M3();
    }
    //internal class Child : Parent
    internal abstract class Child : Parent
         //internal sealed class Child : Parent
        //grand child cannot inherit the child class
    {
        //internal sealed override void M1()
            //to add sealed, must be override once
             internal  override void M1()
        {
            Console.WriteLine("CCM1");
        }
        internal new virtual void M2()
        {
            Console.WriteLine("cCM2");
        }
        internal override void M3()
        {

        }

    }
    internal class GrandChild : Child
    {
        internal override void M1()
        {
            Console.WriteLine("GCM1");
        }
        internal override void M2()
        {
            Console.WriteLine("gCM2");
        }

        internal override void M3()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new GrandChild();
            //Parent p1 = new Child();

            Child c = new GrandChild();
            p.M1();
            c.M1();
        }
    }
}
