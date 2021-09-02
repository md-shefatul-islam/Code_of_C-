using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInformation
{
    class Vehicle
    {
        private uint vehicleId;

        internal Vehicle(uint vehicleId)
        {
            this.vehicleId = vehicleId;
        }
        internal uint VehicleId
        {
            set {this.vehicleId = value; }
            get {return this.vehicleId; }
        }

        internal virtual void ShowInfo()
        {
            Console.WriteLine("Vehicle Number : {0}", this.VehicleId);
        }
             
    }
}
