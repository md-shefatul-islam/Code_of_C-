using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject
{
    internal struct MYDate
    {
        private byte day;
        private byte month;
        private ushort year;

        public MYDate(byte day, byte month, ushort year)
        {
            if (day > 0 && day < 31 && month > 0 && month <= 12)
            {
                this.day = day;
                this.month = month;
                // this.year = year;
            }
            else
            {
                this.day = 0;
                this.month = 0;
                //this.year = yea0r;

            }
             this.year = year;
         }
        
        public void ShowMyDate()
        {
            Console.WriteLine("Account opening date: {0}/{1}/{2}", this.day, this.month, this.year);
        }

    }
    internal struct Address
    {
        private byte houseNo;
        private byte roadNO;
        private ushort postalCode;
        private string district;

        public Address(byte houseNo, byte roadNO, ushort postalCode, string district)
        {

            this.houseNo = houseNo;
            this.roadNO = roadNO;
            this.postalCode = postalCode;
            this.district = district;
        }
        public void ShowMyAddress()
        {
            Console.WriteLine("Address details");
            //Console.WriteLine("House No: {0}\n,Road No : {1}\n,Postal Code : {2}\n,District : {3}\n",this.houseNo, +this.roadNO,this.postalCode , this.district);

            Console.WriteLine("House No: "+this.houseNo+ "\nRoad No : "+this.roadNO+"\nPostal Code : "+this.postalCode+"\nDistrict : "+this.district);
            Console.WriteLine();
        }

    }
    //internal class Account
    internal abstract class Account
    {
        
        
            private string name;
        private uint id;
        private double balance;
        private MYDate openingDate;
        private Address myAddress;

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
        internal double Balance
        {
            get { return this.balance; }
            set {
                if (value >= 0)
                    this.balance = value;
                else
                    this.balance = 0;
            }
        }

        internal MYDate OpeningDate
        {
            get { return this.openingDate; }
            set { this.openingDate = value; }
        }
        internal Address MyAddress
        {
            get { return this.myAddress; }
            set {
                    this.myAddress = value; }
        }
        internal Account(uint id, string name, double balance, MYDate openingDate, Address myAddress)
        {
            this.Name = name;
            /*if(id<10)
            { 
                this.Id = id; 
            }*/

            this.Id = id;
            this.Deposite(balance);  
            //this.withdraw(balance);
            //this.Balance = balance;
            this.OpeningDate = openingDate;
            this.MyAddress = myAddress;
        }

       
        internal void Deposite(double amount)
        {
            if (amount >= 500)
            {
                this.Balance += amount;
                Console.WriteLine("Deposite of {0} is done", amount);
            }
            else
                Console.WriteLine("Deposite of {0} is not enough. please deposite at least 500tk at least");

            //this.ShowInfo();
        }
        /*internal virtual void withdraw(double amount)
         {

        }*/
        //internal abstract void withdraw(double amount);
        internal abstract bool withdraw(double amount);

        internal void Transfer(Account recevier,double amount )
        {
            bool decision = this.withdraw(amount);
            if (decision)
            {
                recevier.Deposite(amount);
                Console.WriteLine("Transfer of {0} is complete",amount);
              
            }
            else
                Console.WriteLine("Transfer Incomplete");

        }
        internal virtual void ShowInfo()
        {
            Console.WriteLine("Id: {0}", this.Id);
            Console.WriteLine("Name: {0}", this.Name);
            this.OpeningDate.ShowMyDate();
            this.MyAddress.ShowMyAddress();
            Console.WriteLine("Balance: {0}", this.Balance);
        }

    }
}

