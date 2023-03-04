//for (int i = 0; i < 10 ; i++)
//{
//    Console.WriteLine("I: " +  i);
//}

//// Loops indefinitely unless a condition in the block is met
//for (; ; )
//{
//    Console.WriteLine("Another Iteration");
//    Console.WriteLine("Enter x to exist the loop");
//    string input = Console.ReadLine();

//    if (input == "x" ||  input == "X" )
//    {
//        break;
//    }
//}

// Print all numbers from 1 to 10
//if 5 , skip printing
//if 7 , finish the loop

//for (int i = 0; i <= 10; i++)
//{
//    if (i == 5)
//    {
//        continue;
//    }
//    Console.WriteLine("i: " + i);
//    if (i == 7)
//    {
//        break;
//    }
//}

//While loop
//counter variable is global scoped

//int counter = 0;
//while (counter <= 5)
//{
//    Console.WriteLine("i: " + counter);
//    counter++;
//}
////Infinite while loop
//while(true)
//{
//    Console.WriteLine("We will loop until you enter x");
//    //input variable is block scoped
//    string input = Console.ReadLine();
    
//    if(input == "x" || input == "X")
//        break;
//}

////use while, count 1-10, skip 3 and 5

//int number = 0;

//while (number <= 10)
//{
//    if(number == 3 || number == 5)
//    {
//        //careful, put the code that moves forward before continue so we don't get infinite loop
//        number++;
//        continue;
//    }
//    Console.WriteLine("number: " + number);
//    number++;
//}

//do while

do
{
    Console.WriteLine("This will execute at least once");
}
while (false);