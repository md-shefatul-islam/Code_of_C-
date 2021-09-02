using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    class SavingsAccount : AccountHolder
    {
        private byte duration;

        internal SavingsAccount(string name, uint id, uint balance, MYDate openingDate, byte duration) : base(name, id, balance, openingDate)
        {
            this.duration = duration;
        }

        internal byte Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
        internal override void ShowInfo()
        {
            Console.WriteLine("------Saving Account Holder details-------");
            base.ShowInfo();
            Console.WriteLine("Duration: {0}", this.Duration);
        }

        internal void Withdraw(uint ammount)
        {
            if (this.Balance > 500)
            {
                if (this.Balance >= ammount)
                {
                    this.Balance = this.Balance - ammount;
                    Console.WriteLine("Transiction Successful!!!");
                    Console.WriteLine("Balance: {0}", this.Balance);
                }
                else
                {
                    Console.WriteLine("Balance: {0}", this.Balance);
                    Console.WriteLine("NOT HAVE ENOUGH MONEY TO MAKE THE TRANSITION");
                }
            }
        }

    }
}

