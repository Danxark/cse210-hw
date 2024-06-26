using System;


public class Journal
{
    public List<JournalEntry> _journal = new List<JournalEntry>();
    private string fileName = "MyJournal.txt";


    public Journal()
    {
    }

    public void Display()
    {
        Console.WriteLine("\n______________ Journal Entries_____________ ");
        foreach (JournalEntry journalEntry in _journal)
        {
            journalEntry.Display();
        }
    }

    public void CreateJournalFile()
    {
        
        if (!File.Exists(fileName))
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                File.CreateText(fileName);
                outputFile.WriteLine(" _________________Journal Entries______________\n");
                foreach (JournalEntry journalEntry in _journal)
                {
                    outputFile.WriteLine($"{journalEntry._dateTime}");
                    outputFile.WriteLine($"Prompt: {journalEntry._journalPrompt}");
                    outputFile.WriteLine($"Entry: {journalEntry._journalEntry}\n");
                }
            }
            Console.Write("\n** MyJournal.txt has been created! **\n");
        }
        else
        {
            Console.Write("\nxxxx MyJournal.txt already exits. xxxx\n");
            using (StreamWriter outputFile = new StreamWriter(fileName, append: true))
            {
                foreach (JournalEntry journalEntry in _journal)
                {
                    outputFile.WriteLine($"{journalEntry._dateTime}");
                    outputFile.WriteLine($"Prompt: {journalEntry._journalPrompt}");
                    outputFile.WriteLine($"Entry: {journalEntry._journalEntry}\n");
                }
            }
        }
    }

    public void LoadJournalFile()

    {
         if (File.Exists(fileName))
        {
            string text = File.ReadAllText(fileName);
            Console.WriteLine($"\n{text}");
        }
    }

}