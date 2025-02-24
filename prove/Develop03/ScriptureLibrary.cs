using System;
using System.Collections.Generic;
using System.Linq;

class ScriptureLibrary
{
    private List<Verse> _verseLibrary;
    private Random _rand;

    public ScriptureLibrary()
    {
        _verseLibrary = new List<Verse>();
        _rand = new Random(); 

        Verse addVerse = new Verse("Mosiah 2:17", "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.");
        _verseLibrary.Add(addVerse);
        addVerse = new Verse("Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        _verseLibrary.Add(addVerse);
    }

    public void DisplayScriptures()  
    {
        foreach (Verse ver in _verseLibrary)
        {
            ver.DisplayVerse();
        }
    }

    public Verse GetScripture() 
    {
        return _verseLibrary.ElementAt(_rand.Next(_verseLibrary.Count));
    }
}
