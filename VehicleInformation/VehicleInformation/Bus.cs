using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInformation
{
   internal class Bus : Vehicle
    {
      private  uint noOfSeat;

        internal Bus(uint vehicleId , uint noOfSeat ) : base(vehicleId)
        {
            this.NoOfSeat = noOfSeat;
        }
        internal uint NoOfSeat
        {
            set { this.noOfSeat = value; }
            get { return this.noOfSeat; }
        }
        internal void CalculatedFare(double price)
        {
            Console.WriteLine("Total Fare : {0}", (price * NoOfSeat));
        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("No of Seat : {0}", this.NoOfSeat);
         
        }

    }
}
