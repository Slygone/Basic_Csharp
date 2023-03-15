// Function (method) with no params and no return value


using System.Security.Cryptography.X509Certificates;

void PrintMessage()
{
    Console.WriteLine("Hello from our first method");
}
PrintMessage();


//Function (method) with params and no return value

void Greetings(string name)
{
    Console.WriteLine($"Greetings: {name}");
}

Greetings("SEDC");

void PrintInfo(string name, int age)
{
    Console.WriteLine(name + " is " + age + " years old");
}

PrintInfo("Nikola", 33);

string GetMessage()
{
    return "Hello from GetMessage";
}

string message = GetMessage();
GetMessage();
Console.WriteLine("Message: " + message);

string CheckIfItIsWeekend(bool isWeekend)
{
    if (isWeekend)
    {
        return "Yay! It is weekend";
    }else
    {
        return "Sorry it is a working day!";
    }
}

string weekendMessage = CheckIfItIsWeekend(false);