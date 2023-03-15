/*
 * Create 2 methods called Sum and Subtract
Sum will accept two numbers as parameters and return a result from summing the two numbers
Subtract will accept two numbers as parameters and return a result from subtracting the two numbers
Ask a person from the console to enter - or +
Then ask the person to enter two numbers
Call the corresponding method ( sum or subtract ) and return the result to the console
*/

int Sum(int numOne, int numTwo)
{
    return numOne + numTwo;
}

int Subtract (int numOne, int numTwo)
{
    return numOne - numTwo;
}


int firstNum;
int secondNum;


Console.WriteLine("Please enter the first number: ");
string firstInput = Console.ReadLine();
bool firstSuccess = int.TryParse(firstInput, out firstNum);


Console.WriteLine("Please enter the first number: ");
string secondInput = Console.ReadLine();
bool secondSuccess = int.TryParse(secondInput, out secondNum);


if (firstSuccess && secondSuccess)
{
    Console.WriteLine("Please chooser + or -");
    string input = Console.ReadLine();

    if (input == "+")
    {
        int sum = Sum(firstNum, secondNum);
        Console.WriteLine("The sum is " + sum);
    }
    else if (input == "-")
    {
        int subtract = Subtract(firstNum, secondNum);
        Console.WriteLine("The difference is " + subtract);
    }
}
