public class Word {
    private string _text;
    private bool _isHidden;

    public Word(string text) {
        _text = text;
    }

    public void Hide() {

    }

    public void Show() {

    }

    public bool isHidden() {
        return _isHidden;
    }
    
    public string GetDiplayText() {
        return _text;
    }
}