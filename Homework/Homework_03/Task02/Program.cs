using System.Runtime.CompilerServices;

Console.WriteLine("Please enter a sentence!");
string input = Console.ReadLine();
//using variable to store the value

//string[] splittedInput = input.Split(" ");
//foreach (string words in splittedInput)
//{
//    Console.WriteLine(words);
//}

//using it directly with foreach
foreach (string word in input.Split(" "))
{
    Console.WriteLine(word);
}