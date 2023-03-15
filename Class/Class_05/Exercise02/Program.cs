using Exercise02;

Human person = new Human();

Console.WriteLine("Enter first name");
string firstName = Console.ReadLine();
person.FirstName = firstName;

Console.WriteLine("Enter last name");
string lastName = Console.ReadLine();
person.LastName = lastName;

Console.WriteLine("Enter age");
string age = Console.ReadLine();
int parsedAge;
bool success = int.TryParse(age, out parsedAge);
if (success)
{
    person.Age = parsedAge;
}
else
{
    Console.WriteLine("Invalid Age input");
}


Console.WriteLine(person.GetPersonStats());