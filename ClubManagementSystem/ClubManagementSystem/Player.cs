using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagementSystem
{
    class Player : Member
    {
        private string playingPosition;
        private byte currentRank;
        private bool playingStatus = false;
        internal Player(string name, Address address, double salary, string playingPosition, byte currentRank) : base(name, salary, address)
        {
            this.PlayingPosition = playingPosition;
            this.CurrentRank = currentRank;
        }
        internal string PlayingPosition
        {
            get { return this.playingPosition; }
            set { this.playingPosition = value; }
        }
        internal byte CurrentRank
        {
            get { return this.currentRank; }
            set { this.currentRank = value; }
        }
        internal bool PlayingStatus
        {
            get { return this.playingStatus; }
            set { this.playingStatus = value; }
        }
        internal void EligibleCheck()
        {
            if (this.CurrentRank >= 75 && this.CurrentRank <= 100)
            {
                Console.WriteLine("Player is eligible for match.");
                playingStatus = true;
            }
            else
            {
                Console.WriteLine("Player is not eligible for match.");
            }
        }
        string myDate = Convert.ToString(DateTime.Now.Year);
        internal override string Id
        {
            set
            {
                base.Id = "PC-" + value + "-" + myDate;
            }
        }
        internal override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Playing Position is:{0}", this.PlayingPosition);
            Console.WriteLine("Current Rank is:{0}", this.CurrentRank);
            Console.WriteLine("Playing Status is:", this.PlayingStatus);
            EligibleCheck();
            Console.WriteLine();
        }
    }
}

