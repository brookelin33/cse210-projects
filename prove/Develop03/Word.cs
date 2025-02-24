class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string theWord, bool isHidden = false)
    {
        _word = theWord;
        _isHidden = isHidden;
    }

    public Word()
    {
        _word = "_NULL_";
        _isHidden = false;
    }

    public void SetHidden(bool isHidden) => _isHidden = isHidden;
    public void SetWord(string wordString) => _word = wordString;

    public bool GetHidden() => _isHidden;
    public string GetWord() => _isHidden ? new string('_', _word.Length) : _word;
}
