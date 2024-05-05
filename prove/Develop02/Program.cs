using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
        FileLoadRead FLR = new FileLoadRead();

        string userInput = "";

        while (userInput != "5")
        {
            Console.WriteLine("\nWelcome to the journal program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            userInput = Console.ReadLine() ?? string.Empty;

            if (userInput == "1")
            {
                Write1 write = new Write1();
                write.WritePrompt();
                journal1._entrylist.Add(write);
            }
            else if (userInput == "2")
            {
                journal1.Display();
            }
            else if (userInput == "3")
            {
                List<Write1> entrylist = FLR.ReadFile();
                journal1.LoadEntry(entrylist);
                journal1.Display();
            }
            else if (userInput == "4")
            {
                FLR.WriteFile(journal1.GetWrite());
                Console.WriteLine("Saved!");
            }
        }
    }
}
// I added two more classes as "FileLoadandRead", that it has the responsability to save and read the file.
// I also added the "Write" class and thought about the other prompt to the user.