using System;
using System.ComponentModel.Design;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Console.WriteLine("Welcome to YouTube!");
        Console.WriteLine("1. Make a video"); //Be sure to do this first before doing anything else!!!!!!!!
        Console.WriteLine("2. Load a video");
        Console.WriteLine("3. Display video info");
        Console.WriteLine("4. Quit");
        string response = Console.ReadLine();
        if (response == "Quit" || response == "4")
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
                    videos.Add(video);
                    Console.Write("Want to do more? ");
                    response = Console.ReadLine();
                }
                else if (response == "Load a video" || response == "2")
                {
                    Console.Write("What video would you like to watch? ");
                    string videoToWatch = Console.ReadLine();
                    Video video = new Video();
                    video.LoadVideo(videoToWatch);
                    Console.Write("Want to write a comment? ");
                    string answer = Console.ReadLine();
                    if (answer == "Yes")
                    {
                        video.CreatComment(video._title, video._commentEntries);
                        Console.Write("Want to do more? ");
                        response = Console.ReadLine();
                    }
                }
                else if (response == "Display")
                {
                    Console.Write("Select a number. ");
                    string number = Console.ReadLine();
                    int numInt = int.Parse(number);
                    Video video = videos[numInt];
                    video.Display(video._title, video._author, video._length, video._commentEntries);
                    Console.Write("Want to do more? ");
                    response = Console.ReadLine();
                }
                else if (response == "Watch a video")
                {
                    int number = 1;
                    Console.WriteLine("What video do you want to watch?");
                    foreach (Video video in videos)
                    {
                        Console.WriteLine($"{number}. {video._title}");
                        number=+1;
                    }
                    string videoSelection = Console.ReadLine();
                    foreach (Video video in videos)
                    {
                        if (videoSelection == video._title)
                        {
                            Console.WriteLine("Do you want to write a comment? ");
                            string writeComment = Console.ReadLine();
                            if (writeComment == "yes")
                            {
                                video.CreatComment(video._title, video._commentEntries);
                            }
                            else
                            {
                                Console.WriteLine("Want to do more? ");
                                response = Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong video");
                        }
                    }
                    
                }
                {
                    Console.WriteLine("Thank you for using YouTube!");
                    break;
                }
            }
        }
    }
}