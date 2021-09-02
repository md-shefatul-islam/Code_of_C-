using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal abstract class parent
    {
        internal abstract void M1();
    }
    internal class Child : parent
    {
        internal override void M1()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            parent p = new Child();
        }
    }
}
