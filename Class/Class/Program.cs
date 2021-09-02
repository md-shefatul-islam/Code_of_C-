using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class me
    {
        private byte id;
        private string name;
        private double cgpa;
        private string bloodGroup;

        public me()
        {

        }
        public me(byte id, string name, double cgpa, string bloodGroup)
        {
            this.id = id;
            this.name = name;
            this.cgpa = cgpa;     //it take vlaue from object constructor
            this.bloodGroup = ""; //it donot take any vlaue from object constructor
        }
        public void SetId(byte id)
        {
            this.id = id;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetCgpa(double cgpa)
        {
            this.cgpa = cgpa;
        }
        public void SetBloodgroup(string bloodGroup)
        {
            this.bloodGroup = bloodGroup;
        }
        public byte GetId()
        {
            return id;
        }
        public string GetName()
        {
            return name;
        }
        public double GetCgpa()
        {
            return cgpa;
        }
        public string GetBloodgroup()
        {
            return bloodGroup;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Id : {0}", this.id);
            Console.WriteLine("Name : {0}", this.name);
            Console.WriteLine("Cgpa : {0}", this.cgpa);
            Console.WriteLine("BloodGroup : {0}", this.bloodGroup);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            me m = new me();
            m.SetId(1);
            m.SetName("muslim");
            m.SetCgpa(4.00);
            m.SetBloodgroup("o+");
            m.ShowInfo();


            me m1 = new me(12, "Muslim", 4.00, "o+");
            m1.ShowInfo();
        }
    }
}
