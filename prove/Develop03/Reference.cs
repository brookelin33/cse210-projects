class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _verseEnd;

    public Reference(string book, int chapter, int verse, int verseEnd = -1)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _verseEnd = verseEnd;
    }

    public Reference(string fullReference)
    {
        ParseReference(fullReference);
    }

    private void ParseReference(string referenceString)
    {
        referenceString = referenceString.Trim() + "%";
        string parseString = "";
        bool hasMultiple = false;

        foreach (char let in referenceString)
        {
            if (let == ' ') 
            {
                _book = parseString;
                parseString = "";
            }
            else if (let == ':') 
            {
                _chapter = int.Parse(parseString);
                parseString = "";
            }
            else if (let == '-')
            {
                _verse = int.Parse(parseString);
                hasMultiple = true;
                parseString = "";
            }
            else if (let == '%') 
            {
                if (hasMultiple)
                {
                    _verseEnd = int.Parse(parseString);
                }
                else
                {
                    _verseEnd = -1;
                    _verse = int.Parse(parseString);
                }
            }
            else
            {
                parseString += let;
            }
        }
    }

    public string GetBook() => _book;
    public int GetChapter() => _chapter;
    public int GetVerse() => _verse;
    public int GetEndVerse() => _verseEnd;

    public string GetFullReference()
    {
        if (_verseEnd > 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_verseEnd}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }
}
