using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInformation
{
    class Program
    {
        static void Main(string[] args)
        { 
            Game g1 = new Game();
            g1.GameNumber = 12125;
            g1.StartTime = new MyTime(16, 30, 50);
            g1.ShowGameInfo();

            Console.WriteLine();

           Game g2 = new Game(13135, new MyTime(17, 30, 55));
            g2.ShowGameInfo();

            

        }
    }
}
