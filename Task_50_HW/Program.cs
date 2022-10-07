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

bool AreUserRowsAndColumnsInArray (int[,] array, int m, int n)
{
    if (array[m,n] > 0)
    {
        return true;
    }
    return false;
}

int a = new Random().Next(1,11);
int b = new Random().Next(1,11);

int[,] array = new int [a,b];
FillArray(array);
Console.WriteLine($"Задан массив из {a} строк, {b} столбцов");
Console.WriteLine();
PrintArray2D(array);
Console.WriteLine();

try
{
    Console.WriteLine("Задайте координаты элемента (строку и столбец)");
    Console.WriteLine();
    Console.Write("Введите номер строки M: ");
    int m = int.Parse(Console.ReadLine());

    Console.Write("Введите номер столбца N: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine();

    bool result = AreUserRowsAndColumnsInArray(array, m, n);
    
    if (result == true)
    {
        Console.WriteLine($"В данном элементе находится число {array[m,n]}");
    }
}

catch (System.Exception)
{
    Console.WriteLine("Элемента с такими координатами нет в массиве!");
}
