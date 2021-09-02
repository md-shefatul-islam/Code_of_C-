using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    struct OurAddress
    {
        public byte houseNo;
        public byte roadNo;
        public ushort postalCode;
        public string district;

       /* public OurAddress(byte houseNo, byte roadNo, ushort postalCode, string district)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.postalCode = postalCode;
            this.district = district;
        }*/
        public void ShowAddress()
        {
            Console.WriteLine("House No: {0}", houseNo);
            Console.WriteLine("Road No: {0}", roadNo);
            Console.WriteLine("Postal Code: {0}",postalCode);
            Console.WriteLine("District: {0}", district);
        }
    }
}
