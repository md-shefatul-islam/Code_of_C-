using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{ 
    interface Square
    {
        void area();
    }
    interface Circle
    {
        void area();
    }
    internal class  c : Square, Circle
    {
        void Square.area()
        {

        }
        void Circle.area()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
