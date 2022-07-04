Console.WriteLine();
int vertical = 10;
int gorizontal = 10;
int[,] array = new int[vertical, gorizontal];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write("Введите индекс ячейки: ");
int position = Convert.ToInt32(Console.ReadLine());
int positionVertical = position / 10;
int positionGorizontal = position % 10;

if(position >= 0 && position < 100)
{
    Console.Write("Значение ячейки с индексом" + "(" + positionVertical + ", " + positionGorizontal + "): " + array[positionVertical, positionGorizontal]);
}
else
{
    Console.Write("Ячейки с таким индексом не существует");
}


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
