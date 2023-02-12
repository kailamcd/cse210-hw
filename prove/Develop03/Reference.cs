class Reference
{
    private string _book;
    private string _chapter;
    private string _verses;



    public Reference(string book, string chapter, string verses) {
        _book = book;
        _chapter = chapter;
        _verses = verses;
    }
    


    public string GetBook() { return _book; }
    public string GetChapter() { return _chapter; }
    public string GetVerse() { return _verses; }


    public string GetReferenceString() {
        return _book + " " + _chapter + ":" + _verses;
    }
}


