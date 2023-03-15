Console.WriteLine("Please enter a number!");
string input = Console.ReadLine();
int parsedInput;
bool success = int.TryParse(input, out parsedInput);
if (success)
{
    SumOfDigitsInNumber(parsedInput);
}
else
{
    Console.WriteLine("Input is invalid!");
}

void SumOfDigitsInNumber(int num)
{
    int result = 0;
    if (parsedInput < 0)
    {
        Console.WriteLine("Please enter a positive number!");
    }
    else
    {
        while (num > 0)
        {
            result = result + num % 10;
            num = num / 10;
        }
        Console.WriteLine($"The sum of the digits in the {parsedInput} is {result}");
    }    
}