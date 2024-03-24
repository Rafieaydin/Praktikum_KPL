using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD06.SayaTubeVideo
{
    internal class SayaTubeVideo
    {
        private int id;
        private String title;
        private int PlayCount;

        public SayaTubeVideo(String title, int PlayCount)
        {
            Random r = new Random();
            this.id =  r.Next(10000, 99999);
            this.title = title;
            this.PlayCount = PlayCount;
        }

        public void incrementPlayCount(int x)
        {
            this.PlayCount =+ x;
        }

        public void printVideoDetails()
        {
            Console.WriteLine("Video ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + PlayCount);
        }
    }
}
