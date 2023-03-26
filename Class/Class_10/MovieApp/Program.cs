using MovieApp.Domain.Enums;
using MovieApp.Domain.Models;

try
{
    Movie movie = new Movie("Titanic", Genre.Drama, 10);
}
catch (Exception e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}