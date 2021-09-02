using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject
{
    internal class Current : Account
    {
        private string accountType;

        internal string AccountType
        {
            get { return this.accountType; }
            set {
                if (value == "Personal" || value == "Student" || value == "Salary")
                    this.accountType = value;
                else
                    this.accountType = "Invalid Type";        
            }
        }
        internal Current(uint id, string name, double balance, MYDate openingDate, Address myAddress, string accountType) : base(id, name,balance, openingDate,myAddress)
        {
            this.AccountType = accountType;
        }
        internal override void ShowInfo()
        {
            Console.WriteLine("Current account type: {0}", this.AccountType);
            base.ShowInfo();
            Console.WriteLine();
        }
        // internal override void withdraw(double amount)
        internal override bool withdraw(double amount)
        {
            if (this.Balance - amount >= 500)
            {
                this.Balance -= amount;
                Console.WriteLine("In current, withdraw of {0} is done", amount);
                return true;

            }
            else
            {
                Console.WriteLine("In current, withdraw of {0} is not enough. Insufficient", amount);
                return false;
            }

           //this.ShowInfo();
        }
    }
}
