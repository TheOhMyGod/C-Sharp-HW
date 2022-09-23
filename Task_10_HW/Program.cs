Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int FirstNumber = number / 100;
int SecondNumber = number / 10 - FirstNumber * 10;

if (number >= 100 && number <= 999) 
{
    Console.WriteLine($"Вторая цифра введенного числа - {SecondNumber}");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число!");
}
