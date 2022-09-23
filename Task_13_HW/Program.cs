Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int reverse = 0;

 while(number>0)  
            {  
                int remainder = number % 10;  
                reverse = (reverse * 10) + remainder;  
                number = number / 10;  
            }

 if (reverse >= 100)
{
    reverse /= 100;
    int ThirdNumber = reverse % 10;
    Console.WriteLine($"Третья цифра введенного числа - {ThirdNumber}");
}

else Console.WriteLine("Введенное число не имеет третьей цифры!");
