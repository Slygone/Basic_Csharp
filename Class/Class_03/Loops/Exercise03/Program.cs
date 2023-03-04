Console.WriteLine("Please enter a number: ");
string firstInput = Console.ReadLine();
int firstResult;

bool firstSuccess = int.TryParse(firstInput, out firstResult);


if(firstSuccess && firstResult > 0)
{
    for (int i = 0; i <= firstResult; i++)
    {
        if (i % 3 == 0 || i % 7 == 0)
        {
            continue;
        }
        else
        {
            Console.WriteLine("i: " + i);
        }
        if (i == 100)
        {
            Console.WriteLine("The limit is reached");
            break;
        }
    }
}
else
{
    Console.WriteLine("Please enter a valid input");
}