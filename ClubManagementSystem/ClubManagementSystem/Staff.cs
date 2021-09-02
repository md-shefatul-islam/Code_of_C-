using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagementSystem
{
    class Staff : Member
    {
        private string position;
        internal Staff(string name, Address address, string position) : base(name, address)
        {
            this.Position = position;
        }
        internal string Position
        {
            get { return this.position; }
            set { this.position = value; }
        }
        internal override string Id
        {
            set { this.id = "SC-" + value; }
        }
        internal override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Position is:{0}", this.Position);
            Console.WriteLine();
        }
    }
}
