DateTime threeDaysAhead = DateTime.Now.AddDays(3);
Console.WriteLine($"Three Days Ahead: {threeDaysAhead}");

DateTime oneMonthAhead = DateTime.Now.AddMonths(1);
Console.WriteLine($"One Month Ahead: {oneMonthAhead}");

DateTime oneMonthAndThreeDaysAhead = DateTime.Now.AddMonths(1).AddDays(3);
Console.WriteLine($"One Month and Three Days Ahead {oneMonthAndThreeDaysAhead}");

DateTime oneYearAndTwoMonthsAgo = DateTime.Now.AddYears(-1).AddMonths(-2);
Console.WriteLine($"One Year and Two Months Ago {oneYearAndTwoMonthsAgo}");

int month = DateTime.Now.Month;
Console.WriteLine($"current month: {month}");

int year = DateTime.Now.Year;
Console.WriteLine($"current year: {year}");