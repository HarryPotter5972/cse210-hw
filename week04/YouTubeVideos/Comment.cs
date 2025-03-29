using System;

class Comment
{
    public string _dateOfCommentUpload;
    public string _comment;
    public string _username;

    public void Display(string date, string comment, string username)
    {
        Console.WriteLine($"Date: {date} - {username}");
        Console.WriteLine($"{comment}");
    }
}