using System.Globalization;
Console.WriteLine("Please enter your birthday YYYY,MM,DD format!");
string input = Console.ReadLine();
DateTime convertedDate;
if (DateTime.TryParseExact(input, "yyyy,MM,dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out convertedDate))
{
    AgeCalculator(convertedDate);
}
else
{
    Console.WriteLine("Invalid date format. Please enter your birthday in YYYY,MM,DD format.");
}
void AgeCalculator(DateTime birthday)
{
    DateTime currentDate = DateTime.Today;
    int result = currentDate.Year - birthday.Year;
    if(currentDate.Month < birthday.Month)
    {
        result--;
    }
    Console.WriteLine(result);
    
}