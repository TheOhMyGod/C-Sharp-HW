// Координаты первой точки
Console.Write("Введите первую координату точки A:");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите вторую координату точки A:");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите третью координату точки A:");
int z1 = int.Parse(Console.ReadLine());

//Координаты второй точки
Console.Write("Введите первую координату точки B:");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите вторую координату точки B:");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите третью координату точки B:");
int z2 = int.Parse(Console.ReadLine());

// Решение
double S = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между двумя точками равно - {S}");
