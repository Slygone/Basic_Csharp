string message = "We are learning about strings";

string academy = "SEDC";

//Concatenation
string firstMessage = "Welcome to " + academy;
Console.WriteLine(firstMessage);
string secondMessage = $"Welcome to {academy}";
int year = 2023;
string thirdMessage = $"We are students at {academy}, in {year} year";
Console.WriteLine(thirdMessage);
//Formating Strings
string fourthMessage = string.Format("Welcome to {0} in {1}", academy, year);


//Escape
string firstString = "Check your c:\\drive";
Console.WriteLine(firstString);

string secondString =  "We have \"Fair\" elections";
Console.WriteLine(secondString);

//String formatting
Console.WriteLine("=== string formatting===");
string currencyString = string.Format("This costs {0:C}", 150);
Console.WriteLine(currencyString);

string percentString = string.Format("{0:P} participated in the elections", 0.5);
Console.WriteLine(percentString);

string phoneNumber = string.Format("{0:+389##-###-###}", 70123456);
Console.WriteLine(phoneNumber);

Console.WriteLine("--- string methods ===");
string ourString = "  We are learning C# and it is FUN and EASY. Okay maybe just FUN.";

string lowerCaseString = ourString.ToLower();
string upperCaseString = ourString.ToLower();

Console.WriteLine($"ourString: {ourString}");
Console.WriteLine($"lowerCaseString: {lowerCaseString}");
Console.WriteLine($"upperCaseString: {upperCaseString}");

//Length
Console.WriteLine($"The length of our string is: ${ourString.Length}");
string[] splittedStrings = ourString.Split( '.' );
Console.WriteLine(splittedStrings.Length);
Console.WriteLine(splittedStrings[0]);
Console.WriteLine(splittedStrings[1]);
Console.WriteLine(splittedStrings[2]);

string test = "Test";
bool startsWithString = test.StartsWith("Te");
Console.WriteLine(startsWithString);

int indexOfFun = ourString.IndexOf("FUN"); //returns the index of the first occurrence of FUN
int indexOfJS = ourString.IndexOf("JS");

bool containsFun = ourString.Contains("FUN"); //returns true of false, whether FUN is found anywhere in ourString

Console.WriteLine(containsFun);

//from ourString take the substring starting from index 5 and the next 16 characters
string substring = ourString.Substring(5, 16);
Console.WriteLine(substring);

//"       test@email.com" != "test@email.com"\

//eliminate empty spaces at the begining and at the end

string trimmedString = ourString.Trim();
Console.WriteLine(trimmedString);

string[] words = "We are learning C# at SEDC".Split(" ");

char[] chars = ourString.ToCharArray();
Console.WriteLine(chars);
