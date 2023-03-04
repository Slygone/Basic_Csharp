Console.WriteLine("Please enter first number");
string firstInt = Console.ReadLine();

Console.WriteLine("Please enter second number");
string SecondInt = Console.ReadLine();

int firstNumber;
int secondNumber;

bool firstSuccess = int.TryParse(firstInt, out firstNumber);//if valid input it will be true
bool secondSuccess = int.TryParse(SecondInt, out secondNumber);

//if (firstsuccess && secondsuccess)
//{
//    if (firstnumber % 2 == 0)
//    {
//        console.writeline("first number is an even number");
//    }
//    else
//    {
//        console.writeline("first number is an odd number");

//    }
//    if (secondnumber % 2 == 0)
//    {
//        console.writeline("second number is an even number");
//    }
//    else
//    {
//        console.writeline("second number is an odd number");
//    }
//}
//else
//{
//    console.writeline("at least one input was incorrect");
//}

//Second Way

if (firstSuccess)
{
    if (firstNumber % 2 == 0)
    {
        Console.WriteLine("First Number is an even number");
    }
    else
    {
        Console.WriteLine("First Number is an odd number");

    }
}
else
{
    Console.WriteLine("First input was incorrect");
}

if (secondSuccess)
{
    if (secondNumber % 2 == 0)
    {
        Console.WriteLine("Second Number is an even number");
    }
    else
    {
        Console.WriteLine("Second Number is an odd number");

    }
}
else
{
    Console.WriteLine("Second input was incorrect");
}