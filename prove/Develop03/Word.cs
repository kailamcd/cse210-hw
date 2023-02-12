class Word {

    private string _word;
    private bool _isHidden;

    public Word(string word) {
        _word = word;
        _isHidden = false;
    }

    public void HideWord() {
        _isHidden = true;
    }

    public void ShowWord() {
        _isHidden = false;
    }

    public bool IsHidden() {
        return _isHidden;
    }

    public string GetEachWord() {
        if(_isHidden)
        {
            return "______";
        }
        else
        {
            return _word;
        }

    }
}