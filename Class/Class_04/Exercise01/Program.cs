int[] myArray = new int[5];

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write("Enter a number for element {0}: ", i);
    myArray[i] = int.Parse(Console.ReadLine());
}

int sum = 0;

foreach (int number in myArray)
{
    sum += number;
}
Console.WriteLine("The sum is: {0}",sum);