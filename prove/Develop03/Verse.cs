class Verse
{
    private Reference _verseReference;
    private List<Word> _verseWords;
    private Random _rand;

    public Verse(string verse)
    {
        _verseReference = new Reference();
        ParseVerse(verse);
        _rand = new Random();
    }

    public Verse(string reference, string verse)
    {
        _verseReference = new Reference(reference);
        ParseVerse(verse);
        _rand = new Random(); 
    }

    private void ParseVerse(string verse)
    {
        _verseWords = new List<Word>(); 
        verse = verse + " ";           
        string currentWord = "";
        Word theWord;

        foreach (char let in verse)
        {
            if (let == ' ') 
            {
                if (!string.IsNullOrEmpty(currentWord))
                {
                    theWord = new Word(currentWord);
                    _verseWords.Add(theWord);
                }
                currentWord = "";
            }
            else
            {
                currentWord += let; 
            }
        }
    }

    public bool CheckAllHidden()
    {
        return _verseWords.All(word => word.GetHidden());
    }

    public void DisplayVerse()
    {
        Console.WriteLine(_verseReference.GetFullReference());
        foreach (Word word in _verseWords)
        {
            Console.Write($"{word.GetWord()} ");
        }
        Console.WriteLine();
    }

    public void HideWords(int numOfHidden)
    {
        int hiddenCount = 0;
        while (hiddenCount < numOfHidden)
        {
            var unhiddenWords = _verseWords.Where(word => !word.GetHidden()).ToList();

            if (unhiddenWords.Count == 0)
                break;

            var randomWord = unhiddenWords[_rand.Next(unhiddenWords.Count)];
            randomWord.SetHidden(true);
            hiddenCount++;
        }
    }
}
