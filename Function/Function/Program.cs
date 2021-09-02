using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Function f = new Function();
            int x = 10, y = 20, z = 30;
            //f.Swap(x, y); //sending value
            f.Swap(ref x, ref y); //sending reference
            Console.WriteLine("x:{0} , y:{1}", x, y);

            //f.Swap(out x,out y);
            f.M2(out z, f);
            //f.M4(1, 2); //c have vlaue and it will not change until new value inserted
            f.M4(1);
            f.M5(1, c:2, b:3);
        }
    }
}
