using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    internal struct MYDate
    {
        private byte day;
        private byte month;
        private ushort year;

        public MYDate(byte day, byte month, ushort year)
        {

            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void ShowmyDate()
        {
            Console.WriteLine("Account opening date: {0}/{1}/{2}", this.day, this.month, this.year);
        }

    }

    class AccountHolder
    {
        private string name;
        private uint id;
        private uint balance;
        private MYDate openingDate;

        internal AccountHolder(string name, uint id, uint balance, MYDate openingDate)
        {
            this.Name = name;
            this.Id = id;
            this.Balance = balance;
            this.OpeningDate = openingDate;
        }

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        internal uint Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        internal uint Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        internal MYDate OpeningDate
        {
            get { return this.openingDate; }
            set { this.openingDate = value; }
        }

        
        internal void Deposit()
        {
            
            if(this.Balance<500)
            {
                Console.WriteLine("Can not make diposit");
            }
            else if (this.Balance>500)
            {
                Console.WriteLine("Deposit successful");
            }


        }
        internal virtual void ShowInfo()
        {
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Id: {0}", this.Id);
            OpeningDate.ShowmyDate();
            this.Deposit();
            
        }
    }
}
