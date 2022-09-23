Console.Write("Введите номер дня недели (от 1 до 7): ");

int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 | day == 7)
{
    System.Console.WriteLine("Этот день - выходной!");
}
if (day != 6 && day != 7)
{
    System.Console.WriteLine("Это будний день!");
}
