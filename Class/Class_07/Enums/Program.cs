using Enums;

int day = 5;

//NOT CLEA, NOT A GOOD PRACTICE
if(day == 5)
{
    Console.WriteLine("Yee it's Friday!");
}

//when comparing with enums we have to typecast(int)
if(day == (int)DaysOfWeek.Friday)
{
    Console.WriteLine("Yee it's Friday!");
}

string role = "";
if(role == "Admin")
{
    Console.WriteLine("Do something");
}

if(role == Role.Admin.ToString())// role == "Admin"
{

}