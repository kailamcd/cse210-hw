class Scripture 
{
    private Reference _reference;

    private List<Word> _words;

    private int _leftToHide;

    private int _scriptureWordCount;


    Random random = new Random();

    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] makeTextArray = text.Split(" ");
        foreach (string word in makeTextArray)
        {
            _words.Add(new Word(word));
        }
    }

    public string GetScriptureText() {
        Console.Clear();
        string scriptureText = _reference.GetReferenceString() + "\n";
        foreach (Word word in _words) {
            scriptureText += word.GetEachWord() + " ";
        }
        return scriptureText;
    }

    public int GetWordCount() {
        _scriptureWordCount = _words.Count;
        return _scriptureWordCount;
    }

    public int IsCompletelyHidden(int hiddenCount, int wordCount) {
        foreach (Word word in _words) {
            if (word.IsHidden()) {
                hiddenCount+=1;
                _leftToHide = wordCount - hiddenCount;
            }
        }
        return _leftToHide;
    }

    public void HideRandomWords() {
        Word wordToHide = _words[random.Next(0, _words.Count)];
        while (wordToHide.IsHidden()) {
            wordToHide = _words[random.Next(0, _words.Count)];
        }
        wordToHide.HideWord();
            }
        }






