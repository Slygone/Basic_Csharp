Console.WriteLine("Data Types:");

int firstIntVariable = 555; //declaration and initialization
Console.WriteLine("firstIntVariable: " +  firstIntVariable);

short firstShortVar = 6;
Console.WriteLine("firstShortVar: " + firstShortVar);


//int firstIntVariable = 44444; Error

//reinitialization
firstIntVariable = 77768;
Console.WriteLine($"firstIntVariable: {firstIntVariable}" );//INTERPOLATION 


//===Decimal numbers===
float firstFloatVar = 1.675f;
Console.WriteLine("firstFloatVar: " + firstFloatVar);
Console.WriteLine(firstFloatVar + 1);

double firstDoubleVar = 2.3456;
System.Console.WriteLine("firstDoubleVar: " + firstDoubleVar);
Console.WriteLine(firstDoubleVar + 1);


string message = "Hello from SEDC!"; //string are always double quites!!!
Console.WriteLine("message: " + message);

char firstChar = 'a'; //char are always written in single quotes!!!
Console.WriteLine("firstChar: " + firstChar);

bool firstBool = true;

int number; //declaration

var numberOfStudents = 8;


//===Operators===

int sum = 5 + 90;
Console.WriteLine("Sum: " + sum);

sum += 100; // sum = sum + 100;

sum++; //sum = sum + 1; sum += 1;

Console.WriteLine("sum: " + sum);

int secondSum = sum;
//You can't take the value from another variable if its not the same type
//string thirdSum = sum;

//===Default values===
int defaultInt;
//keyword default sets the default value for the variable's type
defaultInt = default;
Console.WriteLine("defaultInt: " + defaultInt);

float defaultFloat = default; //0
Console.WriteLine("defaultFloat: " + defaultFloat);

double defaultDouble = default; //0
Console.WriteLine("defaultDouble: " + defaultDouble);//0


bool defaultBool = default;
Console.WriteLine("defaultBool: " + defaultBool);//always false

string defaultString = default; //null
Console.WriteLine("defaultString: " + defaultString);

string nullString = null;
string emptyString = "";
Console.WriteLine(emptyString.Length);
