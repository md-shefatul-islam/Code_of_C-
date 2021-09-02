using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericClass
{
    class ClassTest<T>  //type variable name 
    {
        internal T ax,bx;
        internal int AX { set; get; }

        //internal int[] 1 = new int[50];
           //no mathmathical operation wont be happened here and in generic
            internal T M1()
        {
            //return ax;
            //return ax+bx;   //will error
            //return ax<bx;   //will error
            return ax.Equals(bx)? ax : bx ;
        }

    }
}
