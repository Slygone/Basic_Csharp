using Task3.Models;

User[] users = new User[]
    {
        new User(23, "Username1", "password1"),
        new User(44, "Username2", "password2"),
        new User(1, "Username3", "password3")
    };

Console.WriteLine("Welcome to the User Management System!");
Console.WriteLine("What would you like to do?");
Console.WriteLine("1. Log in");
Console.WriteLine("2. Register");

string input = Console.ReadLine();
switch (input)
{
    case "1":
        Login();
        break;
    case "2":
        Register();
        break;
    default:
        Console.WriteLine("Invalid input. Please try again.");
        break;
}
void Login()
{
    Console.Write("Username: ");
    string username = Console.ReadLine();
    Console.Write("Password: ");
    string password = Console.ReadLine();

    User user = FindUserByUsernameAndPassword(username, password);
    if (user != null)
    {
        Console.WriteLine($"Welcome {user.Username}! Here are your messages:");
        foreach (string message in user.Messages)
        {
            Console.WriteLine(message);
        }
    }
    else
    {
        Console.WriteLine("User not found. Please try again.");
    }
}

void Register()
{
    Console.Write("ID: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Username: ");
    string username = Console.ReadLine();
    Console.Write("Password: ");
    string password = Console.ReadLine();
    User existingUser = FindUserByUsername(username);
    if (existingUser != null)
    {
        Console.WriteLine("Sorry the user already exists. Please try again.");
        return;
    }
    
    User newUser = new User(id, username, password);
    Array.Resize(ref users, users.Length + 1);
    users[users.Length -1] = newUser;
  
    Console.WriteLine("Registration complete! Users:");
    foreach (User user in users)
    {
        Console.WriteLine($"{user.Id} {user.Username}");
    }
}

 User FindUserByUsernameAndPassword(string username, string password)
{
    foreach (User user in users)
    {
        if(user.Username == username && user.Password == password)
        {
            return user;
        }
    }
    return null;
}

User FindUserByUsername(string username)
{
    foreach(User user in users)
    {
        if(user.Username == username)
        {
            return user;
        }
    }
    return null;
}