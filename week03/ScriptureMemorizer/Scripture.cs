public class Scripture {
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    private Random randomGenerator = new Random();

    public Scripture(Reference reference, string text) 
    {
        _reference = reference;

        // Transform the text string into Word
        
        // Change later
        List<string> wordsStr = [.. text.Split(" ")];
        
        foreach (string word in wordsStr) {
            Word convertedWord = new Word(word);
            _words.Add(convertedWord);
        }

    }

    public void HideRandomWords(int numberToHide) 
    {
        if (!IsCompletlyHidden()) // Verify if all words are not already hidden yet
        {
            if (_words.Count - GetNumberOfHiddenWords() >= numberToHide) // Verify if the number of words showed is still equal or greater than the number to hide
            {
                for (int i = 0; i < numberToHide; i++)
                {
                    int randomIndex = 0;

                    do
                    {
                        randomIndex = randomGenerator.Next(_words.Count);
                    } while (_words[randomIndex].IsHidden());

                    _words[randomIndex].Hide();
                }
            } else // if number to hide is greater, it hides all left words
            {
                foreach (Word word in _words)
                {
                    word.Hide();
                }
            }
        }
    }

    public string GetDisplayText() 
    {
        string scripture = $"{_reference.GetDisplayText()} ";

        foreach (Word word in _words)
        {
            scripture += word.GetDisplayText() + " ";
        }

        return scripture;
    }

    public bool IsCompletlyHidden() {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    // Personal Enhancement
    public int GetNumberOfHiddenWords()
    {
        return _words.Count(word => word.IsHidden());
    }

    public void TryRevealWord(string targetWord)
    {
        List<Word> hiddenWords = [.. _words.FindAll(w => w.IsHidden())];

        foreach (Word w in hiddenWords)
        {
            if (w.Check(targetWord))
            {
                w.Show();
            }
        }
    }
}