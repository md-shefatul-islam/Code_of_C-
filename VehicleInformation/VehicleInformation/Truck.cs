using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInformation
{
    internal class Truck : Vehicle
    {
        private uint carryingWeight;

        internal Truck(uint vehicleId , uint carryingWeight ) : base (vehicleId)
        {
            this.CarryingWeight = carryingWeight;
        }
        internal uint CarryingWeight
        {
            set { this.carryingWeight = value; }
            get { return this.carryingWeight; }
        }
        internal void CalculatedToll()
        { 

            if(CarryingWeight<=1)
            {
                Console.WriteLine("The Toll : 1000tk");
            }
            else if(CarryingWeight>1 && CarryingWeight<=2)
            {
                Console.WriteLine("The Toll : 2000tk");
            }
            else
            {
                Console.WriteLine(" no toll");
            }
        }
        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Carrying Weight : {0}", this.CarryingWeight);
            this.CalculatedToll();
        }

    }
}
