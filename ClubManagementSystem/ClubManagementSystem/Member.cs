using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagementSystem
{

    internal struct Address
    {
        private byte houseNo;
        private byte roadNo;
        private string area;
        private string district;
        internal Address(byte houseNo, byte roadNo, string area, string district)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.area = area;
            this.district = district;
        }
        internal void ShowAddress()
        {
            Console.WriteLine("House Number :{0}\nRoad Number :{1}\nArea name :{2}\nDistrict Name :{3}", this.houseNo, this.roadNo, this.area, this.district);
        }
    }

     internal class Member
    {
        protected string id;
        private string name;
        private double salary;
        private Address address;
        private static int slNo = 0;
        internal Member(string name, double salary, Address address)
        {
            this.Id = (++slNo).ToString("0000");
            this.Name = name;
            this.Salary = salary;
            this.Address = address;
        }
        internal Member(string name, Address address)
        {
            this.Id = (++slNo).ToString("000");
            this.Name = name;
            this.Address = address;
        }
        internal virtual string Id
        {
            get { return this.id; }
            set
            {
                this.id = value;
            }
        }
        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        internal double Salary
        {
            get { return this.salary; }
            set
            {
                this.salary = value;
            }
        }
        internal Address Address
        {
            get { return this.address; }
            set
            {
                this.address = value;
            }
        }
        internal virtual void ShowDetails()
        {
            Console.WriteLine("Id :{0}", this.Id);
            Console.WriteLine("Name :{0}", this.Name);
            Console.WriteLine("Salary :{0}", this.Salary);
            address.ShowAddress();
        }
    }
}

