using System;

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
            int index = 0;
            foreach (Comment comment in comments)
            {
                outputFile.WriteLine(value: $"{comments[index]._username};{comments[index]._dateOfCommentUpload};{comments[index]._comment}");
            }
        }
    }
    public void LoadVideo(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        
        List<Comment> comments = new List<Comment>();
        
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
            }
        }
        
        

    }
}