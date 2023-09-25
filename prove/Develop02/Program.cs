using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        
        
        Entry anEntry = new Entry();
       
        anEntry.Display();
        Console.WriteLine("Welcome to the Journal Program!"); 
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write ");
        Console.WriteLine("2. Display ");
        Console.WriteLine("3. Load ");
        Console.WriteLine("4. Save ");
        Console.WriteLine("5. Quit ");
        

    }
        

        
    }
