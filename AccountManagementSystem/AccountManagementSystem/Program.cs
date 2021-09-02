using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Currentaccount c = new Currentaccount(1,"MD RAHAT ISLAM",1234567,8900,new MYDate(16,10,2020));
            c.ShowInfo();
            c.Withdraw(7000);

            Console.WriteLine();

            SavingsAccount s = new SavingsAccount("MD RIFAT KHAN",7654321,11400,new MYDate(12,7,2019),5);
            s.ShowInfo();
            s.Withdraw(9001);
        }
    }
}
