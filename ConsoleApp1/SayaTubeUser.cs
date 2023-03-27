using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadVideos;
        private string username;

        public SayaTubeUser(string username)
        {
            this.username = username;
            this.uploadVideos= new List<SayaTubeVideo>();
            this.id = new Random().Next(10000, 99999);
        }

        public int DetailsVideo()
        {
            int jml = 0;
            for(int i = 0; i < uploadVideos.Count; i++)
            {
                jml += uploadVideos[i].getPlayCount();
            }
            return jml;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            this.uploadVideos.Add(video); 
        }

        public void printAllVideo()
        {
            Console.WriteLine("User :" + this.username);
            for(int i = 0; i < this.uploadVideos.Count; i++)
            {
                Console.WriteLine("video "+(i+1)+"judul"+ this.uploadVideos[i].getTitle());
            }
        }
    }
}
