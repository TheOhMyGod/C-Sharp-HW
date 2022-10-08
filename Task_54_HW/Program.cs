// Заполняет массив случайными натуральными числами
int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
    return array;
}

// Выводит двухмерный массив
void PrintArray2D(int[,] array)
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

//Сортирует каждую строку массива от максимума к минимуму
void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int position = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, position]) 
                {
                    position = k;
                }
            }
            int value = array[i, j];
            array[i, j] = array[i, position];
            array[i, position] = value;
        }
    }


}

// Генерация случайного массива
int a = new Random().Next(1, 10);
int b = new Random().Next(1, 10);
int[,] array = new int[a, b];

FillArray(array);
PrintArray2D(array);
Console.WriteLine();

SortArray(array);
PrintArray2D(array);
