using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            /*a[0] = 1;
            a[1] = 2;
            a[2] = 3; 
            a[3] = 4; 
            a[4] = 5;*/



            int[][] j = new int[3][];
            j[0] = new int[] { 1, 3 };
            j[1] = new int[1] { 1};
            j[2] = new int[] { 1,2 };

            //or

            int[][] j1 = //new int[][]  //eta na dileo hoy
            {
                new int[] { 1, 2, 3 },
                new int[] { 1 },
                new int[] { 1, 3, 4 },
                new int[] { 1, 3 }
            };

            int r=0, c;
            while(r<j1.Length)  //number of row
            {
                c = 0;
                while(c<j1[r].Length)  //size of one d jagged arrays column 
                {
                    Console.Write("{0} ", j1[r][c]);
                    c++;
                }
                Console.WriteLine();
                r++;
            }
             

        }
    }
}
