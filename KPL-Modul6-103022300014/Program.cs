using System;

namespace KPL_Modul6_103022300014
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play Count: " + this.playCount);
        }
        
        public int GetPlayCount()
        {
            return playCount;
        }

        public string GetTitle()
        {
            return title;
        }
    }
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        public SayaTubeUser(string username)
        {
            this.Username = username;
            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int playCount = 0;
            foreach (var video in uploadedVideos)
            {
                playCount += video.GetPlayCount();
            }
            return playCount;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }
        public void PrintAllVideoPlaycount()
        {
            for (int j = 0; j < uploadedVideos.Count; j++)
            {
                Console.WriteLine($"Review Film {j +1} dengan judul: {uploadedVideos[j].GetTitle()} oleh {Username}");
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                SayaTubeUser user = new SayaTubeUser("Rahmah Aisyah");

                SayaTubeVideo v1 = new SayaTubeVideo("Interstellar");
                SayaTubeVideo v2 = new SayaTubeVideo("Parasite");
                SayaTubeVideo v3 = new SayaTubeVideo("Joker");
                SayaTubeVideo v4 = new SayaTubeVideo("Flow");
                SayaTubeVideo v5 = new SayaTubeVideo("Herry Potter");
                SayaTubeVideo v6 = new SayaTubeVideo("Inception");
                SayaTubeVideo v7 = new SayaTubeVideo("Herry Potter 2");
                SayaTubeVideo v8 = new SayaTubeVideo("Herry Potter 3");
                SayaTubeVideo v9 = new SayaTubeVideo("FlHerry Potter 4");
                SayaTubeVideo v10 = new SayaTubeVideo("FlHerry Potter 5");

                user.AddVideo(v1);
                user.AddVideo(v2);
                user.AddVideo(v3);
                user.AddVideo(v4);
                user.AddVideo(v5);
                user.AddVideo(v6);
                user.AddVideo(v7);
                user.AddVideo(v8);
                user.AddVideo(v9);
                user.AddVideo(v10);

                user.PrintAllVideoPlaycount();
                 
            }
        }
    }
}
