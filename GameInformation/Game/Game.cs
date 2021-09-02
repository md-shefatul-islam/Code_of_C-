using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInformation
{
    struct MyTime
    {
        private byte hour;
        private byte minute;
        private byte second;

        public MyTime(byte hour, byte minute, byte second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public void ShowMyTime()
        {
            Console.WriteLine("Start Time: {0}:{1}:{2}", this.hour, this.minute, this.second);
        }
    }
    class Game
    {
        private uint gameNumber;
        private MyTime startTime;

        public Game()
        {
        }
        public Game(uint gameNumber, MyTime startTime)
        {
            this.GameNumber = gameNumber;
            this.StartTime = startTime;
        }

        public uint GameNumber   
        {
            get { return gameNumber; }
            set { this.gameNumber = value; }
        }
        public MyTime StartTime
        {
            get { return startTime; }
            set { this.startTime = value; }
        }
        public void ShowGameInfo()
        {
            Console.WriteLine("Show Game details-");
            Console.WriteLine("Game Number : {0}", this.GameNumber);
            startTime.ShowMyTime();
        }

        public void swap(int x, int y)
        {
            int t = x;
            x = y;
            y = t;
        }
    }
}

