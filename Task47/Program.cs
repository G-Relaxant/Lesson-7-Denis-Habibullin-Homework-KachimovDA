double[,] array = new double[10, 10];
FillArrayRandomDouble(array);
PrintArray(array);

void FillArrayRandomDouble(double [,] a)
{
    double b = 0;
    for(int i = 0; i < a.GetLength(0); i++)
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            b = Convert.ToDouble(new Random().Next(-99, 100));
            //a[i, j] = Math.Round((b / 10), 1);
            a[i, j] = b / 10;
        }
    }
}

void PrintArray(double [,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)          
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            if(a[i, j] < 0)
            {
                if(a[i, j] * 10 % 10 == 0)
                {
                    Console.Write(a[i, j] + "   ");
                }
                else
                {
                    Console.Write(a[i, j] + " ");
                }
            }
            else
            {
                if(a[i, j] * 10 % 10 == 0)
                {
                    Console.Write(" " + a[i, j] + "   ");
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