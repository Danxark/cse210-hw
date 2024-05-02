
public class Journal
{
    public List<Entry> _entry;

    public void AddEntry(Entry newEntry)

    {
        
        

    }

    public void DisplayAll()
    {
       
        


    }

    public void SaveToFile(string file)
    {

    }
    public void LoadFromFile(string file)
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {

            string[] parts = line.Split(",");
            string firstName = parts[0];
            string lastName = parts[1];
        }
    }
}