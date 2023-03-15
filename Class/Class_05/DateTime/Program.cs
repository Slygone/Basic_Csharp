//Empty DateTime    
DateTime emptyDateTime = new DateTime();
Console.WriteLine(emptyDateTime);

//create DateTime with current date and time (local date and time, from the server)
DateTime currentDateTime = DateTime.Now;
Console.WriteLine(currentDateTime);

//create DateTime with specific date
DateTime specificDate = new DateTime(1994, 4, 3);
Console.WriteLine(specificDate);

DateTime anotherDate = new DateTime(2022, 12, 29, 12, 34, 45);
Console.WriteLine(anotherDate);

//string dateString = "05-02-2023";
//string dateString = "05.02.2023";
//parse the date string, pass a string in the format for dates from the server
DateTime parsedDate = DateTime.Parse("02/05/2023");
Console.WriteLine(parsedDate);

DateTime universalDateTime = DateTime.UtcNow;

//get the current day
int day = currentDateTime.Day;
Console.WriteLine($"current day: {day}");

//get the current month
int month = currentDateTime.Month;
Console.WriteLine($"current month: {month}");

//get the current day of the week
//if we don't know what data type it is use var and then see what it is assigned
DayOfWeek dayOfWeek = currentDateTime.DayOfWeek;
Console.WriteLine($"current day of week {dayOfWeek}");

//get current year
int year = DateTime.Now.Year;
Console.WriteLine($"current year: {year}");

DateTime firstDateTime = new DateTime(2000, 2, 3, 13, 45, 45);
DateTime secondDateTime = new DateTime(2020, 5, 3, 13, 45, 45);

//difference is of type TimeSpan
var difference = secondDateTime - firstDateTime;
Console.WriteLine(difference);

int days =  difference.Days;
Console.WriteLine($"Days: {days}");

Console.WriteLine("==================");
//get the date and time 5 days from now
DateTime fiveDaysAhead = DateTime.Now.AddDays(5);
Console.WriteLine(fiveDaysAhead);

//get the date and time 5 days and 5 hours from now

DateTime fiveDaysAndHoursAhead = DateTime.Now.AddDays(5).AddHours(5);
Console.WriteLine(fiveDaysAndHoursAhead);


//get the date and time 2 years and 3 months ago
DateTime twoYearsAndThreeMonthsAgo = DateTime.Now.AddYears(-2).AddMonths(-3);
Console.WriteLine(twoYearsAndThreeMonthsAgo);

//Formatting DateTime to string

string formattedDate = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(formattedDate);
string secondFormattedDate = DateTime.Now.ToString("dddd.MMMM.yyyy");
Console.WriteLine(secondFormattedDate);
string thirdFormattedDate = string.Format()