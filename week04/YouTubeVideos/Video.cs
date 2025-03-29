using System;
using System.Security.Cryptography.X509Certificates;

class Video
{
    public List<Comment> _commentEntries = new List<Comment>();

    public string _title;
    public string _author;
    public string _length;

    public void SaveVideo(string file, List<Comment> comments)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(value: $"{_title};{_author};{_length}");
            foreach (Comment comment in comments)
            {
                outputFile.WriteLine(value: $"{comment._username};{comment._dateOfCommentUpload};{comment._comment}");
            }
        }
    }
    public void LoadVideo(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        
        
        for (int commentIndex = 0; commentIndex < lines.Length+1; commentIndex++)
        {
            if (commentIndex == 0)
            {
                string[] videoInfo = lines[commentIndex].Split(";");
                _title = videoInfo[0];
                _author = videoInfo[1];
                _length = videoInfo[2];
            }
            else
            {
                string[] commentInfo = lines[commentIndex].Split(";");
                Comment comment = new Comment();
                comment._username = commentInfo[0];
                comment._dateOfCommentUpload = commentInfo[1];
                comment._comment = commentInfo[2];
                _commentEntries.Add(comment);
            }
        }
    }
    public void CreatComment(string videoName, List<Comment> comments)
    {
        Comment comment = new Comment();
        Console.Write("What is your username? ");
        comment._username = Console.ReadLine();
        Console.Write("Please type in your comment");
        comment._comment = Console.ReadLine();
        DateTime today = DateTime.Now;
        comment._dateOfCommentUpload = today.ToShortDateString();
        comments.Add(comment);
        SaveVideo(videoName, comments);         
        }
    public void Display(string videoName, string videoAuthor, string videoLength, List<Comment> comments)
    {
        Console.WriteLine($"{videoName} by: {videoAuthor}");
        Console.WriteLine($"Video Lengh: {videoLength}");
        Console.WriteLine($"Number of comments: {comments.Count}");
        foreach (Comment comment in comments)
        {
            Console.WriteLine($"{comment._username} - Posted on: {comment._dateOfCommentUpload}");
            Console.WriteLine($"{comment._comment}");
        }
    }
}