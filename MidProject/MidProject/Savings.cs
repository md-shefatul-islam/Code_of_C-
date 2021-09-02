using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject
{
    internal class Savings : Account
    {
        private byte duration;

        internal byte Duration
        {
            get { return this.duration; }

            set {
                if (value >= 2 && value <= 40)
                    this.duration = value;
                else
                    this.duration = 0;
            }
        }
        internal Savings(uint id,string name, double balance, MYDate openingDate, Address myAddress, byte duration) : base(id, name,balance,openingDate,myAddress)
        {

            this.Duration = duration;
            //Console.WriteLine(this.duration);
        }
        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Savings account duration: {0}", this.Duration);
            Console.WriteLine();
        }

        //internal override void withdraw(double amount)
        internal override bool withdraw(double amount)
        {
            if (this.Balance - amount >= 0)
            {
                this.Balance -= amount;
                Console.WriteLine("In savings withdraw of {0} is done", amount);
                return true;
            }
            else
            {
                Console.WriteLine("In savings Amount of {0} is not enough. Insufficient Balance", amount);
                return false;
            }

           // this.ShowInfo();
        }
    }
}
