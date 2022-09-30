Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sum = 0;
int tmp = number;

while (number > 0)
{
    int remainder = number % 10;
    sum = sum + remainder;
    number = number / 10;
}

Console.WriteLine($"Сумма цифр числа {tmp} равна {sum}!");
