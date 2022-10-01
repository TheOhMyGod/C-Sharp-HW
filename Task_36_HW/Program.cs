// Заполняет массив случайными трехзначными числами
int[] GetArrayFilled(int[] array, int startValue, int endValue)
{
    var random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startValue, endValue + 1);
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

// Суммирует элементы массива на нечетных позициях
int FindSumOfEvenNums(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + array[i];
        }
    }

    return sum;
}


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число, которое будет считаться начальным для диапазона случайных чисел: ");
int startValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число, которое будет считаться конечным для диапазона случайных чисел: ");
int endValue = Convert.ToInt32(Console.ReadLine());


int[] arr = new int[size];

int[] arrayFilled = GetArrayFilled(arr, startValue, endValue);
PrintArray(arrayFilled);
Console.WriteLine();

Console.WriteLine($"Сумма элементов стоящих на нечетных позициях - {FindSumOfEvenNums(arrayFilled)}");
