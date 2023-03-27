using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            this.title = title; 
            this.playCount = 0 ;
            this.id = new Random().Next(10000, 99999) ;
        }

        public void IncreasePlayCount(int playCount)
        {
            //this.playCount += playCount;
            Debug.Assert(playCount <= 25000000);

            try
            {
               checked { this.playCount += playCount; }
            }
            catch(OverflowException err) 
            {
              Console.WriteLine(err.Message);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Details Video");
            Console.WriteLine("ID :" + this.id);
            Console.WriteLine("Video :" + this.title);
            Console.WriteLine("Play Count :" + this.playCount);
        }

        public int getPlayCount()
        { 
            return this.playCount;
        }

        public string getTitle() 
        {
            return this.title;
        }
    }
}
