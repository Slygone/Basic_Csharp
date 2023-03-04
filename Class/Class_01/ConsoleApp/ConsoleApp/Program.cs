Console.WriteLine("Hello, World!");




int height = 5;
for (int i = 0;i < height; i++)
{
    for (int j = 0;j < height + i + 3; j++)
    {
        if (j == height || j == height + 1 || i + j < height - 1)
        {
            Console.Write(" ");
        }else
        {
            Console.Write("*");
        }
        
    }
    Console.WriteLine();
}
