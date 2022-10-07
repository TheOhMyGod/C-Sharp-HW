double[,] FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10) + new Random().NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i, j], 2)} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов N: ");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];

FillArray(array);
PrintArray(array);
