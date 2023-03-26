List<int> numbers = new List<int>() { 1, 2, 3,4,5,6,7,8,9,10 };
List<int> squares = numbers.Select(x => x * x).ToList();
Console.WriteLine("==========Squares===========");
foreach (int number in squares)
{
    Console.WriteLine(number);
}
Console.WriteLine("=========Evens============");
List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
foreach (int number in evenNumbers)
{
    Console.WriteLine(number);
}
Console.WriteLine("===========Evens from Square==========");
List<int> evenNumbersOfSquares = squares.Where(x => x % 2 == 0).ToList();
foreach (int number in evenNumbersOfSquares)
{
    Console.WriteLine(number);
}
