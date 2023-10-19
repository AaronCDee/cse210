using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Video1", "Joe Soap", 1200);
        video1.AddComment(new Comment("Aaron", "Comment 1"));
        video1.AddComment(new Comment("Baron", "Comment 2"));
        video1.AddComment(new Comment("Caron", "Comment 3"));
        videos.Add(video1);


        Video video2 = new Video("Video2", "John Doe", 2400);
        video2.AddComment(new Comment("Daron", "Comment 4"));
        video2.AddComment(new Comment("Earon", "Comment 5"));
        video2.AddComment(new Comment("Faron", "Comment 6"));
        videos.Add(video2);

        Video video3 = new Video("Video3", "Mr. Beast", 3600);
        video3.AddComment(new Comment("Garon", "Comment 7"));
        video3.AddComment(new Comment("Haron", "Comment 8"));
        video3.AddComment(new Comment("Iaron", "Comment 9"));
        videos.Add(video3);

        Video video4 = new Video("Video4", "PewDiePie", 7200);
        video4.AddComment(new Comment("Jaron", "Comment 10"));
        video4.AddComment(new Comment("Karon", "Comment 11"));
        video4.AddComment(new Comment("Laron", "Comment 12"));
        videos.Add(video4);

        foreach (Video video in videos)
        {   
            video.DisplayAll();
        }
        
    }
}