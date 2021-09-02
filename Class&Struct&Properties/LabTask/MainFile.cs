using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask
{
    class MainFile
    {
        static void Main(string[] args)
        {
            MyDate m1 = new MyDate(15, 01, 2001);
            Vehicle v1 = new Vehicle();
            v1.EngineNumber = 123;//v1.SetEngineNumber(1234567);
            v1.SetRegistrationDate(m1);
            v1.ShowInfo();

            Console.WriteLine();

            Vehicle v2 = new Vehicle(123456, new MyDate(12, 6, 2000));
            v2.ShowInfo();

            Console.WriteLine();

            Vehicle v3 = new Vehicle();
            v3.EngineNumber = 12324567; //called set
            v3.ShowInfo();
            uint i = v3.EngineNumber;  //called get accessor 
            Console.WriteLine(i);
        }
    }
}
