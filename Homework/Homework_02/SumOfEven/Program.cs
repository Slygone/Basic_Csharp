int[] numbers = new int[] { 4, 3, 7, 3, 2, 8 };
int sum = 0;
foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        sum += number;
    }
}
Console.WriteLine(sum);