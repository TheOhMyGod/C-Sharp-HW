double PowerMethod (int a, int b)
{
    double pow = Math.Pow(a,b);
    return pow;
}

Console.Write("Введите число, которое хотите возвести в степень: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите степень: ");
int b = int.Parse(Console.ReadLine());


double pow = PowerMethod(a,b);
Console.Write($"Число {a} в степени {b} равняется {pow}!");
