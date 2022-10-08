Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

int sum = 0;

int GetSum(int m, int n)
{
    if (m < n)
    {
        sum += m;
        GetSum(m + 1, n);
        return sum + n;
    }
    else if (m > n)
    {
        sum += n;
        GetSum(m, n + 1);
        return sum + m;
    }
    else return 0;
}

Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна {GetSum(m, n)}");
