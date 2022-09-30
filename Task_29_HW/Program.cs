Console.WriteLine("Введите элементы массива: ");

int[] array = new int[8];
int arrLength = array.Length;
int i = 0;

while (i < arrLength)
{
    array[i] = int.Parse(Console.ReadLine()); ;
    i++;
}

Console.WriteLine("Ваш массив: ");
for (int j = 0; j < arrLength; j++)
{
    Console.Write($"{array[j]} ");
}
