using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
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

            Console.WriteLine("House No: " + this.houseNo + "\nRoad No : " + this.roadNO + "\nPostal Code : " + this.postalCode + "\nDistrict : " + this.district);
            Console.WriteLine();
        }

        internal static class Bank
        {
            private static int index = 0;
           private static Account[] bankAccount = new Account[2];

            internal static void AddAccount(Account account)
            {
                bankAccount[index] = account;
                index++;
            }
            internal static void ShowAccount()
            {
                int count = 0;
                while(count<bankAccount.Length )
                {
                    
                    bankAccount[count].ShowInfo();
                    count++;
                }
            }
            internal static void Search(string id)
            {
                bool found = false;
                string s = id.ToString();
                int count = 0;
                while(count<index)
                {
                   if(bankAccount[count].Id=s)
                       // if (bankAccount[count].Id.Equals(s))
                        {
                        Console.WriteLine("account found");
                        found = true;
                        bankAccount[count].ShowInfo();
                        break;
                    }
                    count++;
                }
                if(!found)
                {
                    Console.WriteLine("account not found");
                }
            }

        }
        internal class Account
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
                set
                {

                    this.balance = value;
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
                set
                {
                    this.myAddress = value;
                }
            }
            internal Account(uint id, string name, double balance, MYDate openingDate, Address myAddress)
            {
                this.Name = name;
                this.Id = id;
                this.Balance = balance;
                this.OpeningDate = openingDate;
                this.MyAddress = myAddress;
            }
            internal void ShowInfo()
            {
                Console.WriteLine("Id: {0}", this.Id);
                Console.WriteLine("Name: {0}", this.Name);
                this.OpeningDate.ShowMyDate();
                this.MyAddress.ShowMyAddress();
                Console.WriteLine("Balance: {0}", this.Balance);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Account[] accounts = new Account[2];
                accounts[0] = new Account(100, "me", 5000, new MYDate(16, 12, 1000), new Address(2, 3, 400, "dhaka"));
                accounts[1] = new Account(101, "she", 10000, new MYDate(18, 2, 1007), new Address(6, 5, 900, "jessore"));

                /*Bank b = new Bank();
                b.AddAccount(accounts[0]);
                b.AddAccount(accounts[1]);
                b.ShowAccount();*/

                Bank.AddAccount(accounts[0]);
                Bank.AddAccount(accounts[1]);
                Bank.ShowAccount();

                Bank.Search("101");

            }
        }
    }
}
