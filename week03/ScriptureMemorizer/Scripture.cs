public class Scripture {
    private Reference _reference = new Reference();
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text) {
        _reference = reference;

        // Transform the text string into Word
        
        // Change later
        List<string> wordsStr = new List<string>();
        wordsStr.AddRange(text.Split(" "));
        
        foreach (string word in wordsStr) {
            Word convertedWord = new Word(word);
            _words.Add(convertedWord);
        }

    }

    public void HideRandomWords(int numberToHide) {
        // Something is done here
    }

    public string GetDisplayText() {
        return "";
    }

    public bool IsCompletlyHidden() {
        return false;
    }
}