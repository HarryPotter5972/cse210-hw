using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to YouTube!");
        Console.WriteLine("1. Make a video");
        Console.WriteLine("2. Load a video");
        Console.WriteLine("3. Quit");
        string response = Console.ReadLine();
        if (response == "Quit" || response == "3")
        {
            Console.WriteLine("See you next time!");
        }
        else
        {
            while (response != "Very Quit" || response != "5")
            {
                if (response == "Make a video" || response == "1")
                {
                    Video video = new Video();
                    Console.Write("What is the video's title? ");
                    video._title = Console.ReadLine();
                    Console.Write("What is the video's author? ");
                    video._author = Console.ReadLine();
                    Console.Write("What is the length of the video in timestamp format? ");
                    video._length = Console.ReadLine();
                    video._commentEntries = new List<Comment>();
                    video.SaveVideo(video._title, video._commentEntries);
                    response = "quit";
                }
                else if (response == "Load a video" || response == "2")
                {
                    Console.Write("What video would you like to watch? ");
                    string videoToWatch = Console.ReadLine();
                    Video video = new Video();
                    video.LoadVideo(videoToWatch);
                    Console.Write("Want to do more? ");
                    string answer = Console.ReadLine();
                    if (answer == "Yes")
                    {
                        Console.Write("Want to write a comment? ");
                        response = Console.ReadLine();
                    }
                    else
                    {
                        response = "Quit";
                    }
                }
                else if (response == "Yes")
                {
                    Comment comment = new Comment();
                    Console.Write("What is your username? ");
                    comment._username = Console.ReadLine();
                    Console.Write("Please type in your comment");
                    comment._comment = Console.ReadLine();
                    DateTime today = DateTime.Now;
                    comment._dateOfCommentUpload = today.ToShortDateString();
                    
                }
                else
                {
                    Console.WriteLine("Thank you for using YouTube!");
                    break;
                }
            }
        }
    }
}