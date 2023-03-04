double firstDouble = 5;
double secondDouble = 9;

double doubleResult = firstDouble / secondDouble;
Console.WriteLine("doubleResult: " + doubleResult);

//When we divide two whole numbers, the result is the whole of division
int firstint = 5;
int secondint = 9;

int intResult = firstint / secondint;
Console.WriteLine("intResult: " + intResult);


double doubleIntResult = (double)firstint / secondint;
Console.WriteLine("DoubleIntResult: " + doubleIntResult);

double differentTypeResult = firstDouble / firstint;
Console.WriteLine("differentTypeResult: " + differentTypeResult);