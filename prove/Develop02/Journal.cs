class Journal
{
    private List<string> entries = new List<string>();
    private string filePath = "journal.txt"; // File to store entries

    public void AddEntry(string prompt, string answer, string date)
    {
        string entry = $"{date} \n {prompt} \n {answer}";
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }

        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile()
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry);
            }
        }
    }

    public void LoadFromFile()
    {
        if (File.Exists(filePath))
        {
            entries.Clear();
            string[] lines = File.ReadAllLines(filePath);
            entries.AddRange(lines);
            Console.WriteLine("Journal loaded.");
        }
    }
}