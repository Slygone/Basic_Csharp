Console.WriteLine("Please enter a sentence!");
string input = Console.ReadLine();
if (input.Length < 5)
{
    Console.WriteLine("Please enter a larger sentence!");
    
}
else
{
    Console.WriteLine(input.Substring(input.Length - 5));
}
