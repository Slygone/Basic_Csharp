Console.WriteLine("Please enter a sentence!");
string input = Console.ReadLine();
string[] splittedInput = input.Split(" ");
string largestWord = "";
foreach (string word in splittedInput)
{
    while (largestWord.Length < word.Length)
    {
        largestWord = word;
    }
}

Console.WriteLine($"The largest word in the sentence is: {largestWord} " + largestWord.Length);