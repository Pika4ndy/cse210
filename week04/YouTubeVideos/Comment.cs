public class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public Comment(string text)
    {
        _name = "Anonymous";
        _text = text;
    }
    
    public void EditComment(string text)
    {
        _text = text;
    }

    public string getName()
    {
        return _name;
    }

    public string getComment()
    {
        return _text;
    }
}