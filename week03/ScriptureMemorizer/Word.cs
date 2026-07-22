public class Word {
    private string _text;
    private bool _isHidden;
    private string _originalText;

    public Word(string text) {
        _text = text;
        _originalText = text;
        _isHidden = false;
    }

    public void Hide() {
        string hiddenText = "";
        foreach (char letter in _text)
        {
            if (!char.IsPunctuation(letter))
            {
                hiddenText += "_";
            } else
            {
                hiddenText += letter;
            }
        }

        _text = hiddenText;
        _isHidden = true;
    }

    public void Show() {
        _text = _originalText;
        _isHidden = false;
    }

    public bool IsHidden() {
        return _isHidden;
    }
    
    public string GetDisplayText() {
        return _text;
    }

    // Personal Enhancement
    public bool Check(string text)
    // Chack if the `text` argument equals the original unhidden word 
    {
        string strippedText = string.Concat(text.Where(c => !char.IsPunctuation(c)));
        string cleanedOriginalWord = string.Concat(_originalText.Where(c => !char.IsPunctuation(c)));
        return strippedText == cleanedOriginalWord.ToLower();
    }
}