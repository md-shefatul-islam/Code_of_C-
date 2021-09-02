using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Account[] accounts = new Account[2];
            accounts[0] = new Savings(100, "me", 5000,new MYDate(16,12,1000), new Address(2,3,400,"dhaka"),5);
            accounts[1] = new Current(101, "she", 10000, new MYDate(18, 2, 1007), new Address(6, 5, 900, "jessore"), "Personal");
             //accounts[0].ShowInfo();
            //accounts[1].ShowInfo();

            //accounts[0].Deposite(3000);
            //accounts[1].Deposite(4000);
            /*byte c = 0;
            while(c<accounts.Length)
            {
                accounts[c].ShowInfo();
                c++;
            }*/

            foreach (Account a in accounts)
            {
                a.ShowInfo();
            }

            //accounts[0].withdraw(6000);
            //accounts[1].withdraw(4000);
            Console.WriteLine();
            accounts[0].Transfer(accounts[1], 6000);
        }
    }
}
