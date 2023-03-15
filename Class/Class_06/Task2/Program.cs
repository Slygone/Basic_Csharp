bool exit = true;
while (exit){
    Console.WriteLine("Please enter a number!");
    string userInput = Console.ReadLine();
    double result;
    bool success = double.TryParse(userInput, out result);
    if (success)
    {
        NumberStats(result);
    }
    else
    {
        Console.WriteLine($"{userInput} is not a valid number.");
    }
    Console.WriteLine("Press Y to try again or X to exit");
    string tryAgain = Console.ReadLine();
    if (tryAgain.ToLower() == "x")
    {
        exit = false;
    }
}


void NumberStats(double input)
{
    if (double.IsNaN(input))
    {
        Console.WriteLine("The input is not a valid number.");
    }
    {
        Console.WriteLine($"Stats for number {input}");
        if (input < 0)
        {
            Console.WriteLine("The number is Negative!");
        }
        else
        {
            Console.WriteLine("The number is Positive!");
        }
        if (input % 2 == 0)
        {
            Console.WriteLine("The number is Even!");
        }
        else
        {
            Console.WriteLine("The number is Odd");
        }
        if(input % 1 == 0)
        {
            Console.WriteLine("The input is an Integer.");
        }
        else
        {
            Console.WriteLine("The input is a Decimal.");
        }
        //if (Math.Floor(input) == input && Math.Ceiling(input) == input)
        //{
        //    Console.WriteLine("The input is an Integer.");
        //}
        //else
        //{
        //    Console.WriteLine("The input is a Decimal.");
        //}
    }
}