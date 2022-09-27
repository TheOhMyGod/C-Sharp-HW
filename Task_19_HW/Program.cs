Console.Write("Введите любое пятичзначное число: ");

int inputNumber = int.Parse(Console.ReadLine());

int x = inputNumber / 1000;
int y = inputNumber % 100;

int firstDigit = inputNumber / 10000;
int secondDigit = x % 10;
int forthDigit = y / 10;
int fifthDigit = inputNumber % 10;

if (firstDigit == fifthDigit && secondDigit == forthDigit)
{
    Console.WriteLine($"Число {inputNumber} является палиндромом!");
}
else Console.WriteLine($"Число {inputNumber} не является палиндромом!");
