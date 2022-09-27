Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    double cube = Math.Pow(i, 3);
    Console.WriteLine(cube);
}
