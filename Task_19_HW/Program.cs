Console.Write("Введите любое пятичзначное число: ");

int InputNumber = int.Parse(Console.ReadLine());

int x = InputNumber / 1000;
int y = InputNumber % 100;

int FirstDigit = InputNumber / 10000;
int SecondDigit = x % 10;
int ForthDigit = y / 10;
int FifthDigit = InputNumber % 10;

if (FirstDigit == FifthDigit && SecondDigit == ForthDigit)
{
    Console.WriteLine($"Число {InputNumber} является палиндромом!");
}
else Console.WriteLine($"Число {InputNumber} не является палиндромом!");
