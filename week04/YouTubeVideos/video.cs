using System;
using System.Collections.Generic;
using System.Text;

// Ensure this namespace matches your project structure if applicable
public class Video
{
    private string _title;
    private string _author;
    private int _videoLengthSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int videoLengthSeconds)
    {
        _title = title;
        _author = author;
        _videoLengthSeconds = videoLengthSeconds;
        _comments = new List<Comment>();
    }

    public string Title => _title;
    public string Author => _author;
    public int VideoLengthSeconds => _videoLengthSeconds;

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public string GetDisplayString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Title: {_title}");
        sb.AppendLine($"Author: {_author}");
        sb.AppendLine($"Length (sec): {_videoLengthSeconds}");
        sb.AppendLine($"Comments ({GetCommentCount()}):");

        foreach (Comment comment in _comments)
        {
            sb.AppendLine("  " + comment.GetDisplayString());
        }

        return sb.ToString();
    }
}

// Dummy Comment class definition for IntelliSense to recognize
// Remove this when using the actual Comment.cs file
public class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public string Name => _name;
    public string Text => _text;

    public string GetDisplayString()
    {
        return $"{_name}: {_text}";
    }
}
