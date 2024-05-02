using System;
using System.IO;

class Program
{

    static void Main(string[] args)
    {
        // Journal myJournal = new Journal();
        // myJournal.Run();


        int[] validNumbers = { 1, 2, 3, 4, 5 };
        int action = 0;
        Console.Write("\n**** Welcome to the Journal App ****\n");
        // Create new journal reference/list
        Journal journal = new Journal();


        while (action != 5)
        {
            // Ask for user input (1-5)
            //Call Choices
            action = Choices();

            switch (action)
            {
                case 1:
                    // Write Journal Entry
                    string dateInfo = GetDateTime();
                    string prompt = JournalPrompts();
                    JournalEntry entry = new JournalEntry();
                    entry._dateTime = dateInfo;
                    entry._journalPrompt = prompt;

                    Console.Write(">>> ");
                    string userEntry = Console.ReadLine();
                    entry._journalEntry = userEntry;

                    journal._journal.Add(entry);

                    // Console.WriteLine("Success Choice 1!");
                    break;
                case 2:
                    // Display Journal Entries
                    journal.Display();
                    // Console.WriteLine("Success Choice 2!");
                    break;
                case 3:
                    // Load
                    journal.LoadJournalFile();
                    // Console.WriteLine("Success Choice 3!");
                    break;
                case 4:
                    // Save
                    journal.CreateJournalFile();
                    // Console.WriteLine("Success Choice 4!");
                    break;
                case 5:
                    // Quite
                    Console.WriteLine("\nThank you for using the Journal App!\n");
                    break;
                default:
                    Console.WriteLine("\nSorry that is not a valid choice!");
                    break;
            }
        }


    }

    static string JournalPrompts()
    // Method to display random journal prompts to user
    {
        var random = new Random();

        var prompt = new List<string> {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "Did you watch a movie today? If so what?",
            "Did you watch a TV show today? If so what?"
        };
        int index = random.Next(prompt.Count);
        string journalPrompt = prompt[index];
        Console.WriteLine($"\n{journalPrompt}");

        return journalPrompt;
    }


    static int Choices()
    // Method to display choices to user
    {
        string choices = @"
Please select one of the following choices:
1. Write
2. Display
3. Load
4. Save
5. Quit
What would you like to do? ";

        Console.Write(choices);
        string userInput = Console.ReadLine();
        int action = int.Parse(userInput);

        return action;
    }

    static string GetDateTime()
    // Method to get the date and time for journal record
    {
        DateTime now = DateTime.Now;
        string currentDateTime = now.ToString("F");
        // Console.WriteLine(now.ToString("F"));
        // Displays Saturday, March 01, 2008 7:00:00 AM
        return currentDateTime;
    }
    static void AddJournalEntry()
    // Method to add entry to text file
    {
        string MyJournalFile = "MyJournal.txt";
        File.AppendAllText(MyJournalFile, "");
    }


}