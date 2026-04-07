public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry e in _entries)
        {
            Console.WriteLine(e.GetDisplay());
            Console.WriteLine();
        }
    }

    public void Save(string fileName)
    {
        List<string> lines = new List<string>();

        foreach (Entry e in _entries)
        {
            lines.Add($"{e._date}|{e._prompt}|{e._text}");
        }

        File.WriteAllLines(fileName, lines);
        Console.WriteLine("File saved");
    }

    public void Load(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found");
            return;
        }

        _entries.Clear();

        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry(parts[1], parts[2]);
            entry._date = parts[0];

            _entries.Add(entry);
        }

        Console.WriteLine("File loaded");
    }
}