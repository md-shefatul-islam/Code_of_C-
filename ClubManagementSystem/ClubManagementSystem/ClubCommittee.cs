using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagementSystem
{

    internal class ClubCommittee
    {
        private  Member[] arrMember = new Member[100];
        private  int index = 0;
        internal void AddMember(Member mem)
        {
            arrMember[index] = mem;
            index++;
            Console.WriteLine("\n");
        }
        internal void GetAllDetails()
        {
            int count = 0;
            while (count < index)
            {
                arrMember[count].ShowDetails();
                count++;
            }
        }
    }
}

