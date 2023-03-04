string[] studentsG1 = new string[] { "Luke Skywalker", "Obi-Wan", "Chewbacca", "Han Solo", "Yoda" };
string[] studentsG2 = new string[] { "Darth Vader", "Jabba The Hut", "Emperor Palpatine", "Boba Fett", "Grand Moff Tarkin" };

Console.WriteLine("Please enter 1 or 2");
string input = Console.ReadLine();

if (input == "1")
{
    Console.WriteLine("The Students in G1 are: ");
    foreach (string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}
else if(input == "2")
{
    Console.WriteLine("The Students in G2 are: ");
    foreach (string student in studentsG2)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("Please enter 1 or 2 ONLY!");
}
