using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassTest<int> ct = new ClassTest<int>();
            ct.ax = 90;

            ClassTest<string> c = new ClassTest<string>();
            c.ax = " help";

            List<int> intlist = new List<int>();
            List<string> strlist = new List<string>();
            // List<Student> stdlist = new List<Student>();

            intlist.Add(56);
            intlist.Add(16);
            intlist.Add(46);
            intlist.Add(26);
            intlist.Add(86);
            intlist.Sort();
            intlist.Reverse();
            // intlist.Remove(16); 
            Console.WriteLine(intlist.Contains(100)); //return bool value

            foreach(var value in intlist)
            {
                Console.WriteLine(value);
            }

           // Console.WriteLine(intlist[4]);
            Console.WriteLine(intlist.Count);

        }
    }
}
