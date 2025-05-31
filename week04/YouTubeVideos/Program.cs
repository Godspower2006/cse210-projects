// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Intro to C#", "CodeAcademy", 600);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Thanks, this helped a lot."));
        video1.AddComment(new Comment("Charlie", "Clear and concise."));
        videos.Add(video1);

        Video video2 = new Video("OOP in C#", "DevTutorials", 750);
        video2.AddComment(new Comment("Diana", "Awesome video!"));
        video2.AddComment(new Comment("Eli", "Very informative."));
        video2.AddComment(new Comment("Fay", "Loved the examples."));
        videos.Add(video2);

        Video video3 = new Video("Abstraction in Programming", "LearnTech", 500);
        video3.AddComment(new Comment("George", "This clarified things for me."));
        video3.AddComment(new Comment("Hannah", "Very well explained."));
        video3.AddComment(new Comment("Ian", "Keep it up!"));
        videos.Add(video3);

        // Display videos and comments
        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayString());
            Console.WriteLine();
        }
    }
}
