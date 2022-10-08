void Numbers(int n)
{
    if (n > 1)
    {
        Console.Write($"{n}, ");
        Numbers(n - 1);
    }
    else if (n == 1)
    {
        Console.Write($"{n}");
    }
}

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

Numbers(n);
