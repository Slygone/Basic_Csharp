Dictionary<string, long> phoneBook = new Dictionary<string, long>()
{
    {"Bob", 71123123 },
    {"Kate", 71553123 },
    {"Paul", 71153232 },
    {"Ana", 71822332 },
    {"Jill", 78108123 },
};

//THE KEYS IN A DICTONARY MUST BE UNIQUE

Console.WriteLine("Enter a name");
string input = Console.ReadLine();

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("Invalid Input");
}
else
{
    if (phoneBook.ContainsKey(input))
    {
        Console.WriteLine($"The phone number of {input} is {phoneBook[input]}");
    }
    else
    {
        Console.WriteLine($"{input} does not exist!");
    }

    
    //Alternative validation
    //foreach (var item in phoneBook)
    //{
    //    if(item.Key.ToLower() == input.ToLower())
    //    {
    //        Console.WriteLine(item.Value);
    //        break;
    //    }
    //}
}

