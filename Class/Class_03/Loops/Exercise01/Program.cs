Console.WriteLine("Please enter a number to count to: ");
string firstInput = Console.ReadLine();
int firstResult;

bool firstSuccess = int.TryParse(firstInput, out firstResult);
if (firstSuccess)
{
    for (int i = 1; i <= firstResult; i++)
    {
        Console.WriteLine("numbers: " + i);
    }
}
else
{
    Console.WriteLine("Invalid Input please enter a valid number");
}

Console.WriteLine("Please enter a number to count down from: ");
string secondInput = Console.ReadLine();
int secondResult;

bool secondSuccess = int.TryParse(secondInput, out secondResult);
if (secondSuccess)
{
    for (int i = secondResult; i >= 1; i--)
    {
        Console.WriteLine("numbers: " + i);
    }
}
else
{
    Console.WriteLine("Invalid Input please enter a valid number");
}