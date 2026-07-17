// I learned how to use the Console.Clear() from https://learn.microsoft.com/en-us/dotnet/api/system.console.clear?view=net-10.0


public class Journal
{
    List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        } 
    }    

    public void SaveToFile(string file)
    {

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} | {entry._prompt} | {entry._userEntry}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        //_entries.Clear(); 
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");


            Entry pastEntry = new Entry();
            pastEntry._date = parts[0];
            pastEntry._prompt = parts[1];
            pastEntry._userEntry = parts[2];
            AddEntry(pastEntry);


        }
    }
}