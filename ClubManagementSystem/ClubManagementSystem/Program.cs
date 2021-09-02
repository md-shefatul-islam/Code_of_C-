
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Address(houseNO,roadNo,area,district)    

            Address a1 = new Address(2, 5, "Uttara", "Dhaka");

            Address a2 = new Address(3, 15, "Banani", "Dhaka");



            Staff s = new Staff("BRUCE", a1, "Coach");



            Player P1 = new Player("TONY", a2, 10000, "Striker", 87);

            Player P2 = new Player("CLERK", a1, 14000, "Defender", 71);



            ClubCommittee cc = new ClubCommittee();

            cc.AddMember(s);

            cc.AddMember(P1);

            cc.AddMember(P2);

            cc.GetAllDetails();
        }
    }
}
