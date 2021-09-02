using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant
{
    class Hellow
    {
        public int a;
        public const int b = 100; //this can not be changed
        // must be initialized

        public readonly int c = 200; 
    public void M1()
        {
            //d++;  // can  not change
        }
        public Hellow()
        {
            c = 150;  // can change
        }

    }

}
