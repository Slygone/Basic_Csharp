//===Data entry===
using Microsoft.VisualBasic;

Console.WriteLine("Please enter your name: ");
string name = Console.ReadLine();
Console.WriteLine($"Hi {name} it's nice to meet you!");

Console.WriteLine("Please enter a number: ");
string numberInpuit = Console.ReadLine();

Console.WriteLine("Number input: " + numberInpuit);
Console.WriteLine(numberInpuit.GetType()); // get the data type of the variable

