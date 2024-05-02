using System;

// A code template for the category of things known as Job. The
// responsibility of a Job is to hold and display personal employment information.
public class JournalPrompt
{
    // The C# convention is to start member variables with an underscore _

    public static string[] _prompt = {
        "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",          
            "Did you watch a movie today? If so what?",
            "Did you watch a TV show today? If so what?"
    };
    public List<string> _journalPrompt = new List<string>(_prompt);


    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public JournalPrompt()
    {
    }

    // A method that displays the person's full name as used in eastern 
    // countries or <family name, given name>.
    public void Display()
    {
        var random = new Random();
        // Console.WriteLine(_prompt.Count);
    //    int index = random.Next(_prompt.Count);
    //     string journalPrompt = _prompt[index];
    //     Console.WriteLine($"\n{_journalPrompt}");
    }

}