string[] names = new string[0]; //empty array
int counter = 0;
while (true)
{
    Console.WriteLine("Please enter a name: ");
    string name = Console.ReadLine();

    Array.Resize(ref names, names.Length + 1);
    names[counter] = name;
    counter++;

    //if(name == "N" ||  name == "n")
    //{
    //    break;
    //}
    Console.WriteLine("Would you like to add another name? (Y/N)");
    string input = Console.ReadLine();
    if (input == "N" || input == "n")
    {
        foreach(string value in names)
        {
            Console.WriteLine(value);
        }
        break;
    }
}
