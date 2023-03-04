//IF-ELSE
int firstNumber = 5;
int secondNumber = 3;

if (firstNumber == secondNumber)
{
    Console.WriteLine("The numbers are equal");
}
else
{
    Console.WriteLine("The numbers are not equal");
}

if (firstNumber > secondNumber)
{
    Console.WriteLine("First Number is greater than second");
}
else if (secondNumber > firstNumber)
{
    Console.WriteLine("Second Number is greater than second");
}
else
{
    Console.WriteLine("Both numbers are equal");
}


//SWITCH

int day;
Console.WriteLine("Please enter a number from 1-7");
string input = Console.ReadLine();

bool success = int.TryParse(input, out day);

if (success)
{
    switch (day)
    {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
        case 3:
        case 4:
        case 5:
            Console.WriteLine("Working day, it is not Monday");
            break;
        case 6:
        case 7:
            Console.WriteLine("It is a weekend");
            break;
        default:
            Console.WriteLine("Invalid Value. It is a number, but not between 1 and 7");
            break;
    }
}
else
{
    Console.WriteLine("Invalid Input");
}