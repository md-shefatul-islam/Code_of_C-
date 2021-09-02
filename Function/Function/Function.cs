using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class Function
    {
        public Function()
        {

        }
        /*public void Swap(int x, int y) //receiving only value 
            // void- dont send any thing
        {
            int t;
            t = x;
            x = y;
            y = t;
            //for, a function only one vlaue can be returned

        }*/
        public void Swap(ref int x, ref int y) //receiving reference
        {
            int t;
            t = x;
            x = y;
            y = t;
            // returned only the reference automatically for more than 2

        }
        /* public void Swap(out int x, out int y)  //cannot joverload, because no diffrence except out and ref
             // they have generate same code in compiole time
         {
             x = 3;
             y = 3;
         }*/
        public void M2(out int s, Function t)
        {
            s = 50; //must initialize in here
            s++;
            //can return more than 2 reference
        }

        public void M3(ref int x, out int y, params int[] r)
        {
            y = 10;
        }
        public void M4(int a, int b =2 , int c = 3)
        {

        }
        public void M5(int a, int b, int c=1)
        {

        }
    }
}
