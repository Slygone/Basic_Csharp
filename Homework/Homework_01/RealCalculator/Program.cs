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
    Console.WriteLine("Please enter what mathematical operation you would like to do: ");
    string operationInput = Console.ReadLine();
    string operationOutput;
    if (operationInput == "+"
        || operationInput == "-"
        || operationInput == "*"
        || operationInput == "/")
    {
        switch (operationInput)
        {
            case "+":
                Console.WriteLine("Result of adding " + firstNumber +
                    " and " + secondNumber + " is: " + (firstNumber + secondNumber));
                break;
            case "-":
                Console.WriteLine("Result of subtracting " + firstNumber +
                    " and " + secondNumber + " is: " + (firstNumber - secondNumber));
                break;
            case "*":
                Console.WriteLine("Result of multiplying " + firstNumber +
                    " and " + secondNumber + " is: " + (firstNumber * secondNumber));
                break;
            case "/":
                if (firstNumber == 0 || secondNumber == 0)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
                else
                    Console.WriteLine("Result of dividing " + firstNumber +
                        " and " + secondNumber + " is: " + (firstNumber / secondNumber));
                break;
            default:
                return;
        }
    }
}
else
{
    Console.WriteLine("Invalid Input");
}
