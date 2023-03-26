Queue<int> numberQueue = new Queue<int>();

do
{
    Console.WriteLine("Please enter a number:");
    string input = Console.ReadLine();
    bool success = int.TryParse(input, out int parsedInput);

    if (success)
    {        
        numberQueue.Enqueue(parsedInput);
                
        Console.WriteLine("Would you like to enter another number? Y/N");
        string repeatInput = Console.ReadLine()?.ToLower();

        switch (repeatInput)
        {
            case "y":
                break;
            case "n":
                foreach (int number in numberQueue)
                {
                    Console.WriteLine(number);
                }
                return;
            default:
                Console.WriteLine("Invalid input. Please enter Y or N.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
} while (true);