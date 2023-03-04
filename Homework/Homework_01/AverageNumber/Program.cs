////ask user to input 4 numbers
//Console.WriteLine("Please enter first number: ");
//string firstInput = Console.ReadLine();
//int firstNumber;
//bool firstSuccess = int.TryParse(firstInput, out firstNumber);

//Console.WriteLine("Please enter second number: ");
//string secondInput = Console.ReadLine();
//int secondNumber;
//bool secondSuccess = int.TryParse(secondInput, out secondNumber);

//Console.WriteLine("Please enter third number: ");
//string thirdInput = Console.ReadLine();
//int thirdNumber;
//bool thirdSuccess = int.TryParse(thirdInput, out thirdNumber);

//Console.WriteLine("Please enter fourth number: ");
//string fourthInput = Console.ReadLine();
//int fourthNumber;
//bool fourthSuccess = int.TryParse(fourthInput, out fourthNumber);

////validate if inputs are numbers
//if (firstSuccess && secondSuccess && thirdSuccess && fourthSuccess)
//{
//    //add the 4 inputs and divide by 4 to get average
//    int result = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
//    //print the result
//    Console.WriteLine("The average is: " + result);
//}
//else
//{
//    Console.WriteLine("Invalid Input");
//}

int counter = 0;
int number = 0;
int addedNumber = 0;
while (counter < 4)
{
    Console.WriteLine("Please enter number: ");
    string input = Console.ReadLine();
    bool success = int.TryParse(input, out number);
    addedNumber += number;
    counter++;
    if (success)
    {
        if (counter == 4)
        {
            int result = addedNumber / counter;
            Console.WriteLine("The average is: " + result);
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid input!");
        number = 0;
        addedNumber = 0;
        counter = 0;
        continue;
    }
}