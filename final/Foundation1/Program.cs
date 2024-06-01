using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<Video> videosList = new List<Video>();

        Video video1 = new Video();
        video1._title = " I Was Made For Lovin’ You";
        video1._length = "254";
        video1._author = "YUNGBLUD";
        Comment video1Comment1 = new Comment();
        video1Comment1._name = "Sofia Merry";
        video1Comment1._commentText = "Best cover ever!.";
        Comment video1Comment2 = new Comment();
        video1Comment2._name = "Emmerson Moraes";
        video1Comment2._commentText = "I love your music!";
        Comment video1Comment3 = new Comment();
        video1Comment3._name = "Courtney kardassian";
        video1Comment3._commentText = "Finally! I was immediately hooked when I heard the movie sountrack!";

        Video video2 = new Video();
        video2._title = "Lose Control (Live)";
        video2._length = "240";
        video2._author = "Teddy Swims";
        Comment video2Comment1 = new Comment();
        video2Comment1._name = "Bernardo Silva";
        video2Comment1._commentText = "I lose control while lsitening this song!";
        Comment video2Comment2 = new Comment();
        video2Comment2._name = "Mary Beth";
        video2Comment2._commentText = "Excellent video!";
        Comment video2Comment3 = new Comment();
        video2Comment3._name = "Tori Nelson";
        video2Comment3._commentText = "I can never get tired of this song.";

        Video video3 = new Video();
        video3._title = "Beautiful Things ";
        video3._length = "192";
        video3._author = "Benson Boone";
        Comment video3Comment1 = new Comment();
        video3Comment1._name = "Amanda Reade";
        video3Comment1._commentText = "Thank you so much for this song!";
        Comment video3Comment2 = new Comment();
        video3Comment2._name = "Louis Lane";
        video3Comment2._commentText = "Thank you!, helps me a lot!";
        Comment video3Comment3 = new Comment();
        video3Comment3._name = "Chris Brown";
        video3Comment3._commentText = "You are one of my favorite artists!";
        Comment video3Comment4 = new Comment();
        video3Comment4._name = "Mary Menning";
        video3Comment4._commentText = "Love this song!";


        video1._commentList.Add(video1Comment1);
        video1._commentList.Add(video1Comment2);
        video1._commentList.Add(video1Comment3);

        video2._commentList.Add(video2Comment1);
        video2._commentList.Add(video2Comment2);
        video2._commentList.Add(video2Comment3);

        video3._commentList.Add(video3Comment1);
        video3._commentList.Add(video3Comment2);
        video3._commentList.Add(video3Comment3);
        video3._commentList.Add(video3Comment4);


        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }

    }
}