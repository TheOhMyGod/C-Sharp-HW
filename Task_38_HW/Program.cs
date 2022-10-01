// Заполняет массив случайными вещественными числами
double[] GetArrayFilled(double[] array, int startValue, int endValue)
{
    var random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] =  random.Next(startValue, endValue) + random.NextDouble();
    }

    return array;
}


// Выводит массив
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

// Находит максимальное число массива
double FindMax(double[] array)
{
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }

    return max;
}

// Находит минимальное число массива
double FindMin(double[] array)
{
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }

    return min;
}


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число, которое будет считаться начальным для диапазона случайных чисел: ");
int startValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число, которое будет считаться конечным для диапазона случайных чисел: ");
int endValue = Convert.ToInt32(Console.ReadLine());

double[] arr = new double[size];

double[] arrayFilled = GetArrayFilled(arr, startValue, endValue);
Console.Clear();
PrintArray(arrayFilled);
Console.WriteLine();

double substract = FindMax(arrayFilled) - FindMin(arrayFilled);

Console.WriteLine($"Максимальное число массива - {FindMax(arrayFilled)}");
Console.WriteLine($"Минимальное число массива - {FindMin(arrayFilled)}");
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным числами массива - {substract}");
