Console.Write("Введите любое количество чисел через пробел: ");
double[] array = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Вы ввели {count} чисел больше нуля!");
