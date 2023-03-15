using Task02.Models;
Console.WriteLine("Please enter Name for the dog!");
string dogName = Console.ReadLine();

Console.WriteLine("Please enter Breed for the dog!");
string dogBreed = Console.ReadLine();

Console.WriteLine("Please enter Color for the dog!");
string dogColor = Console.ReadLine();

Console.WriteLine("Please enter 1 to see the dog Eat, 2 to see the dog Play or 3 to see the dog chase its tail!");
string input = Console.ReadLine();


Dog sparky = new Dog(dogName, dogBreed, dogColor);
    

if (input == "1")
{
    sparky.Eat();
    Console.WriteLine(sparky.Eat());
}
else if (input == "2")
{
    sparky.Play();
    Console.WriteLine(sparky.Play());
}
else if (input == "3")
{
    sparky.ChaseTail();
    Console.WriteLine(sparky.ChaseTail());
}
else
{
    Console.WriteLine("Invalid Input");
}