Console.WriteLine();
int vertical = 10;
int gorizontal = 10;
int[,] array = new int[vertical, gorizontal];
FillArray(array);
PrintArray(array);
Console.WriteLine();
PrintColumnsAverageSums(array);

void FillArray(int [,] a)
{
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = new Random().Next(-99, 100);
        }
    }
}

void PrintArray(int [,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)          
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            if(a[i, j] < 0)
            {
                if(a[i, j] / 10 == 0)
                {
                    Console.Write(a[i, j] + "  ");
                }
                else
                {
                    Console.Write(a[i, j] + " ");
                }
            }
            else
            {
                if(a[i, j] / 10 == 0)
                {
                    Console.Write(" " + a[i, j] + "  ");
                }
                else
                {
                    Console.Write(" " + a[i, j] + " ");
                }
            }
        }
    Console.WriteLine("");
    }
}

void PrintColumnsAverageSums(int [,] a)
{
    Console.Write("Average columns sums: ");
    int sum = 0;
    double averageSum = 0;
    for(int i = 0; i < a.GetLength(1); i++)
    {
        sum = 0;
        for(int j = 0; j < a.GetLength(0); j++)
        {
            sum = sum + a[j, i];
        }
        averageSum = Convert.ToDouble(sum);
        averageSum = averageSum / a.GetLength(0);
        Console.Write(averageSum);
        if(i < a.GetLength(1) - 1)
        {
            Console.Write("; ");
        }
        else
        {
            Console.Write(".");
        }
    }
}