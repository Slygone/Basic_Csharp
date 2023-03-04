//input 2 numbers from the console and store them
Console.WriteLine("Please enter first number: ");
string firstInput = Console.ReadLine();
int firstNumber;
bool firstSuccess = int.TryParse(firstInput, out firstNumber);

Console.WriteLine("Please enter second number: ");
string secondInput = Console.ReadLine();
int secondNumber;
bool secondSuccess = int.TryParse(secondInput, out secondNumber);

if (firstSuccess && secondSuccess)
{
    Console.WriteLine("Your first number is: " + firstNumber +
    " Your second number is: " + secondNumber);
    //swap the variables x = y and y = x;
    //extra difficulty don't create a third temp variable
    firstNumber = firstNumber + secondNumber;
    secondNumber = firstNumber - secondNumber;
    firstNumber = firstNumber - secondNumber;
    //print result
    Console.WriteLine("First number is now: " + firstNumber +
        " Second number is now: " + secondNumber);
}
else
{
    Console.WriteLine("Please enter a valid input!");
}