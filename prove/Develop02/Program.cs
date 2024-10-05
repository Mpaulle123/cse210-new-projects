using System;

Prompt getPrompt = new Prompt();
Entry getEntry = new Entry();
Journal journal = new Journal();

string name = journal._firstName;


int running = 0;

while (running !=6)
{
    Console.WriteLine($"Hello {name}, welcome in your journal!");
    Console.WriteLine("1. Whrite");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Erase");
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Load");
    Console.WriteLine("6. Quit");
    Console.Write($"What do you want to do {name} ? ");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            running = 1;
            string prompt = getPrompt.GetRandomPrompt();
            Console.WriteLine(prompt);
            string entry = Console.ReadLine();
            getEntry.GetUserEntry(entry);
            journal.AddEntry(prompt, entry);
            break;
        case "2":
            running = 2;
            journal.DisplayAll();
            break;
        case "3":
        // I added the erase methode to allow the user erase content in the journal(this exceed the requierements)
            running = 3;
            journal.DisplayAll();
            Console.WriteLine("Enter the number of the line you want to erase :");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
            //    the -1 will help erase the good number because normaly the indexes start by 0
                journal.ClearEntry(index - 1);
                getEntry.ClearEntry(index - 1);
                
            }
            else
            {
                Console.WriteLine("Invalide input.");
            }
            break;
            // I add here directly the filepath so that I don't have to write it everytime.
        case "4":
            running = 4;
            string savePath = @"C:\Users\Paulle Mahouangou\Desktop\journal.txt";
            journal.SaveToFile(savePath);
            break;

        case "5":
            running = 5;
            string loadPath = @"C:\Users\Paulle Mahouangou\Desktop\journal.txt";
            journal.LoadFromFile(loadPath);
            break;

        case "6":
            running = 6;
            break;
        default:
            Console.WriteLine("Invalid input. Please try another number.");
            break;
    }
}
