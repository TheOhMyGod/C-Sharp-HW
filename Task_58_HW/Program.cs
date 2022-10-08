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

// Перемножает 2 сгенерированных матрицы
int[,] ArrayProduct(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) != array2.GetLength(0))
    {
        System.Console.WriteLine("Матрицы невозможно перемножить в таком порядке!");
        return array1;
    }
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                array3[i, j] = array3[i, j] + array1[i, k] * array2[k, j];
            }
        }
    }
    return array3;
}

Console.Write("Введите количество строк M первой матрицы: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов N первой матрицы: ");
int n = int.Parse(Console.ReadLine());

int[,] array1 = new int[m, n];

Console.Write("Введите количество строк K первой матрицы: ");
int k = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов L первой матрицы: ");
int l = int.Parse(Console.ReadLine());

int[,] array2 = new int[k, l];

FillArray(array1);
PrintArray(array1);
Console.WriteLine();

FillArray(array2);
PrintArray(array2);
Console.WriteLine();

int[,] array3 = ArrayProduct(array1, array2);
PrintArray(array3);
