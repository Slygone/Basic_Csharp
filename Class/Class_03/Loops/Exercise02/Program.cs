//Get an input from number from the console

Console.WriteLine("Please enter a number: ");
string firstInput = Console.ReadLine();
int firstResult;

bool firstSuccess = int.TryParse(firstInput, out firstResult);


// print all even numbers starting from 2
if (firstSuccess )
{
    for (int i = 2; i <= firstResult; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine("the number is even" +  i);
        }
    }
}
else
{
    Console.WriteLine("Invalid input");
}

// get another input number from the console
Console.WriteLine("Please enter a number: ");
string secondInput = Console.ReadLine();
int secondResult;

bool secondSuccess = int.TryParse(secondInput, out secondResult);


//print all odd numbers starting from 1
if (secondSuccess)
{
    for (int i = secondResult; i >= 1; i--)
    {
        if (i % 2 != 0)//(i % 2 == 1) 
        {
            Console.WriteLine("the number is odd" + i);
        }
    }
}
else
{
    Console.WriteLine("Invalid input");
}