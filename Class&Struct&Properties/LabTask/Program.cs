using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask
{
    struct MyDate
    {
        private byte day;
        private byte month;
        private ushort year;

        public MyDate(byte day, byte month, ushort year)
        {
            /* if ((day >= 1 && day <= 31)|| (month >= 1 && month <= 12)|| (year < 2020))
             { 
                 this.day = day;
                 this.month = month;
                 this.year = year;
             }*/
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void ShowMyDate()
        {
            Console.WriteLine("Registration Date: {0}/{1}/{2}", this.day, this.month, this.year);
        }
    }
    class Vehicle
    {
        private uint engineNumber;
        private MyDate registrationDate;

        public Vehicle()
        {
        }
        public Vehicle(uint engineNumber, MyDate registrationDate)
        {
            //this.EngineNumber = engineNumber;
                //this.SetEngineNumber(engineNumber); //this.engineNumber = engineNumber;
            this.SetRegistrationDate(registrationDate);//this.registrationDate = registrationDate;
        }
        /*public void SetEngineNumber(uint engineNumber)
        {
            this.engineNumber = engineNumber;
        }
        public uint GetEngineNumber()
        {
            return engineNumber;
        }*/
        //can write instead of set and get

        public uint EngineNumber    //property
        {
            get { return engineNumber; }
            set { this.engineNumber = value; }
            //assigned value stored in the by default variable 'value' and that value assigned in the set method
        }
        public void SetRegistrationDate(MyDate registrationDate)
        {
            this.registrationDate = registrationDate;
        }
        public MyDate GetRegistrationDate()
        {
            return registrationDate;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Show details-");
            Console.WriteLine("Engine Number : {0}", this.EngineNumber);//GetEngineNumber()); //call get
            registrationDate.ShowMyDate();
        }
    }
}
