using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create Videos
        Video video1 = new Video("The Passion of Christ", "Mel Gibson", "02:07:00");
        Video video2 = new Video("The Forge", "Alex Kendrick", "02:04:00");
        Video video3 = new Video("Breath of Life", "BB Sasore", "01:54:00");

        // Comments
        video1.AddComment("Levi Omagbemi", "I love this movie so much, great work!");
        video1.AddComment("John Doe", "What a wonderful movie!");
        video1.AddComment("Sarah Wilson", "So emotional!");

        video2.AddComment("Rudy Huxtable", "I learnt a lot about discipleship from this movie.");
        video2.AddComment("Micheal O'Neill", "You can only be a discipler if you show empathy. Great Movie!");
        video2.AddComment("Pat Phyne", "Thank you so much for this wonderful movie.");

        video3.AddComment("Grace Reyes", "What a masterpiece!");
        video3.AddComment("Gloria Clifford", "His will is always done!");
        video3.AddComment("Nora Gerald", "I feel like watching it again!");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);


        foreach (Video video in videos)
        {
            video.Display();
        }              
    }
}