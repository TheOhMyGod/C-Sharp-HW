// Заполняет массив случайными трехзначными числами
int[] GetArrayFilled (int [] array)
{
    var random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }

    return array;
}

// Выводит массив
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

// Считает четные числа массива
int GetEvenNumsQuantity (int[] array)
{
    int counter = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            counter++;
        }
    }
    
    return counter;
}

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] arr = new int[size];

int[] arrayFilled = GetArrayFilled(arr);
PrintArray(arrayFilled);
Console.WriteLine();

Console.WriteLine($"Колличество четных чисел в полученом массиве равно {GetEvenNumsQuantity(arrayFilled)}");
