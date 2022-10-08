int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int MinimumLineOfArray(int[,] array)
{
    int[] sumsOfLines = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumsOfLines[i] = sumsOfLines[i] + array[i, j];
        }
    }
    int minOfSums = sumsOfLines[0];
    int indexOfMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (sumsOfLines[i] < minOfSums)
        {
            minOfSums = sumsOfLines[i];
            indexOfMin = i;
        }
    }
    return indexOfMin;
}

Console.Write("Введите количество строк M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов N: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);

int minSum = MinimumLineOfArray(array);


Console.WriteLine();
Console.Write($"В сгенерированном массиве строкой с наименьшей суммой элементов "
+$"является строка {minSum+1}");
