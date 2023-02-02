Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите желаемую степень: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = a * a;
int count = 3;
while (count <= b)
{
    count++;
    result = result * a;
}
Console.WriteLine($"{a} в степени {b} равно {result}");