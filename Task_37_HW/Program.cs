// Заполняет массив случайными числами
int[] GetArrayFilled(int[] array)
{
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 10);
    }

    return array;
}


// Выводит массив
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Создает второй массив, в который помещяет произведение крайних элементов массива
int[] GetArrayMultiplicated(int[] array)
{
    int size = 0;
    if (array.Length % 10 == 0)
    {
        size = array.Length / 2;
    }
    else size = array.Length / 2 + 1;

    int[] newArray = new int[size];

    if (array.Length % 2 == 0)
    {
        for (int i = 0; i < size; i++)
        {
            int lastArrayI = array.Length - 1 - i;
            newArray[i] = array[i] * array[lastArrayI];
        }
    }
    if (array.Length % 2 == 1)
    {
        
        for (int i = 0; i < size - 1; i++)
        {
            int lastArrayI = array.Length - 1 - i;
            newArray[i] = array[i] * array[lastArrayI];
        }
        newArray[size - 1] = array[size - 1];
    }

    return newArray;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
int[] arrayFilled = GetArrayFilled(arr);
int[] newArray = GetArrayMultiplicated(arrayFilled);

PrintArray(arrayFilled);
PrintArray(newArray);
