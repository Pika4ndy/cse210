public class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public Video()
    {
        _title = "Untitled";
        _author = "Anonymous";
        _length = 0;
    }

    public Video(string title, double length)
    {
        _title = title;
        _author = "Anonymous";
        _length = length;
    }

    public Video(double length)
    {
        _title = "Untitled";
        _author = "Anonymous";
        _length = length;
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    private double[] GetFormattedLength()
    {
        double hours, minutes, seconds;
        minutes = 0;
        hours = 0;

        if (_length >= 60)
        {
            minutes = _length / 60;
            
            if (minutes >= 60)
            {
                hours = minutes / 60;
                minutes = (hours - Math.Truncate(hours)) * 60;
                seconds = (minutes - Math.Truncate(minutes)) * 60;
                
                hours = (int)hours;
                minutes = (int)minutes;
                seconds = Math.Round(seconds);
            } else
            {
                seconds = (minutes - Math.Truncate(minutes)) * 60;

                minutes = (int)minutes;
                seconds = Math.Round(seconds);
            }
        } else
        {
            seconds = Math.Round(_length);
        }


        return [hours, minutes, seconds];
    }

    public string GetDisplayComments()
    {
        string display = "";
        int i = 0;
        foreach (Comment comment in _comments)
        {
            i++;
            display += $"{i}. {comment.getName()}: '{comment.getComment()}'\n";
        }

        return display;
    }

    public string GetVideoInfo()
    {
        double[] formattedLength = GetFormattedLength();
        double hours = formattedLength[0];
        double minutes = formattedLength[1];
        double seconds = formattedLength[2];

        return $"{_title} — {_author} — {hours}h {minutes}min {seconds}s";
    }
}