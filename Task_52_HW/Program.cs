// Заполняет массив случайными натуральными числами
int[,] FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,100);
        }
    }
    return array;
}

// Выводит массив
void PrintArray2D (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

// Считает сумму элементов каждого столбца
void ColumnNumbersSum (int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j,i];
        }
        Console.WriteLine($"Среднее арифметическое чисел столбца {i+1} равна {sum/array.GetLength(0)}");
        Console.WriteLine();
    }
}

// Генерация случайного массива
int a = new Random().Next(1,11);
int b = new Random().Next(1,11);
int[,] array = new int [a,b];

FillArray(array);
Console.WriteLine("Сгенерированный массив");
Console.WriteLine();
PrintArray2D(array);
Console.WriteLine();

// Вывод сумм элементов каждого столбца массива
ColumnNumbersSum(array);
