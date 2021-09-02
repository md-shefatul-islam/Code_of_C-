using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    class Currentaccount : AccountHolder
    {
        private byte accountType;

        internal Currentaccount(byte accountType, string name, uint id, uint balance, MYDate openingDate) : base(name, id, balance, openingDate)
        {
            this.accountType = accountType;
        }
        internal byte AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }

        }
        internal override void ShowInfo()
        {
            Console.WriteLine("------Current Account Holder details-------");

            if (this.accountType == 1)
            {
                Console.WriteLine("Account Type : Personal");
            }
            else if (this.accountType == 2)
            {
                Console.WriteLine("Account Type : Student");
            }
            else if (this.accountType == 3)
            {
                Console.WriteLine("Account Type : Salary");
            }
            base.ShowInfo();
        }

        internal void Withdraw(uint ammount)
        {

            if (this.Balance >= ammount && this.Balance > 500)
            {

                this.Balance = this.Balance - ammount;
                {
                    if (this.Balance >= 500)
                    {

                        Console.WriteLine("Transiction Successful!!!");
                        Console.WriteLine(" Balance: {0}", this.Balance);
                    }
                    else
                    {
                        this.Balance = this.Balance + ammount;
                        Console.WriteLine("Balance: {0}", this.Balance);
                        Console.WriteLine("Transiction Failedl!!!");
                        Console.WriteLine("!!!NOT HAVE ENOUGH MONEY, AT LEAST KEEP 500TK!!!");
                    }
                }

            }
            else
            {

                Console.WriteLine("Balance: {0}", this.Balance);
                Console.WriteLine();
                Console.WriteLine("!!!NOT HAVE ENOUGH MONEY TO MAKE THE TRANSITION!!!");
            }
        }
    }
}

